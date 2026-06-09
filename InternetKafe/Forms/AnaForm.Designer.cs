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
            SuspendLayout();
            // 
            // btnMusteriler
            // 
            btnMusteriler.Location = new Point(31, 32);
            btnMusteriler.Name = "btnMusteriler";
            btnMusteriler.Size = new Size(139, 29);
            btnMusteriler.TabIndex = 0;
            btnMusteriler.Text = "Müşteri Yönetimi";
            btnMusteriler.UseVisualStyleBackColor = true;
            btnMusteriler.Click += btnMusteriler_Click;
            // 
            // lblMusteriSayisi
            // 
            lblMusteriSayisi.AutoSize = true;
            lblMusteriSayisi.Location = new Point(31, 96);
            lblMusteriSayisi.Name = "lblMusteriSayisi";
            lblMusteriSayisi.Size = new Size(114, 20);
            lblMusteriSayisi.TabIndex = 1;
            lblMusteriSayisi.Text = "Müşteri Sayısı: 0";
            // 
            // btnBilgisayarlar
            // 
            btnBilgisayarlar.Location = new Point(241, 32);
            btnBilgisayarlar.Name = "btnBilgisayarlar";
            btnBilgisayarlar.Size = new Size(182, 29);
            btnBilgisayarlar.TabIndex = 2;
            btnBilgisayarlar.Text = "Bilgisayar Yönetimi";
            btnBilgisayarlar.UseVisualStyleBackColor = true;
            btnBilgisayarlar.Click += btnBilgisayarlar_Click;
            // 
            // lblToplamPC
            // 
            lblToplamPC.AutoSize = true;
            lblToplamPC.Location = new Point(261, 73);
            lblToplamPC.Name = "lblToplamPC";
            lblToplamPC.Size = new Size(95, 20);
            lblToplamPC.TabIndex = 3;
            lblToplamPC.Text = "Toplam PC: 0";
            // 
            // lblBosPC
            // 
            lblBosPC.AutoSize = true;
            lblBosPC.Location = new Point(261, 105);
            lblBosPC.Name = "lblBosPC";
            lblBosPC.Size = new Size(69, 20);
            lblBosPC.TabIndex = 4;
            lblBosPC.Text = "Boş PC: 0";
            // 
            // btnOturumlar
            // 
            btnOturumlar.Location = new Point(489, 38);
            btnOturumlar.Name = "btnOturumlar";
            btnOturumlar.Size = new Size(147, 29);
            btnOturumlar.TabIndex = 5;
            btnOturumlar.Text = "Oturum Yönetimi";
            btnOturumlar.UseVisualStyleBackColor = true;
            btnOturumlar.Click += btnOturumlar_Click;
            // 
            // lblAktifOturum
            // 
            lblAktifOturum.AutoSize = true;
            lblAktifOturum.Location = new Point(498, 78);
            lblAktifOturum.Name = "lblAktifOturum";
            lblAktifOturum.Size = new Size(109, 20);
            lblAktifOturum.TabIndex = 6;
            lblAktifOturum.Text = "Aktif Oturum: 0";
            // 
            // lblBugunkuGelir
            // 
            lblBugunkuGelir.AutoSize = true;
            lblBugunkuGelir.Location = new Point(493, 106);
            lblBugunkuGelir.Name = "lblBugunkuGelir";
            lblBugunkuGelir.Size = new Size(143, 20);
            lblBugunkuGelir.TabIndex = 7;
            lblBugunkuGelir.Text = "Bugünkü Gelir: ₺0,00";
            // 
            // btnToptancilar
            // 
            btnToptancilar.Location = new Point(31, 187);
            btnToptancilar.Name = "btnToptancilar";
            btnToptancilar.Size = new Size(139, 29);
            btnToptancilar.TabIndex = 8;
            btnToptancilar.Text = "Toptancı Yönetimi";
            btnToptancilar.UseVisualStyleBackColor = true;
            btnToptancilar.Click += btnToptancilar_Click;
            // 
            // btnIkramlar
            // 
            btnIkramlar.Location = new Point(241, 187);
            btnIkramlar.Name = "btnIkramlar";
            btnIkramlar.Size = new Size(182, 29);
            btnIkramlar.TabIndex = 9;
            btnIkramlar.Text = "İkram ve Stok Yönetimi";
            btnIkramlar.UseVisualStyleBackColor = true;
            btnIkramlar.Click += btnIkramlar_Click;
            // 
            // btnKasaRapor
            // 
            btnKasaRapor.Location = new Point(489, 187);
            btnKasaRapor.Name = "btnKasaRapor";
            btnKasaRapor.Size = new Size(147, 29);
            btnKasaRapor.TabIndex = 10;
            btnKasaRapor.Text = "Kasa ve Raporlar";
            btnKasaRapor.UseVisualStyleBackColor = true;
            btnKasaRapor.Click += btnKasaRapor_Click;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKasaRapor);
            Controls.Add(btnIkramlar);
            Controls.Add(btnToptancilar);
            Controls.Add(lblBugunkuGelir);
            Controls.Add(lblAktifOturum);
            Controls.Add(btnOturumlar);
            Controls.Add(lblBosPC);
            Controls.Add(lblToplamPC);
            Controls.Add(btnBilgisayarlar);
            Controls.Add(lblMusteriSayisi);
            Controls.Add(btnMusteriler);
            Name = "AnaForm";
            Text = "AnaForm";
            FormClosing += AnaForm_FormClosing;
            Load += AnaForm_Load;
            ResumeLayout(false);
            PerformLayout();
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
    }
}