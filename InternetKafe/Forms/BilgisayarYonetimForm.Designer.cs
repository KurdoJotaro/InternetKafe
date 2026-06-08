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
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtNumara
            // 
            txtNumara.Location = new Point(120, 46);
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(125, 27);
            txtNumara.TabIndex = 0;
            // 
            // cmbRamGB
            // 
            cmbRamGB.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRamGB.FormattingEnabled = true;
            cmbRamGB.Items.AddRange(new object[] { "4", "8", "16", "32", "64" });
            cmbRamGB.Location = new Point(120, 99);
            cmbRamGB.Name = "cmbRamGB";
            cmbRamGB.Size = new Size(151, 28);
            cmbRamGB.TabIndex = 1;
            // 
            // cmbIslemci
            // 
            cmbIslemci.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIslemci.FormattingEnabled = true;
            cmbIslemci.Items.AddRange(new object[] { "Düşük", "Orta", "Yüksek", "Çok Yüksek" });
            cmbIslemci.Location = new Point(120, 138);
            cmbIslemci.Name = "cmbIslemci";
            cmbIslemci.Size = new Size(151, 28);
            cmbIslemci.TabIndex = 2;
            // 
            // cmbEkranKarti
            // 
            cmbEkranKarti.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEkranKarti.FormattingEnabled = true;
            cmbEkranKarti.Items.AddRange(new object[] { "Düşük", "Orta", "Yüksek", "Çok Yüksek" });
            cmbEkranKarti.Location = new Point(120, 172);
            cmbEkranKarti.Name = "cmbEkranKarti";
            cmbEkranKarti.Size = new Size(151, 28);
            cmbEkranKarti.TabIndex = 3;
            // 
            // lblPerformansPuani
            // 
            lblPerformansPuani.AutoSize = true;
            lblPerformansPuani.Location = new Point(303, 99);
            lblPerformansPuani.Name = "lblPerformansPuani";
            lblPerformansPuani.Size = new Size(96, 20);
            lblPerformansPuani.TabIndex = 4;
            lblPerformansPuani.Text = "Performans: -";
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(303, 138);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(79, 20);
            lblKategori.TabIndex = 5;
            lblKategori.Text = "Kategori: -";
            // 
            // lblSaatlikUcret
            // 
            lblSaatlikUcret.AutoSize = true;
            lblSaatlikUcret.Location = new Point(303, 199);
            lblSaatlikUcret.Name = "lblSaatlikUcret";
            lblSaatlikUcret.Size = new Size(57, 20);
            lblSaatlikUcret.TabIndex = 6;
            lblSaatlikUcret.Text = "Ücret: -";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(416, 95);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 7;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(416, 138);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 8;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(406, 195);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 9;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(185, 328);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 10;
            // 
            // BilgisayarYonetimForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
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
            Text = "BilgisayarYonetimForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
    }
}