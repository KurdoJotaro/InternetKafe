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
            txtAd.Location = new Point(12, 33);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 0;
            // 
            // numFiyat
            // 
            numFiyat.DecimalPlaces = 2;
            numFiyat.Location = new Point(13, 121);
            numFiyat.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numFiyat.Name = "numFiyat";
            numFiyat.Size = new Size(150, 27);
            numFiyat.TabIndex = 1;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(13, 173);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Ürün Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // cmbToptanci
            // 
            cmbToptanci.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbToptanci.FormattingEnabled = true;
            cmbToptanci.Location = new Point(266, 32);
            cmbToptanci.Name = "cmbToptanci";
            cmbToptanci.Size = new Size(151, 28);
            cmbToptanci.TabIndex = 3;
            // 
            // numAlimAdet
            // 
            numAlimAdet.Location = new Point(266, 99);
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
            cmbIkramAlim.Location = new Point(265, 66);
            cmbIkramAlim.Name = "cmbIkramAlim";
            cmbIkramAlim.Size = new Size(151, 28);
            cmbIkramAlim.TabIndex = 3;
            // 
            // numAlimFiyati
            // 
            numAlimFiyati.DecimalPlaces = 2;
            numAlimFiyati.Location = new Point(265, 145);
            numAlimFiyati.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numAlimFiyati.Name = "numAlimFiyati";
            numAlimFiyati.Size = new Size(150, 27);
            numAlimFiyati.TabIndex = 1;
            // 
            // btnStokAl
            // 
            btnStokAl.Location = new Point(265, 178);
            btnStokAl.Name = "btnStokAl";
            btnStokAl.Size = new Size(94, 29);
            btnStokAl.TabIndex = 2;
            btnStokAl.Text = "Stok Al";
            btnStokAl.UseVisualStyleBackColor = true;
            btnStokAl.Click += btnStokAl_Click;
            // 
            // dgvIkramlar
            // 
            dgvIkramlar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvIkramlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIkramlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIkramlar.Columns.AddRange(new DataGridViewColumn[] { colAd, colFiyat, colStok });
            dgvIkramlar.Location = new Point(117, 263);
            dgvIkramlar.Name = "dgvIkramlar";
            dgvIkramlar.RowHeadersWidth = 51;
            dgvIkramlar.Size = new Size(712, 324);
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
        private DataGridView dgvIkramlar;
        private DataGridViewTextBoxColumn colAd;
        private DataGridViewTextBoxColumn colFiyat;
        private DataGridViewTextBoxColumn colStok;
    }
}
