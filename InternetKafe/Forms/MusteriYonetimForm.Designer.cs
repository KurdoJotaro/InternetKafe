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
            lblMusteriAd = new Label();
            lblMusteriYas = new Label();
            lblMusteriUyelik = new Label();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel3 = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            lblKisiBilgisi = new Label();
            ((System.ComponentModel.ISupportInitialize)numYas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtAd.Font = new Font("Segoe UI", 25.8000011F);
            txtAd.Location = new Point(3, 84);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(215, 65);
            txtAd.TabIndex = 0;
            // 
            // numYas
            // 
            numYas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            numYas.Font = new Font("Segoe UI", 25.8000011F);
            numYas.Location = new Point(3, 84);
            numYas.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            numYas.Name = "numYas";
            numYas.Size = new Size(215, 65);
            numYas.TabIndex = 1;
            numYas.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // chkUyelik
            // 
            chkUyelik.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chkUyelik.AutoSize = true;
            chkUyelik.Location = new Point(3, 84);
            chkUyelik.Name = "chkUyelik";
            chkUyelik.Size = new Size(215, 76);
            chkUyelik.TabIndex = 2;
            chkUyelik.Text = "Üyelik Var";
            chkUyelik.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            btnEkle.Dock = DockStyle.Fill;
            btnEkle.Location = new Point(684, 3);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(221, 163);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnGuncelle.Location = new Point(3, 3);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(215, 193);
            btnGuncelle.TabIndex = 4;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSil.Location = new Point(3, 202);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(215, 194);
            btnSil.TabIndex = 5;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // dgvMusteriler
            // 
            dgvMusteriler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMusteriler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMusteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMusteriler.Columns.AddRange(new DataGridViewColumn[] { colAd, colYas, colUyelik, colToplamHarcama, colIndirimOrani });
            dgvMusteriler.Location = new Point(3, 3);
            dgvMusteriler.Name = "dgvMusteriler";
            dgvMusteriler.RowHeadersWidth = 51;
            dgvMusteriler.Size = new Size(675, 399);
            dgvMusteriler.TabIndex = 6;
            dgvMusteriler.SelectionChanged += dgvMusteriler_SelectionChanged;
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
            // lblMusteriAd
            // 
            lblMusteriAd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMusteriAd.AutoSize = true;
            lblMusteriAd.Location = new Point(3, 0);
            lblMusteriAd.Name = "lblMusteriAd";
            lblMusteriAd.Size = new Size(215, 81);
            lblMusteriAd.TabIndex = 7;
            lblMusteriAd.Text = "Müşteri Ad";
            lblMusteriAd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMusteriYas
            // 
            lblMusteriYas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMusteriYas.AutoSize = true;
            lblMusteriYas.Location = new Point(3, 0);
            lblMusteriYas.Name = "lblMusteriYas";
            lblMusteriYas.Size = new Size(215, 81);
            lblMusteriYas.TabIndex = 7;
            lblMusteriYas.Text = "Müşteri Yaş";
            lblMusteriYas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMusteriUyelik
            // 
            lblMusteriUyelik.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMusteriUyelik.AutoSize = true;
            lblMusteriUyelik.Location = new Point(3, 0);
            lblMusteriUyelik.Name = "lblMusteriUyelik";
            lblMusteriUyelik.Size = new Size(215, 81);
            lblMusteriUyelik.TabIndex = 7;
            lblMusteriUyelik.Text = "Müşteri Üyelik";
            lblMusteriUyelik.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 586);
            panel1.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Controls.Add(lblKisiBilgisi, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 62F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(914, 586);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(908, 169);
            panel2.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(btnEkle, 3, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 2, 0);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(908, 169);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(lblMusteriAd, 0, 0);
            tableLayoutPanel3.Controls.Add(txtAd, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(221, 163);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(lblMusteriYas, 0, 0);
            tableLayoutPanel4.Controls.Add(numYas, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(230, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(221, 163);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(lblMusteriUyelik, 0, 0);
            tableLayoutPanel5.Controls.Add(chkUyelik, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(457, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(221, 163);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel6);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 178);
            panel3.Name = "panel3";
            panel3.Size = new Size(908, 405);
            panel3.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.Controls.Add(dgvMusteriler, 0, 0);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel7, 1, 0);
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(908, 405);
            tableLayoutPanel6.TabIndex = 7;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(btnGuncelle, 0, 0);
            tableLayoutPanel7.Controls.Add(btnSil, 0, 1);
            tableLayoutPanel7.Location = new Point(684, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(221, 399);
            tableLayoutPanel7.TabIndex = 7;
            // 
            // lblKisiBilgisi
            // 
            lblKisiBilgisi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblKisiBilgisi.Location = new Point(12, 527);
            lblKisiBilgisi.Margin = new Padding(12, 0, 12, 8);
            lblKisiBilgisi.Name = "lblKisiBilgisi";
            lblKisiBilgisi.Size = new Size(890, 51);
            lblKisiBilgisi.TabIndex = 9;
            lblKisiBilgisi.Text = "Seçili kişi bilgisi: -";
            lblKisiBilgisi.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MusteriYonetimForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 586);
            Controls.Add(panel1);
            Name = "MusteriYonetimForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MusteriYonetimForm";
            Load += MusteriYonetimForm_Load;
            ((System.ComponentModel.ISupportInitialize)numYas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            panel3.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            ResumeLayout(false);
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
        private Label lblMusteriAd;
        private Label lblMusteriYas;
        private Label lblMusteriUyelik;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private Label lblKisiBilgisi;
    }
}
