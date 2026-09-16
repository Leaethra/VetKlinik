namespace VetKlinik
{
    partial class FrmIslemler
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.txtStokMiktari = new System.Windows.Forms.TextBox();
            this.txtIslemAdi = new System.Windows.Forms.TextBox();
            this.lblStokMiktari = new System.Windows.Forms.Label();
            this.lblBirimFiyat = new System.Windows.Forms.Label();
            this.lblIslemAdi = new System.Windows.Forms.Label();
            this.lblIslemler = new System.Windows.Forms.Label();
            this.btnIslemSil = new System.Windows.Forms.Button();
            this.btnIslemGuncelle = new System.Windows.Forms.Button();
            this.btnIslemEkle = new System.Windows.Forms.Button();
            this.dgvIslemler = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIslemler)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtBirimFiyat);
            this.panel1.Controls.Add(this.txtStokMiktari);
            this.panel1.Controls.Add(this.txtIslemAdi);
            this.panel1.Controls.Add(this.lblStokMiktari);
            this.panel1.Controls.Add(this.lblBirimFiyat);
            this.panel1.Controls.Add(this.lblIslemAdi);
            this.panel1.Location = new System.Drawing.Point(196, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 179);
            this.panel1.TabIndex = 38;
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Location = new System.Drawing.Point(236, 74);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(151, 20);
            this.txtBirimFiyat.TabIndex = 15;
            // 
            // txtStokMiktari
            // 
            this.txtStokMiktari.Location = new System.Drawing.Point(236, 111);
            this.txtStokMiktari.Name = "txtStokMiktari";
            this.txtStokMiktari.Size = new System.Drawing.Size(151, 20);
            this.txtStokMiktari.TabIndex = 12;
            // 
            // txtIslemAdi
            // 
            this.txtIslemAdi.Location = new System.Drawing.Point(236, 37);
            this.txtIslemAdi.Name = "txtIslemAdi";
            this.txtIslemAdi.Size = new System.Drawing.Size(151, 20);
            this.txtIslemAdi.TabIndex = 10;
            // 
            // lblStokMiktari
            // 
            this.lblStokMiktari.AutoSize = true;
            this.lblStokMiktari.Font = new System.Drawing.Font("Sylfaen", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblStokMiktari.Location = new System.Drawing.Point(35, 108);
            this.lblStokMiktari.Name = "lblStokMiktari";
            this.lblStokMiktari.Size = new System.Drawing.Size(113, 22);
            this.lblStokMiktari.TabIndex = 7;
            this.lblStokMiktari.Text = "Stok Miktarı";
            // 
            // lblBirimFiyat
            // 
            this.lblBirimFiyat.AutoSize = true;
            this.lblBirimFiyat.Font = new System.Drawing.Font("Sylfaen", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblBirimFiyat.Location = new System.Drawing.Point(34, 71);
            this.lblBirimFiyat.Name = "lblBirimFiyat";
            this.lblBirimFiyat.Size = new System.Drawing.Size(104, 22);
            this.lblBirimFiyat.TabIndex = 6;
            this.lblBirimFiyat.Text = "Birim Fiyat";
            // 
            // lblIslemAdi
            // 
            this.lblIslemAdi.AutoSize = true;
            this.lblIslemAdi.Font = new System.Drawing.Font("Sylfaen", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblIslemAdi.Location = new System.Drawing.Point(34, 34);
            this.lblIslemAdi.Name = "lblIslemAdi";
            this.lblIslemAdi.Size = new System.Drawing.Size(88, 22);
            this.lblIslemAdi.TabIndex = 5;
            this.lblIslemAdi.Text = "İşlem Adı";
            this.lblIslemAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIslemler
            // 
            this.lblIslemler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIslemler.AutoSize = true;
            this.lblIslemler.Font = new System.Drawing.Font("Gabriola", 48F, System.Drawing.FontStyle.Bold);
            this.lblIslemler.Location = new System.Drawing.Point(201, -16);
            this.lblIslemler.Name = "lblIslemler";
            this.lblIslemler.Size = new System.Drawing.Size(425, 118);
            this.lblIslemler.TabIndex = 37;
            this.lblIslemler.Text = "İŞLEM KAYITLARI";
            this.lblIslemler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIslemSil
            // 
            this.btnIslemSil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIslemSil.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.btnIslemSil.Location = new System.Drawing.Point(196, 283);
            this.btnIslemSil.Name = "btnIslemSil";
            this.btnIslemSil.Size = new System.Drawing.Size(134, 35);
            this.btnIslemSil.TabIndex = 36;
            this.btnIslemSil.Text = "Sil";
            this.btnIslemSil.UseVisualStyleBackColor = true;
            this.btnIslemSil.Click += new System.EventHandler(this.btnIslemSil_Click);
            // 
            // btnIslemGuncelle
            // 
            this.btnIslemGuncelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIslemGuncelle.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.btnIslemGuncelle.Location = new System.Drawing.Point(345, 283);
            this.btnIslemGuncelle.Name = "btnIslemGuncelle";
            this.btnIslemGuncelle.Size = new System.Drawing.Size(134, 35);
            this.btnIslemGuncelle.TabIndex = 35;
            this.btnIslemGuncelle.Text = "Güncelle";
            this.btnIslemGuncelle.UseVisualStyleBackColor = true;
            this.btnIslemGuncelle.Click += new System.EventHandler(this.btnIslemGuncelle_Click);
            // 
            // btnIslemEkle
            // 
            this.btnIslemEkle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIslemEkle.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.btnIslemEkle.Location = new System.Drawing.Point(495, 283);
            this.btnIslemEkle.Name = "btnIslemEkle";
            this.btnIslemEkle.Size = new System.Drawing.Size(134, 35);
            this.btnIslemEkle.TabIndex = 34;
            this.btnIslemEkle.Text = "Ekle";
            this.btnIslemEkle.UseVisualStyleBackColor = true;
            this.btnIslemEkle.Click += new System.EventHandler(this.btnIslemEkle_Click);
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
            this.dgvIslemler.Location = new System.Drawing.Point(47, 341);
            this.dgvIslemler.MultiSelect = false;
            this.dgvIslemler.Name = "dgvIslemler";
            this.dgvIslemler.ReadOnly = true;
            this.dgvIslemler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIslemler.Size = new System.Drawing.Size(735, 290);
            this.dgvIslemler.TabIndex = 33;
            this.dgvIslemler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIslemler_CellClick);
            // 
            // FrmIslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(824, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblIslemler);
            this.Controls.Add(this.btnIslemSil);
            this.Controls.Add(this.btnIslemGuncelle);
            this.Controls.Add(this.btnIslemEkle);
            this.Controls.Add(this.dgvIslemler);
            this.Name = "FrmIslemler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İşlem Kayıtarı";
            this.Load += new System.EventHandler(this.FrmIslemler_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIslemler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.TextBox txtStokMiktari;
        private System.Windows.Forms.TextBox txtIslemAdi;
        private System.Windows.Forms.Label lblStokMiktari;
        private System.Windows.Forms.Label lblBirimFiyat;
        private System.Windows.Forms.Label lblIslemAdi;
        private System.Windows.Forms.Label lblIslemler;
        private System.Windows.Forms.Button btnIslemSil;
        private System.Windows.Forms.Button btnIslemGuncelle;
        private System.Windows.Forms.Button btnIslemEkle;
        private System.Windows.Forms.DataGridView dgvIslemler;
    }
}