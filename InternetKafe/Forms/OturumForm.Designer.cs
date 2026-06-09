namespace InternetKafe
{
    partial class OturumForm
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
            cmbMusteri = new ComboBox();
            cmbBilgisayar = new ComboBox();
            btnOturumBaslat = new Button();
            lstAktifOturumlar = new ListBox();
            numDakika = new NumericUpDown();
            lblMusteriAdi = new Label();
            lblPCNo = new Label();
            lblBaslangic = new Label();
            lblBilgisayarUcreti = new Label();
            lblIndirim = new Label();
            lblIkramTutari = new Label();
            lblToplamTutar = new Label();
            btnOturumBitir = new Button();
            cmbIkram = new ComboBox();
            numIkramAdet = new NumericUpDown();
            btnIkramSat = new Button();
            ((System.ComponentModel.ISupportInitialize)numDakika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIkramAdet).BeginInit();
            SuspendLayout();
            // 
            // cmbMusteri
            // 
            cmbMusteri.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMusteri.FormattingEnabled = true;
            cmbMusteri.Location = new Point(12, 12);
            cmbMusteri.Name = "cmbMusteri";
            cmbMusteri.Size = new Size(151, 28);
            cmbMusteri.TabIndex = 0;
            // 
            // cmbBilgisayar
            // 
            cmbBilgisayar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBilgisayar.FormattingEnabled = true;
            cmbBilgisayar.Location = new Point(12, 52);
            cmbBilgisayar.Name = "cmbBilgisayar";
            cmbBilgisayar.Size = new Size(151, 28);
            cmbBilgisayar.TabIndex = 1;
            // 
            // btnOturumBaslat
            // 
            btnOturumBaslat.Location = new Point(12, 98);
            btnOturumBaslat.Name = "btnOturumBaslat";
            btnOturumBaslat.Size = new Size(156, 29);
            btnOturumBaslat.TabIndex = 2;
            btnOturumBaslat.Text = "Oturum Başlat";
            btnOturumBaslat.UseVisualStyleBackColor = true;
            btnOturumBaslat.Click += btnOturumBaslat_Click;
            // 
            // lstAktifOturumlar
            // 
            lstAktifOturumlar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstAktifOturumlar.FormattingEnabled = true;
            lstAktifOturumlar.Location = new Point(212, 31);
            lstAktifOturumlar.Name = "lstAktifOturumlar";
            lstAktifOturumlar.Size = new Size(414, 224);
            lstAktifOturumlar.TabIndex = 3;
            lstAktifOturumlar.SelectedIndexChanged += lstAktifOturumlar_SelectedIndexChanged;
            // 
            // numDakika
            // 
            numDakika.Location = new Point(212, 276);
            numDakika.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
            numDakika.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDakika.Name = "numDakika";
            numDakika.Size = new Size(150, 27);
            numDakika.TabIndex = 4;
            numDakika.Value = new decimal(new int[] { 60, 0, 0, 0 });
            numDakika.ValueChanged += numDakika_ValueChanged;
            // 
            // lblMusteriAdi
            // 
            lblMusteriAdi.AutoSize = true;
            lblMusteriAdi.Location = new Point(732, 42);
            lblMusteriAdi.Name = "lblMusteriAdi";
            lblMusteriAdi.Size = new Size(71, 20);
            lblMusteriAdi.TabIndex = 5;
            lblMusteriAdi.Text = "Müşteri: -";
            // 
            // lblPCNo
            // 
            lblPCNo.AutoSize = true;
            lblPCNo.Location = new Point(732, 75);
            lblPCNo.Name = "lblPCNo";
            lblPCNo.Size = new Size(39, 20);
            lblPCNo.TabIndex = 6;
            lblPCNo.Text = "PC: -";
            // 
            // lblBaslangic
            // 
            lblBaslangic.AutoSize = true;
            lblBaslangic.Location = new Point(718, 107);
            lblBaslangic.Name = "lblBaslangic";
            lblBaslangic.Size = new Size(85, 20);
            lblBaslangic.TabIndex = 7;
            lblBaslangic.Text = "Başlangıç: -";
            // 
            // lblBilgisayarUcreti
            // 
            lblBilgisayarUcreti.AutoSize = true;
            lblBilgisayarUcreti.Location = new Point(674, 152);
            lblBilgisayarUcreti.Name = "lblBilgisayarUcreti";
            lblBilgisayarUcreti.Size = new Size(82, 20);
            lblBilgisayarUcreti.TabIndex = 8;
            lblBilgisayarUcreti.Text = "PC Ücreti: -";
            // 
            // lblIndirim
            // 
            lblIndirim.AutoSize = true;
            lblIndirim.Location = new Point(732, 172);
            lblIndirim.Name = "lblIndirim";
            lblIndirim.Size = new Size(69, 20);
            lblIndirim.TabIndex = 9;
            lblIndirim.Text = "İndirim: -";
            // 
            // lblIkramTutari
            // 
            lblIkramTutari.AutoSize = true;
            lblIkramTutari.Location = new Point(732, 198);
            lblIkramTutari.Name = "lblIkramTutari";
            lblIkramTutari.Size = new Size(57, 20);
            lblIkramTutari.TabIndex = 15;
            lblIkramTutari.Text = "İkram: -";
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Location = new Point(693, 225);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(78, 20);
            lblToplamTutar.TabIndex = 10;
            lblToplamTutar.Text = "TOPLAM: -";
            // 
            // btnOturumBitir
            // 
            btnOturumBitir.Location = new Point(470, 276);
            btnOturumBitir.Name = "btnOturumBitir";
            btnOturumBitir.Size = new Size(156, 29);
            btnOturumBitir.TabIndex = 11;
            btnOturumBitir.Text = "Oturumu Kapat";
            btnOturumBitir.UseVisualStyleBackColor = true;
            btnOturumBitir.Click += btnOturumBitir_Click;
            // 
            // cmbIkram
            // 
            cmbIkram.FormattingEnabled = true;
            cmbIkram.Location = new Point(183, 374);
            cmbIkram.Name = "cmbIkram";
            cmbIkram.Size = new Size(151, 28);
            cmbIkram.TabIndex = 12;
            // 
            // numIkramAdet
            // 
            numIkramAdet.Location = new Point(355, 374);
            numIkramAdet.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numIkramAdet.Name = "numIkramAdet";
            numIkramAdet.Size = new Size(150, 27);
            numIkramAdet.TabIndex = 13;
            numIkramAdet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnIkramSat
            // 
            btnIkramSat.Location = new Point(511, 374);
            btnIkramSat.Name = "btnIkramSat";
            btnIkramSat.Size = new Size(191, 29);
            btnIkramSat.TabIndex = 14;
            btnIkramSat.Text = "Masa Siparişi Ekle";
            btnIkramSat.UseVisualStyleBackColor = true;
            btnIkramSat.Click += btnIkramSat_Click;
            // 
            // OturumForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 586);
            Controls.Add(btnIkramSat);
            Controls.Add(numIkramAdet);
            Controls.Add(cmbIkram);
            Controls.Add(btnOturumBitir);
            Controls.Add(lblIkramTutari);
            Controls.Add(lblToplamTutar);
            Controls.Add(lblIndirim);
            Controls.Add(lblBilgisayarUcreti);
            Controls.Add(lblBaslangic);
            Controls.Add(lblPCNo);
            Controls.Add(lblMusteriAdi);
            Controls.Add(numDakika);
            Controls.Add(lstAktifOturumlar);
            Controls.Add(btnOturumBaslat);
            Controls.Add(cmbBilgisayar);
            Controls.Add(cmbMusteri);
            Name = "OturumForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "OturumForm";
            Load += OturumForm_Load;
            ((System.ComponentModel.ISupportInitialize)numDakika).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIkramAdet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMusteri;
        private ComboBox cmbBilgisayar;
        private Button btnOturumBaslat;
        private ListBox lstAktifOturumlar;
        private NumericUpDown numDakika;
        private Label lblMusteriAdi;
        private Label lblPCNo;
        private Label lblBaslangic;
        private Label lblBilgisayarUcreti;
        private Label lblIndirim;
        private Label lblIkramTutari;
        private Label lblToplamTutar;
        private Button btnOturumBitir;
        private ComboBox cmbIkram;
        private NumericUpDown numIkramAdet;
        private Button btnIkramSat;
    }
}
