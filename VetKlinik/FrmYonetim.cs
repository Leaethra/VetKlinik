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
        }

        private void FrmYonetim_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbLoginVetKlinikDataSet.TblKullanicilar' table. You can move, or remove it, as needed.
            this.tblKullanicilarTableAdapter.Fill(this.dbLoginVetKlinikDataSet.TblKullanicilar);
        }

    }
}