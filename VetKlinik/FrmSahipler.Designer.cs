namespace VetKlinik
{
    partial class FrmSahipler
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblHastaKayitlari = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.txtSahipAdi = new System.Windows.Forms.TextBox();
            this.lblEposta = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lbSahipAdi = new System.Windows.Forms.Label();
            this.lblSahipler = new System.Windows.Forms.Label();
            this.btnSahipSil = new System.Windows.Forms.Button();
            this.btnSahipGuncelle = new System.Windows.Forms.Button();
            this.btnSahipEkle = new System.Windows.Forms.Button();
            this.dgvIslemler = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIslemler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHastaKayitlari
            // 
            this.lblHastaKayitlari.AutoSize = true;
            this.lblHastaKayitlari.Font = new System.Drawing.Font("Mongolian Baiti", 33F, System.Drawing.FontStyle.Bold);
            this.lblHastaKayitlari.Location = new System.Drawing.Point(181, -78);
            this.lblHastaKayitlari.Name = "lblHastaKayitlari";
            this.lblHastaKayitlari.Size = new System.Drawing.Size(434, 46);
            this.lblHastaKayitlari.TabIndex = 26;
            this.lblHastaKayitlari.Text = "HASTA KAYITLARI";
            this.lblHastaKayitlari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtTelefon);
            this.panel1.Controls.Add(this.txtEposta);
            this.panel1.Controls.Add(this.txtSahipAdi);
            this.panel1.Controls.Add(this.lblEposta);
            this.panel1.Controls.Add(this.lblTelefon);
            this.panel1.Controls.Add(this.lbSahipAdi);
            this.panel1.Location = new System.Drawing.Point(194, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 179);
            this.panel1.TabIndex = 32;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(236, 74);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(151, 20);
            this.txtTelefon.TabIndex = 15;
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(236, 111);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(151, 20);
            this.txtEposta.TabIndex = 12;
            // 
            // txtSahipAdi
            // 
            this.txtSahipAdi.Location = new System.Drawing.Point(236, 37);
            this.txtSahipAdi.Name = "txtSahipAdi";
            this.txtSahipAdi.Size = new System.Drawing.Size(151, 20);
            this.txtSahipAdi.TabIndex = 10;
            // 
            // lblEposta
            // 
            this.lblEposta.AutoSize = true;
            this.lblEposta.Font = new System.Drawing.Font("Sylfaen", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblEposta.Location = new System.Drawing.Point(35, 108);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(72, 22);
            this.lblEposta.TabIndex = 7;
            this.lblEposta.Text = "E-Posta";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Sylfaen", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTelefon.Location = new System.Drawing.Point(34, 71);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(73, 22);
            this.lblTelefon.TabIndex = 6;
            this.lblTelefon.Text = "Telefon";
            // 
            // lbSahipAdi
            // 
            this.lbSahipAdi.AutoSize = true;
            this.lbSahipAdi.Font = new System.Drawing.Font("Sylfaen", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbSahipAdi.Location = new System.Drawing.Point(34, 34);
            this.lbSahipAdi.Name = "lbSahipAdi";
            this.lbSahipAdi.Size = new System.Drawing.Size(86, 22);
            this.lbSahipAdi.TabIndex = 5;
            this.lbSahipAdi.Text = "Ad Soyad";
            // 
            // lblSahipler
            // 
            this.lblSahipler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSahipler.AutoSize = true;
            this.lblSahipler.Font = new System.Drawing.Font("Gabriola", 48F, System.Drawing.FontStyle.Bold);
            this.lblSahipler.Location = new System.Drawing.Point(199, -14);
            this.lblSahipler.Name = "lblSahipler";
            this.lblSahipler.Size = new System.Drawing.Size(425, 118);
            this.lblSahipler.TabIndex = 31;
            this.lblSahipler.Text = "SAHİP KAYITLARI";
            this.lblSahipler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSahipSil
            // 
            this.btnSahipSil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSahipSil.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.btnSahipSil.Location = new System.Drawing.Point(194, 285);
            this.btnSahipSil.Name = "btnSahipSil";
            this.btnSahipSil.Size = new System.Drawing.Size(134, 35);
            this.btnSahipSil.TabIndex = 30;
            this.btnSahipSil.Text = "Sil";
            this.btnSahipSil.UseVisualStyleBackColor = true;
            this.btnSahipSil.Click += new System.EventHandler(this.btnSahipSil_Click);
            // 
            // btnSahipGuncelle
            // 
            this.btnSahipGuncelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSahipGuncelle.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.btnSahipGuncelle.Location = new System.Drawing.Point(343, 285);
            this.btnSahipGuncelle.Name = "btnSahipGuncelle";
            this.btnSahipGuncelle.Size = new System.Drawing.Size(134, 35);
            this.btnSahipGuncelle.TabIndex = 29;
            this.btnSahipGuncelle.Text = "Güncelle";
            this.btnSahipGuncelle.UseVisualStyleBackColor = true;
            this.btnSahipGuncelle.Click += new System.EventHandler(this.btnSahipGuncelle_Click);
            // 
            // btnSahipEkle
            // 
            this.btnSahipEkle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSahipEkle.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.btnSahipEkle.Location = new System.Drawing.Point(493, 285);
            this.btnSahipEkle.Name = "btnSahipEkle";
            this.btnSahipEkle.Size = new System.Drawing.Size(134, 35);
            this.btnSahipEkle.TabIndex = 28;
            this.btnSahipEkle.Text = "Ekle";
            this.btnSahipEkle.UseVisualStyleBackColor = true;
            this.btnSahipEkle.Click += new System.EventHandler(this.btnSahipEkle_Click);
            // 
            // dgvIslemler
            // 
            this.dgvIslemler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvIslemler.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIslemler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIslemler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIslemler.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIslemler.Location = new System.Drawing.Point(45, 343);
            this.dgvIslemler.MultiSelect = false;
            this.dgvIslemler.Name = "dgvIslemler";
            this.dgvIslemler.ReadOnly = true;
            this.dgvIslemler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIslemler.Size = new System.Drawing.Size(735, 290);
            this.dgvIslemler.TabIndex = 27;
            this.dgvIslemler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSahipler_CellClick);
            // 
            // FrmSahipler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(824, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSahipler);
            this.Controls.Add(this.btnSahipSil);
            this.Controls.Add(this.btnSahipGuncelle);
            this.Controls.Add(this.btnSahipEkle);
            this.Controls.Add(this.dgvIslemler);
            this.Controls.Add(this.lblHastaKayitlari);
            this.Name = "FrmSahipler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sahip Kayıtları";
            this.Load += new System.EventHandler(this.FrmSahipler_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIslemler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHastaKayitlari;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.TextBox txtSahipAdi;
        private System.Windows.Forms.Label lblEposta;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lbSahipAdi;
        private System.Windows.Forms.Label lblSahipler;
        private System.Windows.Forms.Button btnSahipSil;
        private System.Windows.Forms.Button btnSahipGuncelle;
        private System.Windows.Forms.Button btnSahipEkle;
        private System.Windows.Forms.DataGridView dgvIslemler;
    }
}