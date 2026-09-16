using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetKlinik
{
    public partial class FrmIslemler : Form
    {
        private VeriYoneticisi veriYoneticisi;
        private ValidasyonYoneticisi validasyonYoneticisi;
        private TblIslemler seciliIslem;

        public FrmIslemler()
        {
            InitializeComponent();
            veriYoneticisi = new VeriYoneticisi();
            validasyonYoneticisi = new ValidasyonYoneticisi();
        }

        private void FrmIslemler_Load(object sender, EventArgs e)
        {
            dgvIslemler.AutoGenerateColumns = true;
            dgvIslemler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            IslemleriListele();

            dgvIslemler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIslemler.MultiSelect = false;
            dgvIslemler.ReadOnly = true;
            dgvIslemler.AllowUserToAddRows = false;
        }

        private void IslemleriListele()
        {
            try
            {
                string mesaj;

                if (!validasyonYoneticisi.ValidateGetOperations(out mesaj))
                {
                    MessageBox.Show(mesaj, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var islemler = veriYoneticisi.GetOperations()
                    .Select(i => new
                    {
                        i.IslemID,
                        i.IslemAdi,
                        i.BirimFiyat,
                        i.StokMiktari
                    })
                    .ToList();

                dgvIslemler.DataSource = islemler;

                if (dgvIslemler.Columns["IslemID"] != null)
                    dgvIslemler.Columns["IslemID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlemler listelenirken bir hata oluştu.\n\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIslemEkle_Click(object sender, EventArgs e)
        {
            try
            {
                TblIslemler yeniIslem = new TblIslemler
                {
                    IslemAdi = txtIslemAdi.Text.Trim()
                };

                decimal birimFiyat;

                if (!decimal.TryParse(txtBirimFiyat.Text.Trim(), out birimFiyat))
                {
                    MessageBox.Show("Birim fiyat geçerli bir sayı olmalıdır.", "Hatalı Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int? stokMiktari = null;

                if (!string.IsNullOrWhiteSpace(txtStokMiktari.Text))
                {
                    int stok;

                    if (!int.TryParse(txtStokMiktari.Text.Trim(), out stok))
                    {
                        MessageBox.Show("Stok miktarı geçerli bir tam sayı olmalıdır.", "Hatalı Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    stokMiktari = stok;
                }

                yeniIslem.BirimFiyat = birimFiyat;
                yeniIslem.StokMiktari = stokMiktari;

                string mesaj;

                if (!validasyonYoneticisi.ValidateCreateOperation(yeniIslem, out mesaj))
                {
                    MessageBox.Show(mesaj, "Hatalı Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                veriYoneticisi.CreateOperation(yeniIslem);

                MessageBox.Show("İşlem kaydı başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                IslemleriListele();
                AlanlariTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem eklenirken bir hata oluştu.\n\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIslemGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (seciliIslem == null)
                {
                    MessageBox.Show("Lütfen güncellemek istediğiniz işlemi listeden seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                seciliIslem.IslemAdi = txtIslemAdi.Text.Trim();

                decimal birimFiyat;
                int stokMiktari;

                if (!decimal.TryParse(txtBirimFiyat.Text.Trim(), out birimFiyat))
                {
                    MessageBox.Show("Birim fiyat geçerli bir sayı olmalıdır.", "Hatalı Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtStokMiktari.Text.Trim(), out stokMiktari))
                {
                    MessageBox.Show("Stok miktarı geçerli bir tam sayı olmalıdır.", "Hatalı Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                seciliIslem.BirimFiyat = birimFiyat;
                seciliIslem.StokMiktari = stokMiktari;

                string mesaj;

                if (!validasyonYoneticisi.ValidateUpdateOperation(seciliIslem, out mesaj))
                {
                    MessageBox.Show(mesaj, "Hatalı Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                veriYoneticisi.UpdateOperation(seciliIslem);

                MessageBox.Show("İşlem bilgileri başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                IslemleriListele();
                AlanlariTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem güncellenirken bir hata oluştu.\n\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIslemSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (seciliIslem == null)
                {
                    MessageBox.Show("Lütfen silmek istediğiniz işlemi listeden seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult sonuc = MessageBox.Show("Seçili işlem kaydını silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (sonuc != DialogResult.Yes)
                    return;

                string mesaj;

                if (!validasyonYoneticisi.ValidateDeleteOperation(seciliIslem, out mesaj))
                {
                    MessageBox.Show(mesaj, "Hatalı Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                veriYoneticisi.DeleteOperation(seciliIslem);

                MessageBox.Show("İşlem kaydı başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                IslemleriListele();
                AlanlariTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem silinirken bir hata oluştu.\n\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvIslemler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                DataGridViewRow satir = dgvIslemler.Rows[e.RowIndex];

                if (satir.Cells["IslemID"].Value == null)
                    return;

                int islemID = Convert.ToInt32(satir.Cells["IslemID"].Value);
                seciliIslem = veriYoneticisi.GetOperations().FirstOrDefault(i => i.IslemID == islemID);

                if (seciliIslem == null)
                {
                    MessageBox.Show("Seçilen işlem bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                txtIslemAdi.Text = seciliIslem.IslemAdi;
                txtBirimFiyat.Text = seciliIslem.BirimFiyat.ToString();
                txtStokMiktari.Text = seciliIslem.StokMiktari.HasValue ? seciliIslem.StokMiktari.Value.ToString() : "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem bilgileri getirilirken bir hata oluştu.\n\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AlanlariTemizle()
        {
            txtIslemAdi.Clear();
            txtBirimFiyat.Clear();
            txtStokMiktari.Clear();

            seciliIslem = null;
            dgvIslemler.ClearSelection();
        }

        private void FrmIslemler_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (veriYoneticisi != null)
            {
                veriYoneticisi.Dispose();
                veriYoneticisi = null;
            }
        }
    }
}