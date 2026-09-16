namespace VetKlinik
{
    partial class FrmMuayeneKayitlari
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.lblUcret = new System.Windows.Forms.Label();
            this.clbIslemler = new System.Windows.Forms.CheckedListBox();
            this.lblIslemler = new System.Windows.Forms.Label();
            this.dtpIslemTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbHayvan = new System.Windows.Forms.ComboBox();
            this.txtTeshisveNotlar = new System.Windows.Forms.TextBox();
            this.lblTeshisveNotlar = new System.Windows.Forms.Label();
            this.lblIslemTarihi = new System.Windows.Forms.Label();
            this.lblHayvan = new System.Windows.Forms.Label();
            this.lblMuayene = new System.Windows.Forms.Label();
            this.btnSahipSil = new System.Windows.Forms.Button();
            this.btnSahipGuncelle = new System.Windows.Forms.Button();
            this.btnSahipEkle = new System.Windows.Forms.Button();
            this.dgvMuayeneler = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuayeneler)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtUcret);
            this.panel1.Controls.Add(this.lblUcret);
            this.panel1.Controls.Add(this.clbIslemler);
            this.panel1.Controls.Add(this.lblIslemler);
            this.panel1.Controls.Add(this.dtpIslemTarihi);
            this.panel1.Controls.Add(this.cmbHayvan);
            this.panel1.Controls.Add(this.txtTeshisveNotlar);
            this.panel1.Controls.Add(this.lblTeshisveNotlar);
            this.panel1.Controls.Add(this.lblIslemTarihi);
            this.panel1.Controls.Add(this.lblHayvan);
            this.panel1.Location = new System.Drawing.Point(67, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 227);
            this.panel1.TabIndex = 38;
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(139, 188);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(170, 20);
            this.txtUcret.TabIndex = 21;
            // 
            // lblUcret
            // 
            this.lblUcret.AutoSize = true;
            this.lblUcret.Font = new System.Drawing.Font("Sylfaen", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblUcret.Location = new System.Drawing.Point(18, 185);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(56, 22);
            this.lblUcret.TabIndex = 20;
            this.lblUcret.Text = "Ücret";
            // 
            // clbIslemler
            // 
            this.clbIslemler.FormattingEnabled = true;
            this.clbIslemler.Location = new System.Drawing.Point(361, 50);
            this.clbIslemler.MultiColumn = true;
            this.clbIslemler.Name = "clbIslemler";
            this.clbIslemler.Size = new System.Drawing.Size(294, 154);
            this.clbIslemler.TabIndex = 19;
            this.clbIslemler.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbIslemler_ItemCheck);
            // 
            // lblIslemler
            // 
            this.lblIslemler.AutoSize = true;
            this.lblIslemler.Font = new System.Drawing.Font("Sylfaen", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblIslemler.Location = new System.Drawing.Point(357, 25);
            this.lblIslemler.Name = "lblIslemler";
            this.lblIslemler.Size = new System.Drawing.Size(145, 22);
            this.lblIslemler.TabIndex = 18;
            this.lblIslemler.Text = "Yapılan İşlemler";
            // 
            // dtpIslemTarihi
            // 
            this.dtpIslemTarihi.Location = new System.Drawing.Point(139, 64);
            this.dtpIslemTarihi.Name = "dtpIslemTarihi";
            this.dtpIslemTarihi.Size = new System.Drawing.Size(169, 20);
            this.dtpIslemTarihi.TabIndex = 17;
            // 
            // cmbHayvan
            // 
            this.cmbHayvan.FormattingEnabled = true;
            this.cmbHayvan.Location = new System.Drawing.Point(139, 28);
            this.cmbHayvan.Name = "cmbHayvan";
            this.cmbHayvan.Size = new System.Drawing.Size(169, 21);
            this.cmbHayvan.TabIndex = 16;
            // 
            // txtTeshisveNotlar
            // 
            this.txtTeshisveNotlar.Location = new System.Drawing.Point(139, 100);
            this.txtTeshisveNotlar.Multiline = true;
            this.txtTeshisveNotlar.Name = "txtTeshisveNotlar";
            this.txtTeshisveNotlar.Size = new System.Drawing.Size(169, 79);
            this.txtTeshisveNotlar.TabIndex = 12;
            // 
            // lblTeshisveNotlar
            // 
            this.lblTeshisveNotlar.AutoSize = true;
            this.lblTeshisveNotlar.Font = new System.Drawing.Font("Sylfaen", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTeshisveNotlar.Location = new System.Drawing.Point(18, 97);
            this.lblTeshisveNotlar.Name = "lblTeshisveNotlar";
            this.lblTeshisveNotlar.Size = new System.Drawing.Size(98, 22);
            this.lblTeshisveNotlar.TabIndex = 7;
            this.lblTeshisveNotlar.Text = "Teşhis/Not";
            // 
            // lblIslemTarihi
            // 
            this.lblIslemTarihi.AutoSize = true;
            this.lblIslemTarihi.Font = new System.Drawing.Font("Sylfaen", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblIslemTarihi.Location = new System.Drawing.Point(18, 62);
            this.lblIslemTarihi.Name = "lblIslemTarihi";
            this.lblIslemTarihi.Size = new System.Drawing.Size(111, 22);
            this.lblIslemTarihi.TabIndex = 6;
            this.lblIslemTarihi.Text = "İşlem Tarihi";
            // 
            // lblHayvan
            // 
            this.lblHayvan.AutoSize = true;
            this.lblHayvan.Font = new System.Drawing.Font("Sylfaen", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblHayvan.Location = new System.Drawing.Point(18, 25);
            this.lblHayvan.Name = "lblHayvan";
            this.lblHayvan.Size = new System.Drawing.Size(106, 22);
            this.lblHayvan.TabIndex = 5;
            this.lblHayvan.Text = "Hayvan Adı";
            // 
            // lblMuayene
            // 
            this.lblMuayene.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMuayene.AutoSize = true;
            this.lblMuayene.Font = new System.Drawing.Font("Gabriola", 48F, System.Drawing.FontStyle.Bold);
            this.lblMuayene.Location = new System.Drawing.Point(144, -3);
            this.lblMuayene.Name = "lblMuayene";
            this.lblMuayene.Size = new System.Drawing.Size(513, 118);
            this.lblMuayene.TabIndex = 37;
            this.lblMuayene.Text = "MUAYENE KAYITLARI";
            this.lblMuayene.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSahipSil
            // 
            this.btnSahipSil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSahipSil.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.btnSahipSil.Location = new System.Drawing.Point(193, 362);
            this.btnSahipSil.Name = "btnSahipSil";
            this.btnSahipSil.Size = new System.Drawing.Size(134, 35);
            this.btnSahipSil.TabIndex = 36;
            this.btnSahipSil.Text = "Sil";
            this.btnSahipSil.UseVisualStyleBackColor = true;
            this.btnSahipSil.Click += new System.EventHandler(this.btnMuayeneSil_Click);
            // 
            // btnSahipGuncelle
            // 
            this.btnSahipGuncelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSahipGuncelle.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.btnSahipGuncelle.Location = new System.Drawing.Point(342, 362);
            this.btnSahipGuncelle.Name = "btnSahipGuncelle";
            this.btnSahipGuncelle.Size = new System.Drawing.Size(134, 35);
            this.btnSahipGuncelle.TabIndex = 35;
            this.btnSahipGuncelle.Text = "Güncelle";
            this.btnSahipGuncelle.UseVisualStyleBackColor = true;
            this.btnSahipGuncelle.Click += new System.EventHandler(this.btnMuayeneGuncelle_Click);
            // 
            // btnSahipEkle
            // 
            this.btnSahipEkle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSahipEkle.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.btnSahipEkle.Location = new System.Drawing.Point(492, 362);
            this.btnSahipEkle.Name = "btnSahipEkle";
            this.btnSahipEkle.Size = new System.Drawing.Size(134, 35);
            this.btnSahipEkle.TabIndex = 34;
            this.btnSahipEkle.Text = "Ekle";
            this.btnSahipEkle.UseVisualStyleBackColor = true;
            this.btnSahipEkle.Click += new System.EventHandler(this.btnMuayeneEkle_Click);
            // 
            // dgvMuayeneler
            // 
            this.dgvMuayeneler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMuayeneler.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMuayeneler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMuayeneler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMuayeneler.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMuayeneler.Location = new System.Drawing.Point(39, 417);
            this.dgvMuayeneler.MultiSelect = false;
            this.dgvMuayeneler.Name = "dgvMuayeneler";
            this.dgvMuayeneler.ReadOnly = true;
            this.dgvMuayeneler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMuayeneler.Size = new System.Drawing.Size(735, 290);
            this.dgvMuayeneler.TabIndex = 33;
            this.dgvMuayeneler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMuayeneler_CellClick);
            // 
            // FrmMuayeneKayitlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(824, 741);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMuayene);
            this.Controls.Add(this.btnSahipSil);
            this.Controls.Add(this.btnSahipGuncelle);
            this.Controls.Add(this.btnSahipEkle);
            this.Controls.Add(this.dgvMuayeneler);
            this.Name = "FrmMuayeneKayitlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muayene Kayıtları";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMuayeneKayitlari_FormClosed);
            this.Load += new System.EventHandler(this.FrmMuayeneKayitlari_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuayeneler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTeshisveNotlar;
        private System.Windows.Forms.Label lblTeshisveNotlar;
        private System.Windows.Forms.Label lblIslemTarihi;
        private System.Windows.Forms.Label lblHayvan;
        private System.Windows.Forms.Label lblMuayene;
        private System.Windows.Forms.Button btnSahipSil;
        private System.Windows.Forms.Button btnSahipGuncelle;
        private System.Windows.Forms.Button btnSahipEkle;
        private System.Windows.Forms.DataGridView dgvMuayeneler;
        private System.Windows.Forms.ComboBox cmbHayvan;
        private System.Windows.Forms.DateTimePicker dtpIslemTarihi;
        private System.Windows.Forms.Label lblIslemler;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.CheckedListBox clbIslemler;
    }
}