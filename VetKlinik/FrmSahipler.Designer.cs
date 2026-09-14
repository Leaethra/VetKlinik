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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgvSahipler = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSahipler)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(182, 110);
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
            this.lblSahipler.Location = new System.Drawing.Point(187, 9);
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
            this.btnSahipSil.Location = new System.Drawing.Point(182, 308);
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
            this.btnSahipGuncelle.Location = new System.Drawing.Point(331, 308);
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
            this.btnSahipEkle.Location = new System.Drawing.Point(481, 308);
            this.btnSahipEkle.Name = "btnSahipEkle";
            this.btnSahipEkle.Size = new System.Drawing.Size(134, 35);
            this.btnSahipEkle.TabIndex = 28;
            this.btnSahipEkle.Text = "Ekle";
            this.btnSahipEkle.UseVisualStyleBackColor = true;
            this.btnSahipEkle.Click += new System.EventHandler(this.btnSahipEkle_Click);
            // 
            // dgvSahipler
            // 
            this.dgvSahipler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvSahipler.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSahipler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSahipler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSahipler.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSahipler.Location = new System.Drawing.Point(33, 366);
            this.dgvSahipler.MultiSelect = false;
            this.dgvSahipler.Name = "dgvSahipler";
            this.dgvSahipler.ReadOnly = true;
            this.dgvSahipler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSahipler.Size = new System.Drawing.Size(735, 290);
            this.dgvSahipler.TabIndex = 27;
            this.dgvSahipler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSahipler_CellClick);
            // 
            // FrmSahipler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 706);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSahipler);
            this.Controls.Add(this.btnSahipSil);
            this.Controls.Add(this.btnSahipGuncelle);
            this.Controls.Add(this.btnSahipEkle);
            this.Controls.Add(this.dgvSahipler);
            this.Controls.Add(this.lblHastaKayitlari);
            this.Name = "FrmSahipler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sahip Kayıtları";
            this.Load += new System.EventHandler(this.FrmSahipler_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSahipler)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvSahipler;
    }
}