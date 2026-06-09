namespace InternetKafe
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            btnMusteriler = new Button();
            lblMusteriSayisi = new Label();
            btnBilgisayarlar = new Button();
            lblToplamPC = new Label();
            lblBosPC = new Label();
            btnOturumlar = new Button();
            lblAktifOturum = new Label();
            lblBugunkuGelir = new Label();
            btnToptancilar = new Button();
            btnIkramlar = new Button();
            btnKasaRapor = new Button();
            pnlMenu = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblLogo = new Label();
            pictureBox1 = new PictureBox();
            pnlUst = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            pnlIcerik = new Panel();
            pnlMenu.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlUst.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnMusteriler
            // 
            btnMusteriler.Cursor = Cursors.Hand;
            btnMusteriler.Dock = DockStyle.Fill;
            btnMusteriler.FlatAppearance.BorderColor = Color.White;
            btnMusteriler.FlatAppearance.MouseOverBackColor = Color.SlateGray;
            btnMusteriler.FlatStyle = FlatStyle.Flat;
            btnMusteriler.Font = new Font("Noto Sans ExtBd", 10.7999992F, FontStyle.Bold);
            btnMusteriler.ForeColor = Color.White;
            btnMusteriler.Location = new Point(0, 175);
            btnMusteriler.Margin = new Padding(0);
            btnMusteriler.Name = "btnMusteriler";
            btnMusteriler.Size = new Size(250, 105);
            btnMusteriler.TabIndex = 0;
            btnMusteriler.Text = "Müşteri Yönetimi";
            btnMusteriler.UseVisualStyleBackColor = true;
            btnMusteriler.Click += btnMusteriler_Click;
            // 
            // lblMusteriSayisi
            // 
            lblMusteriSayisi.BackColor = Color.FromArgb(62, 88, 113);
            lblMusteriSayisi.Dock = DockStyle.Fill;
            lblMusteriSayisi.FlatStyle = FlatStyle.Flat;
            lblMusteriSayisi.Font = new Font("Noto Sans ExtBd", 10.2F, FontStyle.Bold);
            lblMusteriSayisi.ForeColor = SystemColors.ButtonFace;
            lblMusteriSayisi.Location = new Point(3, 0);
            lblMusteriSayisi.Name = "lblMusteriSayisi";
            lblMusteriSayisi.Size = new Size(180, 70);
            lblMusteriSayisi.TabIndex = 3;
            lblMusteriSayisi.Text = "Müşteri Sayısı: 0";
            lblMusteriSayisi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBilgisayarlar
            // 
            btnBilgisayarlar.Cursor = Cursors.Hand;
            btnBilgisayarlar.Dock = DockStyle.Fill;
            btnBilgisayarlar.FlatAppearance.BorderColor = Color.White;
            btnBilgisayarlar.FlatAppearance.MouseOverBackColor = Color.SlateGray;
            btnBilgisayarlar.FlatStyle = FlatStyle.Flat;
            btnBilgisayarlar.Font = new Font("Noto Sans ExtBd", 10.7999992F, FontStyle.Bold);
            btnBilgisayarlar.ForeColor = Color.White;
            btnBilgisayarlar.Location = new Point(0, 280);
            btnBilgisayarlar.Margin = new Padding(0);
            btnBilgisayarlar.Name = "btnBilgisayarlar";
            btnBilgisayarlar.Size = new Size(250, 105);
            btnBilgisayarlar.TabIndex = 1;
            btnBilgisayarlar.Text = "Bilgisayar Yönetimi";
            btnBilgisayarlar.UseVisualStyleBackColor = true;
            btnBilgisayarlar.Click += btnBilgisayarlar_Click;
            // 
            // lblToplamPC
            // 
            lblToplamPC.BackColor = Color.FromArgb(62, 88, 113);
            lblToplamPC.Dock = DockStyle.Fill;
            lblToplamPC.FlatStyle = FlatStyle.Flat;
            lblToplamPC.Font = new Font("Noto Sans ExtBd", 10.2F, FontStyle.Bold);
            lblToplamPC.ForeColor = SystemColors.ButtonFace;
            lblToplamPC.Location = new Point(189, 0);
            lblToplamPC.Name = "lblToplamPC";
            lblToplamPC.Size = new Size(180, 70);
            lblToplamPC.TabIndex = 4;
            lblToplamPC.Text = "Toplam PC: 0";
            lblToplamPC.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBosPC
            // 
            lblBosPC.BackColor = Color.FromArgb(62, 88, 113);
            lblBosPC.Dock = DockStyle.Fill;
            lblBosPC.FlatStyle = FlatStyle.Flat;
            lblBosPC.Font = new Font("Noto Sans ExtBd", 10.2F, FontStyle.Bold);
            lblBosPC.ForeColor = SystemColors.ButtonFace;
            lblBosPC.Location = new Point(375, 0);
            lblBosPC.Name = "lblBosPC";
            lblBosPC.Size = new Size(180, 70);
            lblBosPC.TabIndex = 7;
            lblBosPC.Text = "Boş PC: 0";
            lblBosPC.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnOturumlar
            // 
            btnOturumlar.Cursor = Cursors.Hand;
            btnOturumlar.Dock = DockStyle.Fill;
            btnOturumlar.FlatAppearance.BorderColor = Color.White;
            btnOturumlar.FlatAppearance.MouseOverBackColor = Color.SlateGray;
            btnOturumlar.FlatStyle = FlatStyle.Flat;
            btnOturumlar.Font = new Font("Noto Sans ExtBd", 10.7999992F, FontStyle.Bold);
            btnOturumlar.ForeColor = Color.White;
            btnOturumlar.Location = new Point(0, 385);
            btnOturumlar.Margin = new Padding(0);
            btnOturumlar.Name = "btnOturumlar";
            btnOturumlar.Size = new Size(250, 105);
            btnOturumlar.TabIndex = 2;
            btnOturumlar.Text = "Oturum Yönetimi";
            btnOturumlar.UseVisualStyleBackColor = true;
            btnOturumlar.Click += btnOturumlar_Click;
            // 
            // lblAktifOturum
            // 
            lblAktifOturum.BackColor = Color.FromArgb(62, 88, 113);
            lblAktifOturum.Dock = DockStyle.Fill;
            lblAktifOturum.FlatStyle = FlatStyle.Flat;
            lblAktifOturum.Font = new Font("Noto Sans ExtBd", 10.2F, FontStyle.Bold);
            lblAktifOturum.ForeColor = SystemColors.ButtonFace;
            lblAktifOturum.Location = new Point(561, 0);
            lblAktifOturum.Name = "lblAktifOturum";
            lblAktifOturum.Size = new Size(180, 70);
            lblAktifOturum.TabIndex = 5;
            lblAktifOturum.Text = "Aktif Oturum: 0";
            lblAktifOturum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBugunkuGelir
            // 
            lblBugunkuGelir.BackColor = Color.FromArgb(62, 88, 113);
            lblBugunkuGelir.Dock = DockStyle.Fill;
            lblBugunkuGelir.FlatStyle = FlatStyle.Flat;
            lblBugunkuGelir.Font = new Font("Noto Sans ExtBd", 10.2F, FontStyle.Bold);
            lblBugunkuGelir.ForeColor = SystemColors.ButtonFace;
            lblBugunkuGelir.Location = new Point(747, 0);
            lblBugunkuGelir.Name = "lblBugunkuGelir";
            lblBugunkuGelir.Size = new Size(182, 70);
            lblBugunkuGelir.TabIndex = 6;
            lblBugunkuGelir.Text = "Bugünkü Gelir: ₺0,00";
            lblBugunkuGelir.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnToptancilar
            // 
            btnToptancilar.Cursor = Cursors.Hand;
            btnToptancilar.Dock = DockStyle.Fill;
            btnToptancilar.FlatAppearance.BorderColor = Color.White;
            btnToptancilar.FlatAppearance.MouseOverBackColor = Color.SlateGray;
            btnToptancilar.FlatStyle = FlatStyle.Flat;
            btnToptancilar.Font = new Font("Noto Sans ExtBd", 10.7999992F, FontStyle.Bold);
            btnToptancilar.ForeColor = Color.White;
            btnToptancilar.Location = new Point(0, 490);
            btnToptancilar.Margin = new Padding(0);
            btnToptancilar.Name = "btnToptancilar";
            btnToptancilar.Size = new Size(250, 105);
            btnToptancilar.TabIndex = 8;
            btnToptancilar.Text = "Toptancı Yönetimi";
            btnToptancilar.UseVisualStyleBackColor = true;
            btnToptancilar.Click += btnToptancilar_Click;
            // 
            // btnIkramlar
            // 
            btnIkramlar.Cursor = Cursors.Hand;
            btnIkramlar.Dock = DockStyle.Fill;
            btnIkramlar.FlatAppearance.BorderColor = Color.White;
            btnIkramlar.FlatAppearance.MouseOverBackColor = Color.SlateGray;
            btnIkramlar.FlatStyle = FlatStyle.Flat;
            btnIkramlar.Font = new Font("Noto Sans ExtBd", 10.7999992F, FontStyle.Bold);
            btnIkramlar.ForeColor = Color.White;
            btnIkramlar.Location = new Point(0, 595);
            btnIkramlar.Margin = new Padding(0);
            btnIkramlar.Name = "btnIkramlar";
            btnIkramlar.Size = new Size(250, 108);
            btnIkramlar.TabIndex = 9;
            btnIkramlar.Text = "İkram ve Stok Yönetimi";
            btnIkramlar.UseVisualStyleBackColor = true;
            btnIkramlar.Click += btnIkramlar_Click;
            // 
            // btnKasaRapor
            // 
            btnKasaRapor.Cursor = Cursors.Hand;
            btnKasaRapor.Dock = DockStyle.Fill;
            btnKasaRapor.FlatAppearance.BorderColor = Color.White;
            btnKasaRapor.FlatAppearance.MouseOverBackColor = Color.SlateGray;
            btnKasaRapor.FlatStyle = FlatStyle.Flat;
            btnKasaRapor.Font = new Font("Noto Sans ExtBd", 10.7999992F, FontStyle.Bold);
            btnKasaRapor.ForeColor = Color.White;
            btnKasaRapor.Location = new Point(0, 70);
            btnKasaRapor.Margin = new Padding(0);
            btnKasaRapor.Name = "btnKasaRapor";
            btnKasaRapor.Size = new Size(250, 105);
            btnKasaRapor.TabIndex = 10;
            btnKasaRapor.Text = "Kasa ve Raporlar";
            btnKasaRapor.UseVisualStyleBackColor = true;
            btnKasaRapor.Click += btnKasaRapor_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(44, 62, 80);
            pnlMenu.Controls.Add(tableLayoutPanel1);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(250, 703);
            pnlMenu.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnIkramlar, 0, 6);
            tableLayoutPanel1.Controls.Add(btnToptancilar, 0, 5);
            tableLayoutPanel1.Controls.Add(btnOturumlar, 0, 4);
            tableLayoutPanel1.Controls.Add(btnBilgisayarlar, 0, 3);
            tableLayoutPanel1.Controls.Add(btnMusteriler, 0, 2);
            tableLayoutPanel1.Controls.Add(btnKasaRapor, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Size = new Size(250, 703);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel3.Controls.Add(lblLogo, 1, 0);
            tableLayoutPanel3.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(250, 70);
            tableLayoutPanel3.TabIndex = 11;
            // 
            // lblLogo
            // 
            lblLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Noto Sans ExtBd", 8.999999F, FontStyle.Bold);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(103, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(144, 70);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "Yönetim Sistemi";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pnlUst
            // 
            pnlUst.BackColor = Color.FromArgb(62, 88, 113);
            pnlUst.Controls.Add(tableLayoutPanel2);
            pnlUst.Dock = DockStyle.Top;
            pnlUst.Location = new Point(250, 0);
            pnlUst.Name = "pnlUst";
            pnlUst.Size = new Size(932, 70);
            pnlUst.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(lblBugunkuGelir, 4, 0);
            tableLayoutPanel2.Controls.Add(lblMusteriSayisi, 0, 0);
            tableLayoutPanel2.Controls.Add(lblAktifOturum, 3, 0);
            tableLayoutPanel2.Controls.Add(lblToplamPC, 1, 0);
            tableLayoutPanel2.Controls.Add(lblBosPC, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(932, 70);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // pnlIcerik
            // 
            pnlIcerik.Dock = DockStyle.Fill;
            pnlIcerik.Location = new Point(250, 70);
            pnlIcerik.Name = "pnlIcerik";
            pnlIcerik.Size = new Size(932, 633);
            pnlIcerik.TabIndex = 13;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 703);
            Controls.Add(pnlIcerik);
            Controls.Add(pnlUst);
            Controls.Add(pnlMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AnaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnaForm";
            FormClosing += AnaForm_FormClosing;
            Load += AnaForm_Load;
            pnlMenu.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlUst.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnMusteriler;
        private Label lblMusteriSayisi;
        private Button btnBilgisayarlar;
        private Label lblToplamPC;
        private Label lblBosPC;
        private Button btnOturumlar;
        private Label lblAktifOturum;
        private Label lblBugunkuGelir;
        private Button btnToptancilar;
        private Button btnIkramlar;
        private Button btnKasaRapor;
        private Panel pnlMenu;
        private Panel pnlUst;
        private Panel pnlIcerik;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblLogo;
    }
}