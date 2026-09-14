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
    public partial class FrmVetKlinikAnaSyf : Form
    {
        // FrmHastalar formunu tutacak değişken
        private FrmHastalar frmHastalar;
        private FrmSahipler frmSahipler;
        public FrmVetKlinikAnaSyf()
        {
            InitializeComponent();
        }

        private void FrmVetKlinikAnaSyf_Load(object sender, EventArgs e)
        {
        }

        private void btnHayvanlar_Click(object sender, EventArgs e)
        {
            //form daha önce açılmadıysa veya kapatıldıysa yeniden oluştur
            bool acForm = frmHastalar == null || frmHastalar.IsDisposed;

            if (acForm)
            {
                frmHastalar = new FrmHastalar();
                frmHastalar.FormClosed += FrmHastalar_FormClosed; //FrmHastalar kapatıldığında değişkeni temizle 
                frmHastalar.Show();
            }
            else
            {
                frmHastalar.BringToFront();//zaten açıksa öne getir
                frmHastalar.WindowState = FormWindowState.Normal;
            }
        }

        private void FrmHastalar_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmHastalar = null;
        }

        private void btnHayvanSahip_Click(object sender, EventArgs e)
        {
        }

        private void btnIslemler_Click(object sender, EventArgs e)
        {
        }

        private void btnMuayeneler_Click(object sender, EventArgs e)
        {
        }

        private void btnSahipler_Click(object sender, EventArgs e)
        {
            bool acForm = frmSahipler == null || frmSahipler.IsDisposed;

            if (acForm)
            {
                frmSahipler = new FrmSahipler();
                frmSahipler.FormClosed += FrmSahipler_FormClosed;
                frmSahipler.Show();
            }
            else
            {
                frmSahipler.BringToFront();//zaten açıksa öne getir
                frmSahipler.WindowState = FormWindowState.Normal;
            }
        }

        private void FrmSahipler_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmSahipler = null;
        }

        private void FrmVetKlinikAnaSyf_FormClosed(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}