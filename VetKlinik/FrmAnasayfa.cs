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
        public FrmVetKlinikAnaSyf()
        {
            InitializeComponent();
        }

        private void FrmVetKlinikAnaSyf_Load(object sender, EventArgs e)
        {

        }

        private void FrmVetKlinikAnaSyf_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
