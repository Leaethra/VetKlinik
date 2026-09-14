using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VetKlinik
{
    public partial class FrmSahipler : Form
    {
        private VeriYoneticisi veriYoneticisi;
        private ValidasyonYoneticisi validasyonYoneticisi;
        private TblSahipler seciliSahip;

        public FrmSahipler()
        {
            InitializeComponent();
            veriYoneticisi = new VeriYoneticisi();
            validasyonYoneticisi = new ValidasyonYoneticisi();
        }

        private void FrmSahipler_Load(object sender, EventArgs e)
        {
            dgvSahipler.AutoGenerateColumns = true;
            SahipleriListele();

            dgvSahipler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSahipler.MultiSelect = false;
            dgvSahipler.ReadOnly = true;
            dgvSahipler.AllowUserToAddRows = false;
            dgvSahipler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SahipleriListele()
        {
            using (VeriYoneticisi db = new VeriYoneticisi())
            {
                dgvSahipler.DataSource = db.GetOwners()
                    .Select(s => new
                    {
                        s.SahipID,
                        s.AdSoyad,
                        s.Telefon,
                        s.Eposta
                    })
                    .ToList();
            }

            if (dgvSahipler.Columns["SahipID"] != null)
                dgvSahipler.Columns["SahipID"].Visible = false;
        }

        private void btnSahipEkle_Click(object sender, EventArgs e)
        {
            try
            {
                TblSahipler yeniSahip = new TblSahipler
                {
                    AdSoyad = txtSahipAdi.Text.Trim(),
                    Telefon = txtTelefon.Text.Trim(),
                    Eposta = txtEposta.Text.Trim(),
                    KayitTarihi = DateTime.Now
                };

                string mesaj;

                if (!validasyonYoneticisi.ValidateCreateOwner(yeniSahip, out mesaj))
                {
                    MessageBox.Show(mesaj, "Hatalı Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                veriYoneticisi.CreateOwner(yeniSahip);

                MessageBox.Show("Sahip kaydı başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SahipleriListele();
                AlanlariTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sahip eklenirken bir hata oluştu.\n\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSahipGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (seciliSahip == null)
                {
                    MessageBox.Show("Lütfen güncellemek istediğiniz sahibi listeden seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                seciliSahip.AdSoyad = txtSahipAdi.Text.Trim();
                seciliSahip.Telefon = txtTelefon.Text.Trim();
                seciliSahip.Eposta = txtEposta.Text.Trim();

                string mesaj;

                if (!validasyonYoneticisi.ValidateUpdateOwner(seciliSahip, out mesaj))
                {
                    MessageBox.Show(mesaj, "Hatalı Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                veriYoneticisi.UpdateOwner(seciliSahip);

                MessageBox.Show("Sahip bilgileri başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SahipleriListele();
                AlanlariTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sahip güncellenirken bir hata oluştu.\n\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSahipSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (seciliSahip == null)
                {
                    MessageBox.Show("Lütfen silmek istediğiniz sahibi listeden seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult sonuc = MessageBox.Show("Seçili sahip kaydını silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (sonuc != DialogResult.Yes)
                    return;

                string mesaj;

                if (!validasyonYoneticisi.ValidateDeleteOwner(seciliSahip, out mesaj))
                {
                    MessageBox.Show(mesaj, "Hatalı Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                veriYoneticisi.DeleteOwner(seciliSahip);

                MessageBox.Show("Sahip kaydı başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SahipleriListele();
                AlanlariTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sahip silinirken bir hata oluştu.\n\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSahipler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                DataGridViewRow satir = dgvSahipler.Rows[e.RowIndex];

                if (satir.Cells["SahipID"].Value == null)
                    return;

                int sahipID = Convert.ToInt32(satir.Cells["SahipID"].Value);
                seciliSahip = veriYoneticisi.GetOwnerById(sahipID);

                if (seciliSahip == null)
                {
                    MessageBox.Show("Seçilen sahip bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                txtSahipAdi.Text = seciliSahip.AdSoyad;
                txtTelefon.Text = seciliSahip.Telefon;
                txtEposta.Text = seciliSahip.Eposta;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sahip bilgileri getirilirken bir hata oluştu.\n\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AlanlariTemizle()
        {
            txtSahipAdi.Clear();
            txtTelefon.Clear();
            txtEposta.Clear();

            seciliSahip = null;
            dgvSahipler.ClearSelection();
        }

        private void FrmSahipler_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (veriYoneticisi != null)
            {
                veriYoneticisi.Dispose();
                veriYoneticisi = null;
            }
        }
    }
}