namespace InternetKafe
{
    partial class IkramForm
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
            numFiyat = new NumericUpDown();
            btnEkle = new Button();
            cmbToptanci = new ComboBox();
            numAlimAdet = new NumericUpDown();
            cmbIkramAlim = new ComboBox();
            numAlimFiyati = new NumericUpDown();
            btnStokAl = new Button();
            btnSil = new Button();
            lblUrunAdi = new Label();
            lblSatisFiyati = new Label();
            lblToptanci = new Label();
            lblAlimUrun = new Label();
            lblAlimAdet = new Label();
            lblAlimFiyati = new Label();
            lblUrunTanim = new Label();
            lblStokAlimi = new Label();
            dgvIkramlar = new DataGridView();
            colAd = new DataGridViewTextBoxColumn();
            colFiyat = new DataGridViewTextBoxColumn();
            colStok = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)numFiyat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAlimAdet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAlimFiyati).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvIkramlar).BeginInit();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(32, 78);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(180, 27);
            txtAd.TabIndex = 0;
            // 
            // numFiyat
            // 
            numFiyat.DecimalPlaces = 2;
            numFiyat.Location = new Point(232, 78);
            numFiyat.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numFiyat.Name = "numFiyat";
            numFiyat.Size = new Size(150, 27);
            numFiyat.TabIndex = 1;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(402, 76);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(130, 31);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Ürün Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // cmbToptanci
            // 
            cmbToptanci.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbToptanci.FormattingEnabled = true;
            cmbToptanci.Location = new Point(32, 167);
            cmbToptanci.Name = "cmbToptanci";
            cmbToptanci.Size = new Size(180, 28);
            cmbToptanci.TabIndex = 3;
            // 
            // numAlimAdet
            // 
            numAlimAdet.Location = new Point(432, 167);
            numAlimAdet.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numAlimAdet.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numAlimAdet.Name = "numAlimAdet";
            numAlimAdet.Size = new Size(150, 27);
            numAlimAdet.TabIndex = 1;
            numAlimAdet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cmbIkramAlim
            // 
            cmbIkramAlim.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIkramAlim.FormattingEnabled = true;
            cmbIkramAlim.Location = new Point(232, 167);
            cmbIkramAlim.Name = "cmbIkramAlim";
            cmbIkramAlim.Size = new Size(180, 28);
            cmbIkramAlim.TabIndex = 3;
            // 
            // numAlimFiyati
            // 
            numAlimFiyati.DecimalPlaces = 2;
            numAlimFiyati.Location = new Point(602, 167);
            numAlimFiyati.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numAlimFiyati.Name = "numAlimFiyati";
            numAlimFiyati.Size = new Size(150, 27);
            numAlimFiyati.TabIndex = 1;
            // 
            // btnStokAl
            // 
            btnStokAl.Location = new Point(772, 165);
            btnStokAl.Name = "btnStokAl";
            btnStokAl.Size = new Size(110, 31);
            btnStokAl.TabIndex = 2;
            btnStokAl.Text = "Stok Al";
            btnStokAl.UseVisualStyleBackColor = true;
            btnStokAl.Click += btnStokAl_Click;
            // 
            // btnSil
            // 
            btnSil.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSil.Location = new Point(772, 533);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(110, 31);
            btnSil.TabIndex = 13;
            btnSil.Text = "Ürün Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // lblUrunAdi
            // 
            lblUrunAdi.AutoSize = true;
            lblUrunAdi.Location = new Point(32, 55);
            lblUrunAdi.Name = "lblUrunAdi";
            lblUrunAdi.Size = new Size(67, 20);
            lblUrunAdi.TabIndex = 5;
            lblUrunAdi.Text = "Ürün Adı";
            // 
            // lblSatisFiyati
            // 
            lblSatisFiyati.AutoSize = true;
            lblSatisFiyati.Location = new Point(232, 55);
            lblSatisFiyati.Name = "lblSatisFiyati";
            lblSatisFiyati.Size = new Size(79, 20);
            lblSatisFiyati.TabIndex = 6;
            lblSatisFiyati.Text = "Satış Fiyatı";
            // 
            // lblToptanci
            // 
            lblToptanci.AutoSize = true;
            lblToptanci.Location = new Point(32, 144);
            lblToptanci.Name = "lblToptanci";
            lblToptanci.Size = new Size(67, 20);
            lblToptanci.TabIndex = 7;
            lblToptanci.Text = "Toptancı";
            // 
            // lblAlimUrun
            // 
            lblAlimUrun.AutoSize = true;
            lblAlimUrun.Location = new Point(232, 144);
            lblAlimUrun.Name = "lblAlimUrun";
            lblAlimUrun.Size = new Size(41, 20);
            lblAlimUrun.TabIndex = 8;
            lblAlimUrun.Text = "Ürün";
            // 
            // lblAlimAdet
            // 
            lblAlimAdet.AutoSize = true;
            lblAlimAdet.Location = new Point(432, 144);
            lblAlimAdet.Name = "lblAlimAdet";
            lblAlimAdet.Size = new Size(42, 20);
            lblAlimAdet.TabIndex = 9;
            lblAlimAdet.Text = "Adet";
            // 
            // lblAlimFiyati
            // 
            lblAlimFiyati.AutoSize = true;
            lblAlimFiyati.Location = new Point(602, 144);
            lblAlimFiyati.Name = "lblAlimFiyati";
            lblAlimFiyati.Size = new Size(75, 20);
            lblAlimFiyati.TabIndex = 10;
            lblAlimFiyati.Text = "Alış Fiyatı";
            // 
            // lblUrunTanim
            // 
            lblUrunTanim.AutoSize = true;
            lblUrunTanim.Font = new Font("Noto Sans ExtBd", 10.2F, FontStyle.Bold);
            lblUrunTanim.Location = new Point(32, 25);
            lblUrunTanim.Name = "lblUrunTanim";
            lblUrunTanim.Size = new Size(104, 24);
            lblUrunTanim.TabIndex = 11;
            lblUrunTanim.Text = "Ürün Tanımı";
            // 
            // lblStokAlimi
            // 
            lblStokAlimi.AutoSize = true;
            lblStokAlimi.Font = new Font("Noto Sans ExtBd", 10.2F, FontStyle.Bold);
            lblStokAlimi.Location = new Point(32, 114);
            lblStokAlimi.Name = "lblStokAlimi";
            lblStokAlimi.Size = new Size(87, 24);
            lblStokAlimi.TabIndex = 12;
            lblStokAlimi.Text = "Stok Alımı";
            // 
            // dgvIkramlar
            // 
            dgvIkramlar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvIkramlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIkramlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIkramlar.Columns.AddRange(new DataGridViewColumn[] { colAd, colFiyat, colStok });
            dgvIkramlar.Location = new Point(32, 235);
            dgvIkramlar.Name = "dgvIkramlar";
            dgvIkramlar.RowHeadersWidth = 51;
            dgvIkramlar.Size = new Size(850, 286);
            dgvIkramlar.TabIndex = 4;
            // 
            // colAd
            // 
            colAd.HeaderText = "Ad";
            colAd.MinimumWidth = 6;
            colAd.Name = "colAd";
            // 
            // colFiyat
            // 
            colFiyat.HeaderText = "Fiyat";
            colFiyat.MinimumWidth = 6;
            colFiyat.Name = "colFiyat";
            // 
            // colStok
            // 
            colStok.HeaderText = "Stok";
            colStok.MinimumWidth = 6;
            colStok.Name = "colStok";
            // 
            // IkramForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 586);
            Controls.Add(btnSil);
            Controls.Add(lblStokAlimi);
            Controls.Add(lblUrunTanim);
            Controls.Add(lblAlimFiyati);
            Controls.Add(lblAlimAdet);
            Controls.Add(lblAlimUrun);
            Controls.Add(lblToptanci);
            Controls.Add(lblSatisFiyati);
            Controls.Add(lblUrunAdi);
            Controls.Add(dgvIkramlar);
            Controls.Add(cmbIkramAlim);
            Controls.Add(cmbToptanci);
            Controls.Add(btnStokAl);
            Controls.Add(btnEkle);
            Controls.Add(numAlimFiyati);
            Controls.Add(numAlimAdet);
            Controls.Add(numFiyat);
            Controls.Add(txtAd);
            Name = "IkramForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "IkramForm";
            Load += IkramForm_Load;
            ((System.ComponentModel.ISupportInitialize)numFiyat).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAlimAdet).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAlimFiyati).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvIkramlar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAd;
        private NumericUpDown numFiyat;
        private Button btnEkle;
        private ComboBox cmbToptanci;
        private NumericUpDown numAlimAdet;
        private ComboBox cmbIkramAlim;
        private NumericUpDown numAlimFiyati;
        private Button btnStokAl;
        private Button btnSil;
        private Label lblUrunAdi;
        private Label lblSatisFiyati;
        private Label lblToptanci;
        private Label lblAlimUrun;
        private Label lblAlimAdet;
        private Label lblAlimFiyati;
        private Label lblUrunTanim;
        private Label lblStokAlimi;
        private DataGridView dgvIkramlar;
        private DataGridViewTextBoxColumn colAd;
        private DataGridViewTextBoxColumn colFiyat;
        private DataGridViewTextBoxColumn colStok;
    }
}
