namespace VetKlinik
{
    partial class FrmYonetim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnKullaniciEkle = new System.Windows.Forms.Button();
            this.txtYeniKullanici = new System.Windows.Forms.TextBox();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.dgvKullanicilar = new System.Windows.Forms.DataGridView();
            this.tblKullanicilarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblkullaniciAdi = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKullanicilarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKullaniciEkle
            // 
            this.btnKullaniciEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKullaniciEkle.Location = new System.Drawing.Point(282, 76);
            this.btnKullaniciEkle.Name = "btnKullaniciEkle";
            this.btnKullaniciEkle.Size = new System.Drawing.Size(93, 23);
            this.btnKullaniciEkle.TabIndex = 0;
            this.btnKullaniciEkle.Text = "EKLE\r\n\r\n";
            this.btnKullaniciEkle.UseVisualStyleBackColor = true;
            this.btnKullaniciEkle.Click += new System.EventHandler(this.btnKullaniciEkle_Click);
            // 
            // txtYeniKullanici
            // 
            this.txtYeniKullanici.Location = new System.Drawing.Point(29, 78);
            this.txtYeniKullanici.Name = "txtYeniKullanici";
            this.txtYeniKullanici.Size = new System.Drawing.Size(100, 20);
            this.txtYeniKullanici.TabIndex = 1;
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Location = new System.Drawing.Point(146, 78);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(100, 20);
            this.txtYeniSifre.TabIndex = 2;
            // 
            // dgvKullanicilar
            // 
            this.dgvKullanicilar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKullanicilar.AutoGenerateColumns = false;
            this.dgvKullanicilar.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullanicilar.DataSource = this.tblKullanicilarBindingSource;
            this.dgvKullanicilar.Location = new System.Drawing.Point(30, 120);
            this.dgvKullanicilar.Name = "dgvKullanicilar";
            this.dgvKullanicilar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKullanicilar.Size = new System.Drawing.Size(346, 286);
            this.dgvKullanicilar.TabIndex = 3;
            // 
            // lblkullaniciAdi
            // 
            this.lblkullaniciAdi.AutoSize = true;
            this.lblkullaniciAdi.Location = new System.Drawing.Point(29, 59);
            this.lblkullaniciAdi.Name = "lblkullaniciAdi";
            this.lblkullaniciAdi.Size = new System.Drawing.Size(88, 13);
            this.lblkullaniciAdi.TabIndex = 4;
            this.lblkullaniciAdi.Text = "Yeni Kullanıcı Adı";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(146, 59);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(28, 13);
            this.lblSifre.TabIndex = 5;
            this.lblSifre.Text = "Şifre";
            // 
            // FrmYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(409, 451);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblkullaniciAdi);
            this.Controls.Add(this.dgvKullanicilar);
            this.Controls.Add(this.txtYeniSifre);
            this.Controls.Add(this.txtYeniKullanici);
            this.Controls.Add(this.btnKullaniciEkle);
            this.Name = "FrmYonetim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VetKlinik Yönetim";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmYonetim_FormClosing);
            this.Load += new System.EventHandler(this.FrmYonetim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKullanicilarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKullaniciEkle;
        private System.Windows.Forms.TextBox txtYeniKullanici;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.DataGridView dgvKullanicilar;
        
        private System.Windows.Forms.BindingSource tblKullanicilarBindingSource;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblkullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
    }
}