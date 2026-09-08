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
            string kullanici = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            ValidasyonYoneticisi validator = new ValidasyonYoneticisi();

            if (validator.ValidateLogin(kullanici, sifre, out string gelenMesaj))
            {
                MessageBox.Show("Giriş başarılı! Sisteme yönlendiriliyorsunuz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);  
                FrmVetKlinikAnaSyf anaEkran = new FrmVetKlinikAnaSyf();
                anaEkran.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(gelenMesaj, "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSifre.Clear();
                txtKullaniciAdi.Focus();
            }
        }
   
    }
}
