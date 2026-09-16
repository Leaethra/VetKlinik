using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VetKlinik
{
    public partial class FrmMuayeneKayitlari : Form
    {
        private VeriYoneticisi veriYoneticisi;
        private ValidasyonYoneticisi validasyonYoneticisi;
        private TblMuayeneKayitlari seciliMuayene;

        public FrmMuayeneKayitlari()
        {
            InitializeComponent();
            veriYoneticisi = new VeriYoneticisi();
            validasyonYoneticisi = new ValidasyonYoneticisi();
        }

        private void FrmMuayeneKayitlari_Load(object sender, EventArgs e)
        {
            dgvMuayeneler.AutoGenerateColumns = true;
            dgvMuayeneler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMuayeneler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMuayeneler.MultiSelect = false;
            dgvMuayeneler.ReadOnly = true;
            dgvMuayeneler.AllowUserToAddRows = false;

            HayvanlariListele();
            IslemleriListele();
            MuayeneleriListele();

            dtpIslemTarihi.Value = DateTime.Now;
            txtUcret.ReadOnly = true;
        }

        private void HayvanlariListele()
        {
            cmbHayvan.DataSource = veriYoneticisi.GetAnimal();
            cmbHayvan.DisplayMember = "HastaAdi";
            cmbHayvan.ValueMember = "HastaID";
            cmbHayvan.SelectedIndex = -1;
        }

        private void IslemleriListele()
        {
            clbIslemler.DataSource = veriYoneticisi.GetOperations();
            clbIslemler.DisplayMember = "IslemAdi";
            clbIslemler.ValueMember = "IslemID";
        }

        private void MuayeneleriListele()
        {
            var muayeneler = veriYoneticisi.GetExaminations()
                .Select(m => new
                {
                    m.KayitID,
                    Hayvan = m.TblHayvanlar.HastaAdi,
                    m.IslemTarihi,
                    m.TeshisveNotlar,
                    Islem = string.Join(", ", veriYoneticisi.GetExaminationOperations()
                        .Where(mi => mi.KayitID == m.KayitID)
                        .Select(mi => mi.TblIslemler.IslemAdi)),
                    m.Ucret
                })
                .ToList();

            dgvMuayeneler.DataSource = muayeneler;

            if (dgvMuayeneler.Columns["KayitID"] != null)
                dgvMuayeneler.Columns["KayitID"].Visible = false;
        }

        private void IslemSecimleriniTemizle()
        {
            for (int i = 0; i < clbIslemler.Items.Count; i++)
                clbIslemler.SetItemChecked(i, false);
        }

        private decimal UcretHesapla()
        {
            decimal toplam = 0;

            for (int i = 0; i < clbIslemler.Items.Count; i++)
            {
                if (clbIslemler.GetItemChecked(i))
                {
                    TblIslemler islem = clbIslemler.Items[i] as TblIslemler;

                    if (islem != null)
                        toplam += islem.BirimFiyat;
                }
            }

            return toplam;
        }

        private void clbIslemler_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                txtUcret.Text = UcretHesapla().ToString("0.00");
            }));
        }

        private void btnMuayeneEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbHayvan.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen bir hayvan seçiniz.", "Hatalı Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (clbIslemler.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Lütfen en az bir işlem seçiniz.", "Hatalı Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                TblMuayeneKayitlari yeniMuayene = new TblMuayeneKayitlari
                {
                    HastaID = Convert.ToInt32(cmbHayvan.SelectedValue),
                    IslemTarihi = dtpIslemTarihi.Value.Date,
                    TeshisveNotlar = txtTeshisveNotlar.Text.Trim(),
                    Ucret = UcretHesapla()
                };

                string mesaj;

                if (!validasyonYoneticisi.ValidateCreateExamination(yeniMuayene, out mesaj))
                {
                    MessageBox.Show(mesaj, "Hatalı Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                veriYoneticisi.CreateExamination(yeniMuayene);

                foreach (TblIslemler islem in clbIslemler.CheckedItems)
                {
                    TblMuayeneIslemleri muayeneIslem = new TblMuayeneIslemleri
                    {
                        KayitID = yeniMuayene.KayitID,
                        IslemID = islem.IslemID
                    };

                    veriYoneticisi.CreateExaminationOperation(muayeneIslem);
                }

                MessageBox.Show("Muayene kaydı başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MuayeneleriListele();
                AlanlariTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Muayene eklenirken bir hata oluştu.\n\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMuayeneler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                DataGridViewRow satir = dgvMuayeneler.Rows[e.RowIndex];

                if (satir.Cells["KayitID"].Value == null)
                    return;

                int kayitID = Convert.ToInt32(satir.Cells["KayitID"].Value);
                seciliMuayene = veriYoneticisi.GetExaminationById(kayitID);

                if (seciliMuayene == null)
                {
                    MessageBox.Show("Seçilen muayene bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                cmbHayvan.SelectedValue = seciliMuayene.HastaID;
                dtpIslemTarihi.Value = seciliMuayene.IslemTarihi;
                txtTeshisveNotlar.Text = seciliMuayene.TeshisveNotlar;
                txtUcret.Text = seciliMuayene.Ucret.ToString("0.00");

                IslemSecimleriniTemizle();

                List<int> seciliIslemIDleri = veriYoneticisi.GetExaminationOperations()
                    .Where(mi => mi.KayitID == kayitID)
                    .Select(mi => mi.IslemID)
                    .ToList();

                for (int i = 0; i < clbIslemler.Items.Count; i++)
                {
                    TblIslemler islem = clbIslemler.Items[i] as TblIslemler;

                    if (islem != null && seciliIslemIDleri.Contains(islem.IslemID))
                        clbIslemler.SetItemChecked(i, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Muayene bilgileri getirilirken bir hata oluştu.\n\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMuayeneGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (seciliMuayene == null)
                {
                    MessageBox.Show("Lütfen güncellemek istediğiniz muayeneyi listeden seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbHayvan.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen bir hayvan seçiniz.", "Hatalı Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (clbIslemler.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Lütfen en az bir işlem seçiniz.", "Hatalı Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                seciliMuayene.HastaID = Convert.ToInt32(cmbHayvan.SelectedValue);
                seciliMuayene.IslemTarihi = dtpIslemTarihi.Value.Date;
                seciliMuayene.TeshisveNotlar = txtTeshisveNotlar.Text.Trim();
                seciliMuayene.Ucret = UcretHesapla();

                string mesaj;

                if (!validasyonYoneticisi.ValidateUpdateExamination(seciliMuayene, out mesaj))
                {
                    MessageBox.Show(mesaj, "Hatalı Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                veriYoneticisi.UpdateExamination(seciliMuayene);
                veriYoneticisi.DeleteExaminationOperations(seciliMuayene.KayitID);

                foreach (TblIslemler islem in clbIslemler.CheckedItems)
                {
                    TblMuayeneIslemleri muayeneIslem = new TblMuayeneIslemleri
                    {
                        KayitID = seciliMuayene.KayitID,
                        IslemID = islem.IslemID
                    };

                    veriYoneticisi.CreateExaminationOperation(muayeneIslem);
                }

                MessageBox.Show("Muayene bilgileri başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MuayeneleriListele();
                AlanlariTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Muayene güncellenirken bir hata oluştu.\n\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMuayeneSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (seciliMuayene == null)
                {
                    MessageBox.Show("Lütfen silmek istediğiniz muayeneyi listeden seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult sonuc = MessageBox.Show("Seçili muayene kaydını silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (sonuc != DialogResult.Yes)
                    return;

                string mesaj;

                if (!validasyonYoneticisi.ValidateDeleteExamination(seciliMuayene, out mesaj))
                {
                    MessageBox.Show(mesaj, "Hatalı Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                veriYoneticisi.DeleteExaminationOperations(seciliMuayene.KayitID);
                veriYoneticisi.DeleteExamination(seciliMuayene);

                MessageBox.Show("Muayene kaydı başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MuayeneleriListele();
                AlanlariTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Muayene silinirken bir hata oluştu.\n\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AlanlariTemizle()
        {
            cmbHayvan.SelectedIndex = -1;
            dtpIslemTarihi.Value = DateTime.Now;
            txtTeshisveNotlar.Clear();
            txtUcret.Clear();
            IslemSecimleriniTemizle();

            seciliMuayene = null;
            dgvMuayeneler.ClearSelection();
        }

        private void FrmMuayeneKayitlari_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (veriYoneticisi != null)
            {
                veriYoneticisi.Dispose();
                veriYoneticisi = null;
            }
        }
    }
}