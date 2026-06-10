namespace InternetKafe
{
    partial class BilgisayarYonetimForm
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
            txtNumara = new TextBox();
            cmbRamGB = new ComboBox();
            cmbIslemci = new ComboBox();
            cmbEkranKarti = new ComboBox();
            lblPerformansPuani = new Label();
            lblKategori = new Label();
            lblSaatlikUcret = new Label();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            dgvBilgisayarlar = new DataGridView();
            lblNumara = new Label();
            lblRam = new Label();
            lblIslemciSec = new Label();
            lblEkranKartiSec = new Label();
            lblBilgisayarTanim = new Label();
            colNumara = new DataGridViewTextBoxColumn();
            colRam = new DataGridViewTextBoxColumn();
            colIslemci = new DataGridViewTextBoxColumn();
            colEkranKarti = new DataGridViewTextBoxColumn();
            colPerformans = new DataGridViewTextBoxColumn();
            colKategori = new DataGridViewTextBoxColumn();
            colSaatlikUcret = new DataGridViewTextBoxColumn();
            colDurum = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvBilgisayarlar).BeginInit();
            SuspendLayout();
            // 
            // txtNumara
            // 
            txtNumara.Location = new Point(32, 82);
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(150, 27);
            txtNumara.TabIndex = 0;
            // 
            // cmbRamGB
            // 
            cmbRamGB.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRamGB.FormattingEnabled = true;
            cmbRamGB.Items.AddRange(new object[] { "4", "8", "16", "32", "64" });
            cmbRamGB.Location = new Point(202, 82);
            cmbRamGB.Name = "cmbRamGB";
            cmbRamGB.Size = new Size(151, 28);
            cmbRamGB.TabIndex = 1;
            cmbRamGB.SelectedIndexChanged += cmbRamGB_SelectedIndexChanged;
            // 
            // cmbIslemci
            // 
            cmbIslemci.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIslemci.FormattingEnabled = true;
            cmbIslemci.Items.AddRange(new object[] { "Düşük", "Orta", "Yüksek", "Çok Yüksek" });
            cmbIslemci.Location = new Point(372, 82);
            cmbIslemci.Name = "cmbIslemci";
            cmbIslemci.Size = new Size(151, 28);
            cmbIslemci.TabIndex = 2;
            cmbIslemci.SelectedIndexChanged += cmbIslemci_SelectedIndexChanged;
            // 
            // cmbEkranKarti
            // 
            cmbEkranKarti.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEkranKarti.FormattingEnabled = true;
            cmbEkranKarti.Items.AddRange(new object[] { "Düşük", "Orta", "Yüksek", "Çok Yüksek" });
            cmbEkranKarti.Location = new Point(542, 82);
            cmbEkranKarti.Name = "cmbEkranKarti";
            cmbEkranKarti.Size = new Size(151, 28);
            cmbEkranKarti.TabIndex = 3;
            cmbEkranKarti.SelectedIndexChanged += cmbEkranKarti_SelectedIndexChanged;
            // 
            // lblPerformansPuani
            // 
            lblPerformansPuani.AutoSize = true;
            lblPerformansPuani.Location = new Point(32, 130);
            lblPerformansPuani.Name = "lblPerformansPuani";
            lblPerformansPuani.Size = new Size(96, 20);
            lblPerformansPuani.TabIndex = 4;
            lblPerformansPuani.Text = "Performans: -";
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(202, 130);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(79, 20);
            lblKategori.TabIndex = 5;
            lblKategori.Text = "Kategori: -";
            // 
            // lblSaatlikUcret
            // 
            lblSaatlikUcret.AutoSize = true;
            lblSaatlikUcret.Location = new Point(372, 130);
            lblSaatlikUcret.Name = "lblSaatlikUcret";
            lblSaatlikUcret.Size = new Size(57, 20);
            lblSaatlikUcret.TabIndex = 6;
            lblSaatlikUcret.Text = "Ücret: -";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(732, 80);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(130, 31);
            btnEkle.TabIndex = 7;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(732, 126);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(130, 31);
            btnGuncelle.TabIndex = 8;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(732, 172);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(130, 31);
            btnSil.TabIndex = 9;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // dgvBilgisayarlar
            // 
            dgvBilgisayarlar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBilgisayarlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBilgisayarlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBilgisayarlar.Columns.AddRange(new DataGridViewColumn[] { colNumara, colRam, colIslemci, colEkranKarti, colPerformans, colKategori, colSaatlikUcret, colDurum });
            dgvBilgisayarlar.Location = new Point(32, 235);
            dgvBilgisayarlar.Name = "dgvBilgisayarlar";
            dgvBilgisayarlar.RowHeadersWidth = 51;
            dgvBilgisayarlar.Size = new Size(850, 330);
            dgvBilgisayarlar.TabIndex = 10;
            // 
            // lblNumara
            // 
            lblNumara.AutoSize = true;
            lblNumara.Location = new Point(32, 59);
            lblNumara.Name = "lblNumara";
            lblNumara.Size = new Size(63, 20);
            lblNumara.TabIndex = 11;
            lblNumara.Text = "PC No";
            // 
            // lblRam
            // 
            lblRam.AutoSize = true;
            lblRam.Location = new Point(202, 59);
            lblRam.Name = "lblRam";
            lblRam.Size = new Size(41, 20);
            lblRam.TabIndex = 12;
            lblRam.Text = "RAM";
            // 
            // lblIslemciSec
            // 
            lblIslemciSec.AutoSize = true;
            lblIslemciSec.Location = new Point(372, 59);
            lblIslemciSec.Name = "lblIslemciSec";
            lblIslemciSec.Size = new Size(59, 20);
            lblIslemciSec.TabIndex = 13;
            lblIslemciSec.Text = "İşlemci";
            // 
            // lblEkranKartiSec
            // 
            lblEkranKartiSec.AutoSize = true;
            lblEkranKartiSec.Location = new Point(542, 59);
            lblEkranKartiSec.Name = "lblEkranKartiSec";
            lblEkranKartiSec.Size = new Size(83, 20);
            lblEkranKartiSec.TabIndex = 14;
            lblEkranKartiSec.Text = "Ekran Kartı";
            // 
            // lblBilgisayarTanim
            // 
            lblBilgisayarTanim.AutoSize = true;
            lblBilgisayarTanim.Font = new Font("Noto Sans ExtBd", 10.2F, FontStyle.Bold);
            lblBilgisayarTanim.Location = new Point(32, 25);
            lblBilgisayarTanim.Name = "lblBilgisayarTanim";
            lblBilgisayarTanim.Size = new Size(151, 24);
            lblBilgisayarTanim.TabIndex = 15;
            lblBilgisayarTanim.Text = "Bilgisayar Tanımı";
            // 
            // colNumara
            // 
            colNumara.HeaderText = "Numara";
            colNumara.MinimumWidth = 6;
            colNumara.Name = "colNumara";
            // 
            // colRam
            // 
            colRam.HeaderText = "RAM";
            colRam.MinimumWidth = 6;
            colRam.Name = "colRam";
            // 
            // colIslemci
            // 
            colIslemci.HeaderText = "İşlemci";
            colIslemci.MinimumWidth = 6;
            colIslemci.Name = "colIslemci";
            // 
            // colEkranKarti
            // 
            colEkranKarti.HeaderText = "Ekran Kartı";
            colEkranKarti.MinimumWidth = 6;
            colEkranKarti.Name = "colEkranKarti";
            // 
            // colPerformans
            // 
            colPerformans.HeaderText = "Performans";
            colPerformans.MinimumWidth = 6;
            colPerformans.Name = "colPerformans";
            // 
            // colKategori
            // 
            colKategori.HeaderText = "Kategori";
            colKategori.MinimumWidth = 6;
            colKategori.Name = "colKategori";
            // 
            // colSaatlikUcret
            // 
            colSaatlikUcret.HeaderText = "Saatlik Ücret";
            colSaatlikUcret.MinimumWidth = 6;
            colSaatlikUcret.Name = "colSaatlikUcret";
            // 
            // colDurum
            // 
            colDurum.HeaderText = "Durum";
            colDurum.MinimumWidth = 6;
            colDurum.Name = "colDurum";
            // 
            // BilgisayarYonetimForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 586);
            Controls.Add(dgvBilgisayarlar);
            Controls.Add(lblBilgisayarTanim);
            Controls.Add(lblEkranKartiSec);
            Controls.Add(lblIslemciSec);
            Controls.Add(lblRam);
            Controls.Add(lblNumara);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(lblSaatlikUcret);
            Controls.Add(lblKategori);
            Controls.Add(lblPerformansPuani);
            Controls.Add(cmbEkranKarti);
            Controls.Add(cmbIslemci);
            Controls.Add(cmbRamGB);
            Controls.Add(txtNumara);
            Name = "BilgisayarYonetimForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "BilgisayarYonetimForm";
            Load += BilgisayarYonetimForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBilgisayarlar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumara;
        private ComboBox cmbRamGB;
        private ComboBox cmbIslemci;
        private ComboBox cmbEkranKarti;
        private Label lblPerformansPuani;
        private Label lblKategori;
        private Label lblSaatlikUcret;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private DataGridView dgvBilgisayarlar;
        private Label lblNumara;
        private Label lblRam;
        private Label lblIslemciSec;
        private Label lblEkranKartiSec;
        private Label lblBilgisayarTanim;
        private DataGridViewTextBoxColumn colNumara;
        private DataGridViewTextBoxColumn colRam;
        private DataGridViewTextBoxColumn colIslemci;
        private DataGridViewTextBoxColumn colEkranKarti;
        private DataGridViewTextBoxColumn colPerformans;
        private DataGridViewTextBoxColumn colKategori;
        private DataGridViewTextBoxColumn colSaatlikUcret;
        private DataGridViewTextBoxColumn colDurum;
    }
}
