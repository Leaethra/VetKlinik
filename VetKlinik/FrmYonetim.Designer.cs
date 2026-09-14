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
            this.btnKullaniciEkle = new System.Windows.Forms.Button();
            this.txtYeniKullanici = new System.Windows.Forms.TextBox();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.dgvKullanicilar = new System.Windows.Forms.DataGridView();
            this.lblkullaniciAdi = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblYetki = new System.Windows.Forms.Label();
            this.cmbYetki = new System.Windows.Forms.ComboBox();
            this.lblYonetim = new System.Windows.Forms.Label();
            this.btnKullaniciGuncelle = new System.Windows.Forms.Button();
            this.btnKullaniciSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKullaniciEkle
            // 
            this.btnKullaniciEkle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKullaniciEkle.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.btnKullaniciEkle.Location = new System.Drawing.Point(82, 282);
            this.btnKullaniciEkle.Name = "btnKullaniciEkle";
            this.btnKullaniciEkle.Size = new System.Drawing.Size(117, 30);
            this.btnKullaniciEkle.TabIndex = 0;
            this.btnKullaniciEkle.Text = "Ekle";
            this.btnKullaniciEkle.UseVisualStyleBackColor = true;
            this.btnKullaniciEkle.Click += new System.EventHandler(this.btnKullaniciEkle_Click);
            // 
            // txtYeniKullanici
            // 
            this.txtYeniKullanici.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtYeniKullanici.Location = new System.Drawing.Point(306, 138);
            this.txtYeniKullanici.Name = "txtYeniKullanici";
            this.txtYeniKullanici.Size = new System.Drawing.Size(117, 20);
            this.txtYeniKullanici.TabIndex = 1;
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtYeniSifre.Location = new System.Drawing.Point(306, 176);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(117, 20);
            this.txtYeniSifre.TabIndex = 2;
            // 
            // dgvKullanicilar
            // 
            this.dgvKullanicilar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvKullanicilar.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullanicilar.Location = new System.Drawing.Point(57, 336);
            this.dgvKullanicilar.Name = "dgvKullanicilar";
            this.dgvKullanicilar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKullanicilar.Size = new System.Drawing.Size(441, 198);
            this.dgvKullanicilar.TabIndex = 3;
            this.dgvKullanicilar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKullanicilar_CellClick);
            // 
            // lblkullaniciAdi
            // 
            this.lblkullaniciAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblkullaniciAdi.AutoSize = true;
            this.lblkullaniciAdi.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkullaniciAdi.Location = new System.Drawing.Point(131, 139);
            this.lblkullaniciAdi.Name = "lblkullaniciAdi";
            this.lblkullaniciAdi.Size = new System.Drawing.Size(105, 18);
            this.lblkullaniciAdi.TabIndex = 4;
            this.lblkullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // lblSifre
            // 
            this.lblSifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblSifre.Location = new System.Drawing.Point(131, 175);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(46, 18);
            this.lblSifre.TabIndex = 5;
            this.lblSifre.Text = "Şifre";
            // 
            // lblYetki
            // 
            this.lblYetki.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYetki.AutoSize = true;
            this.lblYetki.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblYetki.Location = new System.Drawing.Point(131, 212);
            this.lblYetki.Name = "lblYetki";
            this.lblYetki.Size = new System.Drawing.Size(50, 18);
            this.lblYetki.TabIndex = 6;
            this.lblYetki.Text = "Yetki";
            // 
            // cmbYetki
            // 
            this.cmbYetki.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbYetki.FormattingEnabled = true;
            this.cmbYetki.Location = new System.Drawing.Point(306, 213);
            this.cmbYetki.Name = "cmbYetki";
            this.cmbYetki.Size = new System.Drawing.Size(117, 21);
            this.cmbYetki.TabIndex = 7;
            // 
            // lblYonetim
            // 
            this.lblYonetim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYonetim.AutoSize = true;
            this.lblYonetim.Font = new System.Drawing.Font("Gabriola", 34F, System.Drawing.FontStyle.Bold);
            this.lblYonetim.Location = new System.Drawing.Point(83, 29);
            this.lblYonetim.Name = "lblYonetim";
            this.lblYonetim.Size = new System.Drawing.Size(380, 85);
            this.lblYonetim.TabIndex = 9;
            this.lblYonetim.Text = "KULLANICI YÖNETİM";
            this.lblYonetim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKullaniciGuncelle
            // 
            this.btnKullaniciGuncelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKullaniciGuncelle.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.btnKullaniciGuncelle.Location = new System.Drawing.Point(215, 282);
            this.btnKullaniciGuncelle.Name = "btnKullaniciGuncelle";
            this.btnKullaniciGuncelle.Size = new System.Drawing.Size(117, 30);
            this.btnKullaniciGuncelle.TabIndex = 10;
            this.btnKullaniciGuncelle.Text = "Güncelle";
            this.btnKullaniciGuncelle.UseVisualStyleBackColor = true;
            this.btnKullaniciGuncelle.Click += new System.EventHandler(this.btnKullaniciGuncelle_Click);
            // 
            // btnKullaniciSil
            // 
            this.btnKullaniciSil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKullaniciSil.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.btnKullaniciSil.Location = new System.Drawing.Point(347, 282);
            this.btnKullaniciSil.Name = "btnKullaniciSil";
            this.btnKullaniciSil.Size = new System.Drawing.Size(117, 30);
            this.btnKullaniciSil.TabIndex = 11;
            this.btnKullaniciSil.Text = "Sil";
            this.btnKullaniciSil.UseVisualStyleBackColor = true;
            this.btnKullaniciSil.Click += new System.EventHandler(this.btnKullaniciSil_Click);
            // 
            // FrmYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(558, 571);
            this.Controls.Add(this.btnKullaniciSil);
            this.Controls.Add(this.btnKullaniciGuncelle);
            this.Controls.Add(this.lblYonetim);
            this.Controls.Add(this.cmbYetki);
            this.Controls.Add(this.lblYetki);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblkullaniciAdi);
            this.Controls.Add(this.dgvKullanicilar);
            this.Controls.Add(this.txtYeniSifre);
            this.Controls.Add(this.txtYeniKullanici);
            this.Controls.Add(this.btnKullaniciEkle);
            this.Name = "FrmYonetim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VetKlinik Yönetim";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmYonetim_FormClosed);
            this.Load += new System.EventHandler(this.FrmYonetim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKullaniciEkle;
        private System.Windows.Forms.TextBox txtYeniKullanici;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.DataGridView dgvKullanicilar;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblkullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
     
        private System.Windows.Forms.Label lblYetki;
        private System.Windows.Forms.ComboBox cmbYetki;
        private System.Windows.Forms.Label lblYonetim;
        private System.Windows.Forms.Button btnKullaniciGuncelle;
        private System.Windows.Forms.Button btnKullaniciSil;
    }
}