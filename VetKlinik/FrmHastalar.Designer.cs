namespace VetKlinik
{
    partial class FrmHastalar
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHastalar = new System.Windows.Forms.DataGridView();
            this.lblHastaAdi = new System.Windows.Forms.Label();
            this.lblTur = new System.Windows.Forms.Label();
            this.lblCins = new System.Windows.Forms.Label();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHastaAdi = new System.Windows.Forms.TextBox();
            this.txtCins = new System.Windows.Forms.TextBox();
            this.txtHDogumTarihi = new System.Windows.Forms.TextBox();
            this.txtCipNo = new System.Windows.Forms.TextBox();
            this.txtTur = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblHastaKayitlari = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSahip = new System.Windows.Forms.Label();
            this.cmbSahip = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHastalar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHastalar
            // 
            this.dgvHastalar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHastalar.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHastalar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHastalar.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvHastalar.Location = new System.Drawing.Point(43, 375);
            this.dgvHastalar.MultiSelect = false;
            this.dgvHastalar.Name = "dgvHastalar";
            this.dgvHastalar.ReadOnly = true;
            this.dgvHastalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHastalar.Size = new System.Drawing.Size(734, 260);
            this.dgvHastalar.TabIndex = 4;
            this.dgvHastalar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHastalar_CellClick);
            // 
            // lblHastaAdi
            // 
            this.lblHastaAdi.AutoSize = true;
            this.lblHastaAdi.Font = new System.Drawing.Font("Sylfaen", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblHastaAdi.Location = new System.Drawing.Point(34, 9);
            this.lblHastaAdi.Name = "lblHastaAdi";
            this.lblHastaAdi.Size = new System.Drawing.Size(89, 22);
            this.lblHastaAdi.TabIndex = 5;
            this.lblHastaAdi.Text = "Hasta Adı";
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.Font = new System.Drawing.Font("Sylfaen", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTur.Location = new System.Drawing.Point(34, 42);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(52, 22);
            this.lblTur.TabIndex = 6;
            this.lblTur.Text = "Türü";
            // 
            // lblCins
            // 
            this.lblCins.AutoSize = true;
            this.lblCins.Font = new System.Drawing.Font("Sylfaen", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblCins.Location = new System.Drawing.Point(34, 79);
            this.lblCins.Name = "lblCins";
            this.lblCins.Size = new System.Drawing.Size(52, 22);
            this.lblCins.TabIndex = 7;
            this.lblCins.Text = "Cinsi";
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Font = new System.Drawing.Font("Sylfaen", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblDogumTarihi.Location = new System.Drawing.Point(34, 114);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(126, 22);
            this.lblDogumTarihi.TabIndex = 8;
            this.lblDogumTarihi.Text = "Doğum Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sylfaen", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(34, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Çip NO";
            // 
            // txtHastaAdi
            // 
            this.txtHastaAdi.Location = new System.Drawing.Point(236, 12);
            this.txtHastaAdi.Name = "txtHastaAdi";
            this.txtHastaAdi.Size = new System.Drawing.Size(151, 20);
            this.txtHastaAdi.TabIndex = 10;
            // 
            // txtCins
            // 
            this.txtCins.Location = new System.Drawing.Point(236, 82);
            this.txtCins.Name = "txtCins";
            this.txtCins.Size = new System.Drawing.Size(151, 20);
            this.txtCins.TabIndex = 12;
            // 
            // txtHDogumTarihi
            // 
            this.txtHDogumTarihi.Location = new System.Drawing.Point(236, 117);
            this.txtHDogumTarihi.Name = "txtHDogumTarihi";
            this.txtHDogumTarihi.Size = new System.Drawing.Size(151, 20);
            this.txtHDogumTarihi.TabIndex = 13;
            // 
            // txtCipNo
            // 
            this.txtCipNo.Location = new System.Drawing.Point(236, 155);
            this.txtCipNo.Name = "txtCipNo";
            this.txtCipNo.Size = new System.Drawing.Size(151, 20);
            this.txtCipNo.TabIndex = 14;
            // 
            // txtTur
            // 
            this.txtTur.Location = new System.Drawing.Point(236, 45);
            this.txtTur.Name = "txtTur";
            this.txtTur.Size = new System.Drawing.Size(151, 20);
            this.txtTur.TabIndex = 15;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.btnEkle.Location = new System.Drawing.Point(491, 334);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(134, 35);
            this.btnEkle.TabIndex = 16;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.btnGuncelle.Location = new System.Drawing.Point(341, 334);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(134, 35);
            this.btnGuncelle.TabIndex = 17;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.btnSil.Location = new System.Drawing.Point(192, 334);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(134, 35);
            this.btnSil.TabIndex = 18;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblHastaKayitlari
            // 
            this.lblHastaKayitlari.AutoSize = true;
            this.lblHastaKayitlari.Font = new System.Drawing.Font("Mongolian Baiti", 33F, System.Drawing.FontStyle.Bold);
            this.lblHastaKayitlari.Location = new System.Drawing.Point(191, 29);
            this.lblHastaKayitlari.Name = "lblHastaKayitlari";
            this.lblHastaKayitlari.Size = new System.Drawing.Size(434, 46);
            this.lblHastaKayitlari.TabIndex = 20;
            this.lblHastaKayitlari.Text = "HASTA KAYITLARI";
            this.lblHastaKayitlari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblSahip);
            this.panel1.Controls.Add(this.cmbSahip);
            this.panel1.Controls.Add(this.txtTur);
            this.panel1.Controls.Add(this.txtCipNo);
            this.panel1.Controls.Add(this.txtHDogumTarihi);
            this.panel1.Controls.Add(this.txtCins);
            this.panel1.Controls.Add(this.txtHastaAdi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblDogumTarihi);
            this.panel1.Controls.Add(this.lblCins);
            this.panel1.Controls.Add(this.lblTur);
            this.panel1.Controls.Add(this.lblHastaAdi);
            this.panel1.Location = new System.Drawing.Point(192, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 229);
            this.panel1.TabIndex = 21;
            // 
            // lblSahip
            // 
            this.lblSahip.AutoSize = true;
            this.lblSahip.Font = new System.Drawing.Font("Sylfaen", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblSahip.Location = new System.Drawing.Point(34, 189);
            this.lblSahip.Name = "lblSahip";
            this.lblSahip.Size = new System.Drawing.Size(61, 22);
            this.lblSahip.TabIndex = 17;
            this.lblSahip.Text = "Sahibi";
            // 
            // cmbSahip
            // 
            this.cmbSahip.FormattingEnabled = true;
            this.cmbSahip.Location = new System.Drawing.Point(236, 192);
            this.cmbSahip.Name = "cmbSahip";
            this.cmbSahip.Size = new System.Drawing.Size(151, 21);
            this.cmbSahip.TabIndex = 16;
            // 
            // FrmHastalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(824, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHastaKayitlari);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dgvHastalar);
            this.Name = "FrmHastalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Kayıtları";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmHastalar_FormClosed);
            this.Load += new System.EventHandler(this.FrmHastalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHastalar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHastalar;
        private System.Windows.Forms.Label lblHastaAdi;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.Label lblCins;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHastaAdi;
        private System.Windows.Forms.TextBox txtCins;
        private System.Windows.Forms.TextBox txtHDogumTarihi;
        private System.Windows.Forms.TextBox txtCipNo;
        private System.Windows.Forms.TextBox txtTur;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblHastaKayitlari;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSahip;
        private System.Windows.Forms.ComboBox cmbSahip;
    }
}
