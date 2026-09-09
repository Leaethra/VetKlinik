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
        public FrmYonetim()
        {
            InitializeComponent();
            //this.FormClosing += FrmYonetim_FormClosing;
        }

        private void FrmYonetim_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbLoginVetKlinikDataSet.TblKullanicilar' table. You can move, or remove it, as needed.
            
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            TblKullanicilar yeniKullanici = new TblKullanicilar();
            yeniKullanici.KullaniciAdi = txtYeniKullanici.Text;
            yeniKullanici.Sifre = txtYeniSifre.Text;

            ValidasyonYoneticisi validator = new ValidasyonYoneticisi();

            if (validator.ValidateCreateUser(yeniKullanici, out string gelenMesaj))
            {
                MessageBox.Show("Yeni personel sisteme başarıyla tanımlandı! Artık kendi ana sayfasını açabilir.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //ttboxları temizle
                txtYeniKullanici.Clear();
                txtYeniSifre.Clear();

                
            }
            else
                MessageBox.Show(gelenMesaj, "İşlem Başarısız.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void FrmYonetim_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}