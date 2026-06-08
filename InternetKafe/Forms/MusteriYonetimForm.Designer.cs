namespace InternetKafe
{
    partial class MusteriYonetimForm
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
            txtAd = new TextBox();
            numYas = new NumericUpDown();
            chkUyelik = new CheckBox();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            dgvMusteriler = new DataGridView();
            colAd = new DataGridViewTextBoxColumn();
            colYas = new DataGridViewTextBoxColumn();
            colUyelik = new DataGridViewTextBoxColumn();
            colToplamHarcama = new DataGridViewTextBoxColumn();
            colIndirimOrani = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)numYas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).BeginInit();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(104, 144);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 0;
            // 
            // numYas
            // 
            numYas.Location = new Point(264, 147);
            numYas.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            numYas.Name = "numYas";
            numYas.Size = new Size(150, 27);
            numYas.TabIndex = 1;
            numYas.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // chkUyelik
            // 
            chkUyelik.AutoSize = true;
            chkUyelik.Location = new Point(435, 144);
            chkUyelik.Name = "chkUyelik";
            chkUyelik.Size = new Size(96, 24);
            chkUyelik.TabIndex = 2;
            chkUyelik.Text = "Üyelik Var";
            chkUyelik.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(559, 121);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(584, 160);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 4;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(584, 218);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 5;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // dgvMusteriler
            // 
            dgvMusteriler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMusteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMusteriler.Columns.AddRange(new DataGridViewColumn[] { colAd, colYas, colUyelik, colToplamHarcama, colIndirimOrani });
            dgvMusteriler.Location = new Point(4, 250);
            dgvMusteriler.Name = "dgvMusteriler";
            dgvMusteriler.RowHeadersWidth = 51;
            dgvMusteriler.Size = new Size(784, 188);
            dgvMusteriler.TabIndex = 6;
            // 
            // colAd
            // 
            colAd.HeaderText = "Ad";
            colAd.MinimumWidth = 6;
            colAd.Name = "colAd";
            // 
            // colYas
            // 
            colYas.HeaderText = "Yaş";
            colYas.MinimumWidth = 6;
            colYas.Name = "colYas";
            // 
            // colUyelik
            // 
            colUyelik.HeaderText = "Üyelik";
            colUyelik.MinimumWidth = 6;
            colUyelik.Name = "colUyelik";
            // 
            // colToplamHarcama
            // 
            colToplamHarcama.HeaderText = "Toplam Harcama";
            colToplamHarcama.MinimumWidth = 6;
            colToplamHarcama.Name = "colToplamHarcama";
            // 
            // colIndirimOrani
            // 
            colIndirimOrani.HeaderText = "İndirim Oranı";
            colIndirimOrani.MinimumWidth = 6;
            colIndirimOrani.Name = "colIndirimOrani";
            // 
            // MusteriYonetimForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvMusteriler);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(chkUyelik);
            Controls.Add(numYas);
            Controls.Add(txtAd);
            Name = "MusteriYonetimForm";
            Text = "MusteriYonetimForm";
            ((System.ComponentModel.ISupportInitialize)numYas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAd;
        private NumericUpDown numYas;
        private CheckBox chkUyelik;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private DataGridView dgvMusteriler;
        private DataGridViewTextBoxColumn colAd;
        private DataGridViewTextBoxColumn colYas;
        private DataGridViewTextBoxColumn colUyelik;
        private DataGridViewTextBoxColumn colToplamHarcama;
        private DataGridViewTextBoxColumn colIndirimOrani;
    }
}