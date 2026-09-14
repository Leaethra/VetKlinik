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
    public partial class FrmYonetim : Form
    {
        private int seciliKullaniciID = 0;

        public FrmYonetim()
        {
            InitializeComponent();
        }

        private void FrmYonetim_Load(object sender, EventArgs e)
        {
            dgvKullanicilar.AutoGenerateColumns = true;
            dgvKullanicilar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            KullaniciListele();

            cmbYetki.Items.Clear();
            cmbYetki.Items.Add("Admin");
            cmbYetki.Items.Add("Kullanici");

            cmbYetki.SelectedIndex = 1;
        }

        private void KullaniciListele()
        {
            using (VeriYoneticisi db = new VeriYoneticisi())
            {
                dgvKullanicilar.DataSource = db.GetUsers()
                    .Select(k => new
                    {
                        k.KullaniciID,
                        k.KullaniciAdi,
                        k.Sifre,
                        k.Yetki
                    })
                    .ToList();
            }
        }
        
        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            TblKullanicilar yeniKullanici = new TblKullanicilar();

            yeniKullanici.KullaniciAdi = txtYeniKullanici.Text;
            yeniKullanici.Sifre = txtYeniSifre.Text;
            yeniKullanici.Yetki = cmbYetki.Text;

            ValidasyonYoneticisi validator = new ValidasyonYoneticisi();
            VeriYoneticisi db = new VeriYoneticisi();

            string gelenMesaj;
            bool basarili = validator.ValidateCreateUser(yeniKullanici, out gelenMesaj);

            if (basarili)
            {
                db.CreateUser(yeniKullanici);

                MessageBox.Show("Yeni personel sisteme başarıyla tanımlandı!","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtYeniKullanici.Clear();
                txtYeniSifre.Clear();

                cmbYetki.SelectedIndex = 1;
                KullaniciListele();
            }
            else
            {
                MessageBox.Show(gelenMesaj, "İşlem Başarısız.",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void dgvKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            seciliKullaniciID = Convert.ToInt32(dgvKullanicilar.Rows[e.RowIndex].Cells["KullaniciID"].Value);
            txtYeniKullanici.Text = dgvKullanicilar.Rows[e.RowIndex].Cells["KullaniciAdi"].Value.ToString();
            txtYeniSifre.Text = dgvKullanicilar.Rows[e.RowIndex].Cells["Sifre"].Value.ToString();
            cmbYetki.Text = dgvKullanicilar.Rows[e.RowIndex].Cells["Yetki"].Value.ToString();
        }

         private void FrmYonetim_FormClosed(object sender, FormClosingEventArgs e)
            {
                Application.Exit();
            }

        private void btnKullaniciGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliKullaniciID == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz kullanıcıyı tablodan seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TblKullanicilar kullanici = new TblKullanicilar();
            kullanici.KullaniciID = seciliKullaniciID;
            kullanici.KullaniciAdi = txtYeniKullanici.Text.Trim();
            kullanici.Sifre = txtYeniSifre.Text.Trim();
            kullanici.Yetki = cmbYetki.Text;

            ValidasyonYoneticisi validator = new ValidasyonYoneticisi();
            string gelenMesaj;
            bool basarili = validator.ValidateUpdateUser(kullanici, out gelenMesaj);

            if (basarili)
            {
                using (VeriYoneticisi db = new VeriYoneticisi())
                {
                    db.UpdateUser(kullanici);
                }
                MessageBox.Show("Kullanıcı başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtYeniKullanici.Clear();
                txtYeniSifre.Clear();
                cmbYetki.SelectedIndex = 1;
                seciliKullaniciID = 0;

                KullaniciListele();
            }
            else
            {
                MessageBox.Show(gelenMesaj, "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnKullaniciSil_Click(object sender, EventArgs e)
{
    if (seciliKullaniciID == 0)
    {
        MessageBox.Show("Lütfen silmek istediğiniz kullanıcıyı tablodan seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }

    DialogResult sonuc = MessageBox.Show("Seçili kullanıcıyı silmek istediğinize emin misiniz?", "Kullanıcı Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

    if (sonuc != DialogResult.Yes)
        return;

    TblKullanicilar kullanici = new TblKullanicilar();
    kullanici.KullaniciID = seciliKullaniciID;

    ValidasyonYoneticisi validator = new ValidasyonYoneticisi();
    string gelenMesaj;
    bool basarili = validator.ValidateDeleteUser(kullanici, out gelenMesaj);

    if (basarili)
    {
        using (VeriYoneticisi db = new VeriYoneticisi())
        {
            db.DeleteUser(kullanici);
        }

        MessageBox.Show("Kullanıcı başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

        txtYeniKullanici.Clear();
        txtYeniSifre.Clear();
        cmbYetki.SelectedIndex = 1;
        seciliKullaniciID = 0;

        KullaniciListele();
    }
    else
    {
        MessageBox.Show(gelenMesaj, "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}
    }
}