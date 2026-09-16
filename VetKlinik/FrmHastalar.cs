using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VetKlinik
{
    public partial class FrmHastalar : Form
    {
        private VeriYoneticisi veriYoneticisi;
        private ValidasyonYoneticisi validasyonYoneticisi;
        private TblHayvanlar seciliHayvan;

        public FrmHastalar()
        {
            InitializeComponent();
            veriYoneticisi = new VeriYoneticisi();
            validasyonYoneticisi = new ValidasyonYoneticisi();
        }

        private void FrmHastalar_Load(object sender, EventArgs e)
        {
            HayvanlariListele();

            dgvHastalar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHastalar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHastalar.MultiSelect = false;
            dgvHastalar.ReadOnly = true;
            dgvHastalar.AllowUserToAddRows = false;
            cmbSahip.DataSource = veriYoneticisi.GetOwners();
            cmbSahip.DisplayMember = "AdSoyad";
            cmbSahip.ValueMember = "SahipID";
            cmbSahip.SelectedIndex = -1;

        }

        private void HayvanlariListele()
        {
            try
            {
                string mesaj;

                if (!validasyonYoneticisi.ValidateGetAnimal(null, out mesaj))
                {
                    MessageBox.Show(mesaj,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                var hayvanlar = veriYoneticisi.GetAnimal().Select(h => new
                {
                    h.HastaID,
                    h.HastaAdi,
                    h.Tur,
                    h.Cins,
                    h.DogumTarihi,
                    h.CipNo,
                    h.SahipID,
                    Sahibi = h.TblSahipler.AdSoyad

                }).ToList();

                dgvHastalar.DataSource = hayvanlar;

                if (dgvHastalar.Columns["HastaID"] != null)
                {
                    dgvHastalar.Columns["HastaID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hayvanlar listelenirken bir hata oluştu.\n\n" + ex.Message,"Hata", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                TblHayvanlar yeniHayvan = new TblHayvanlar
                {
                    HastaAdi = txtHastaAdi.Text.Trim(),
                    Tur = txtTur.Text.Trim(),
                    Cins = txtCins.Text.Trim(),
                    CipNo = txtCipNo.Text.Trim(),
                    SahipID = Convert.ToInt32(cmbSahip.SelectedValue)

                };

                DateTime dogumTarihi;

                if (!DateTime.TryParse(txtHDogumTarihi.Text.Trim(), out dogumTarihi))
                {
                    MessageBox.Show("Doğum tarihi geçerli bir tarih olmalıdır.","Hatalı Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                yeniHayvan.DogumTarihi = dogumTarihi;
                string mesaj;

                if (!validasyonYoneticisi.ValidateCreateAnimal(yeniHayvan, out mesaj))
                {
                    MessageBox.Show(mesaj,"Hatalı Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }

                veriYoneticisi.CreateAnimal(yeniHayvan);

                MessageBox.Show("Hayvan kaydı başarıyla eklendi.","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                HayvanlariListele();
                AlanlariTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hayvan eklenirken bir hata oluştu.\n\n" + ex.Message, "Hata", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (seciliHayvan == null)
                {
                    MessageBox.Show("Lütfen güncellemek istediğiniz hayvanı listeden seçiniz.","Uyarı", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }

                seciliHayvan.HastaAdi = txtHastaAdi.Text.Trim();
                seciliHayvan.Tur = txtTur.Text.Trim();
                seciliHayvan.Cins = txtCins.Text.Trim();
                seciliHayvan.CipNo = txtCipNo.Text.Trim();
                seciliHayvan.SahipID = Convert.ToInt32(cmbSahip.SelectedValue);
                seciliHayvan.SahipID = Convert.ToInt32(cmbSahip.SelectedValue);

                DateTime dogumTarihi;

                if (!DateTime.TryParse(txtHDogumTarihi.Text.Trim(), out dogumTarihi))
                {
                    MessageBox.Show("Doğum tarihi geçerli bir tarih olmalıdır.","Hatalı Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }

                seciliHayvan.DogumTarihi = dogumTarihi;
                string mesaj;

                if (!validasyonYoneticisi.ValidateUpdateAnimal(seciliHayvan, out mesaj))
                {
                    MessageBox.Show(mesaj,"Hatalı Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning); return;
                }

                veriYoneticisi.UpdateAnimal(seciliHayvan);
                MessageBox.Show("Hayvan bilgileri başarıyla güncellendi.","Başarılı", MessageBoxButtons.OK,MessageBoxIcon.Information);

                HayvanlariListele();
                AlanlariTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hayvan güncellenirken bir hata oluştu.\n\n" + ex.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (seciliHayvan == null)
                {
                    MessageBox.Show("Lütfen silmek istediğiniz hayvanı listeden seçiniz.", "Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult sonuc = MessageBox.Show("Seçili hayvan kaydını silmek istediğinize emin misiniz?","Silme Onayı", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (sonuc != DialogResult.Yes)
                return;
             

                string mesaj;

                if (!validasyonYoneticisi.ValidateDeleteAnimal(seciliHayvan, out mesaj))
                {
                    MessageBox.Show(mesaj,"Hatalı Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                veriYoneticisi.DeleteAnimal(seciliHayvan);

                MessageBox.Show("Hayvan kaydı başarıyla silindi.","Başarılı", MessageBoxButtons.OK,MessageBoxIcon.Information);

                HayvanlariListele();
                AlanlariTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show( "Hayvan silinirken bir hata oluştu.\n\n" + ex.Message,"Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       private void dgvHastalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                {
                    return;
                }

                DataGridViewRow satir = dgvHastalar.Rows[e.RowIndex];

                if (satir.Cells["HastaID"].Value == null)
                {
                    return;
                }

                int hastaID = Convert.ToInt32(satir.Cells["HastaID"].Value);
                seciliHayvan = veriYoneticisi.GetAnimalById(hastaID);

                if (seciliHayvan == null)
                {
                    MessageBox.Show("Seçilen hayvan bulunamadı.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);

                    return;
                }

                txtHastaAdi.Text = seciliHayvan.HastaAdi;
                txtTur.Text = seciliHayvan.Tur;
                txtCins.Text = seciliHayvan.Cins;
                txtCipNo.Text = seciliHayvan.CipNo;
                txtHDogumTarihi.Text = seciliHayvan.DogumTarihi.HasValue ? seciliHayvan.DogumTarihi.Value.ToString("dd.MM.yyyy") : "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hayvan bilgileri getirilirken bir hata oluştu.\n\n" + ex.Message, "Hata", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void AlanlariTemizle()
        {
            txtHastaAdi.Clear();
            txtTur.Clear();
            txtCins.Clear();
            txtHDogumTarihi.Clear();
            txtCipNo.Clear();
           
            seciliHayvan = null;
            dgvHastalar.ClearSelection();
        }

        private void FrmHastalar_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (veriYoneticisi != null)
            {
                veriYoneticisi.Dispose();
                veriYoneticisi = null;
            }
        }
    }
}

