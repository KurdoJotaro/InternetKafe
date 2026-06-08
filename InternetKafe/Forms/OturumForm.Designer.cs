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
            lblToplamTutar = new Label();
            btnOturumBitir = new Button();
            ((System.ComponentModel.ISupportInitialize)numDakika).BeginInit();
            SuspendLayout();
            // 
            // cmbMusteri
            // 
            cmbMusteri.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMusteri.FormattingEnabled = true;
            cmbMusteri.Location = new Point(125, 75);
            cmbMusteri.Name = "cmbMusteri";
            cmbMusteri.Size = new Size(151, 28);
            cmbMusteri.TabIndex = 0;
            // 
            // cmbBilgisayar
            // 
            cmbBilgisayar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBilgisayar.FormattingEnabled = true;
            cmbBilgisayar.Location = new Point(136, 121);
            cmbBilgisayar.Name = "cmbBilgisayar";
            cmbBilgisayar.Size = new Size(151, 28);
            cmbBilgisayar.TabIndex = 1;
            // 
            // btnOturumBaslat
            // 
            btnOturumBaslat.Location = new Point(131, 169);
            btnOturumBaslat.Name = "btnOturumBaslat";
            btnOturumBaslat.Size = new Size(156, 29);
            btnOturumBaslat.TabIndex = 2;
            btnOturumBaslat.Text = "Oturum Başlat";
            btnOturumBaslat.UseVisualStyleBackColor = true;
            // 
            // lstAktifOturumlar
            // 
            lstAktifOturumlar.FormattingEnabled = true;
            lstAktifOturumlar.Location = new Point(162, 225);
            lstAktifOturumlar.Name = "lstAktifOturumlar";
            lstAktifOturumlar.Size = new Size(150, 104);
            lstAktifOturumlar.TabIndex = 3;
            // 
            // numDakika
            // 
            numDakika.Location = new Point(146, 348);
            numDakika.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
            numDakika.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDakika.Name = "numDakika";
            numDakika.Size = new Size(150, 27);
            numDakika.TabIndex = 4;
            numDakika.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // lblMusteriAdi
            // 
            lblMusteriAdi.AutoSize = true;
            lblMusteriAdi.Location = new Point(360, 66);
            lblMusteriAdi.Name = "lblMusteriAdi";
            lblMusteriAdi.Size = new Size(71, 20);
            lblMusteriAdi.TabIndex = 5;
            lblMusteriAdi.Text = "Müşteri: -";
            // 
            // lblPCNo
            // 
            lblPCNo.AutoSize = true;
            lblPCNo.Location = new Point(363, 99);
            lblPCNo.Name = "lblPCNo";
            lblPCNo.Size = new Size(39, 20);
            lblPCNo.TabIndex = 6;
            lblPCNo.Text = "PC: -";
            // 
            // lblBaslangic
            // 
            lblBaslangic.AutoSize = true;
            lblBaslangic.Location = new Point(371, 131);
            lblBaslangic.Name = "lblBaslangic";
            lblBaslangic.Size = new Size(85, 20);
            lblBaslangic.TabIndex = 7;
            lblBaslangic.Text = "Başlangıç: -";
            // 
            // lblBilgisayarUcreti
            // 
            lblBilgisayarUcreti.AutoSize = true;
            lblBilgisayarUcreti.Location = new Point(383, 156);
            lblBilgisayarUcreti.Name = "lblBilgisayarUcreti";
            lblBilgisayarUcreti.Size = new Size(82, 20);
            lblBilgisayarUcreti.TabIndex = 8;
            lblBilgisayarUcreti.Text = "PC Ücreti: -";
            // 
            // lblIndirim
            // 
            lblIndirim.AutoSize = true;
            lblIndirim.Location = new Point(391, 189);
            lblIndirim.Name = "lblIndirim";
            lblIndirim.Size = new Size(69, 20);
            lblIndirim.TabIndex = 9;
            lblIndirim.Text = "İndirim: -";
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Location = new Point(366, 214);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(78, 20);
            lblToplamTutar.TabIndex = 10;
            lblToplamTutar.Text = "TOPLAM: -";
            // 
            // btnOturumBitir
            // 
            btnOturumBitir.Location = new Point(360, 268);
            btnOturumBitir.Name = "btnOturumBitir";
            btnOturumBitir.Size = new Size(156, 29);
            btnOturumBitir.TabIndex = 11;
            btnOturumBitir.Text = "Oturumu Kapat";
            btnOturumBitir.UseVisualStyleBackColor = true;
            // 
            // OturumForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOturumBitir);
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
            Text = "OturumForm";
            ((System.ComponentModel.ISupportInitialize)numDakika).EndInit();
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
        private Label lblToplamTutar;
        private Button btnOturumBitir;
    }
}