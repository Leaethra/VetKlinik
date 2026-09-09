using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VetKlinik
{
    public partial class FrmVetKlinikGiris : Form
    {
        public FrmVetKlinikGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            ValidasyonYoneticisi validator = new ValidasyonYoneticisi();
            bool Basarili = validator.ValidateLogin(kullaniciAdi, sifre, out string mesaj);
            if (Basarili)
            {
                if (kullaniciAdi == "admin") //tek bir hesap yönetim paneline erişebiliyor
                {
                    MessageBox.Show("Yönetici girişi başarılı! Kullanıcı Yönetim Paneline yönlendiriliyorsunuz.", "Yönetici Girişi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmYonetim yonetimEkrani = new FrmYonetim();
                    yonetimEkrani.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Giriş başarılı! VetKlinik Sistemine yönlendiriliyorsunuz.", "Kulanıcı Girişi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmVetKlinikAnaSyf anaEkran = new FrmVetKlinikAnaSyf();
                    anaEkran.Show();
                    this.Hide(); //giriş formunu gizler
                }
            }
            else
            {
                MessageBox.Show(mesaj, "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSifre.Clear();
                txtKullaniciAdi.Focus();
            }

        }
        private void FrmGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
