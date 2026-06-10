namespace InternetKafe
{
    partial class ToptanciForm
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
            txtFirmaAdi = new TextBox();
            txtVergiNo = new TextBox();
            btnEkle = new Button();
            dgvToptancilar = new DataGridView();
            lblYetkiliAdi = new Label();
            lblFirmaAdi = new Label();
            lblVergiNo = new Label();
            lblToptanciTanim = new Label();
            colAd = new DataGridViewTextBoxColumn();
            colFirma = new DataGridViewTextBoxColumn();
            colVergiNo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvToptancilar).BeginInit();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(32, 82);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(180, 27);
            txtAd.TabIndex = 0;
            // 
            // txtFirmaAdi
            // 
            txtFirmaAdi.Location = new Point(232, 82);
            txtFirmaAdi.Name = "txtFirmaAdi";
            txtFirmaAdi.Size = new Size(180, 27);
            txtFirmaAdi.TabIndex = 2;
            // 
            // txtVergiNo
            // 
            txtVergiNo.Location = new Point(432, 82);
            txtVergiNo.Name = "txtVergiNo";
            txtVergiNo.Size = new Size(180, 27);
            txtVergiNo.TabIndex = 3;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(632, 80);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(130, 31);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // dgvToptancilar
            // 
            dgvToptancilar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvToptancilar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvToptancilar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvToptancilar.Columns.AddRange(new DataGridViewColumn[] { colAd, colFirma, colVergiNo });
            dgvToptancilar.Location = new Point(32, 160);
            dgvToptancilar.Name = "dgvToptancilar";
            dgvToptancilar.RowHeadersWidth = 51;
            dgvToptancilar.Size = new Size(850, 405);
            dgvToptancilar.TabIndex = 5;
            // 
            // lblYetkiliAdi
            // 
            lblYetkiliAdi.AutoSize = true;
            lblYetkiliAdi.Location = new Point(32, 59);
            lblYetkiliAdi.Name = "lblYetkiliAdi";
            lblYetkiliAdi.Size = new Size(78, 20);
            lblYetkiliAdi.TabIndex = 6;
            lblYetkiliAdi.Text = "Yetkili Adı";
            // 
            // lblFirmaAdi
            // 
            lblFirmaAdi.AutoSize = true;
            lblFirmaAdi.Location = new Point(232, 59);
            lblFirmaAdi.Name = "lblFirmaAdi";
            lblFirmaAdi.Size = new Size(76, 20);
            lblFirmaAdi.TabIndex = 7;
            lblFirmaAdi.Text = "Firma Adı";
            // 
            // lblVergiNo
            // 
            lblVergiNo.AutoSize = true;
            lblVergiNo.Location = new Point(432, 59);
            lblVergiNo.Name = "lblVergiNo";
            lblVergiNo.Size = new Size(66, 20);
            lblVergiNo.TabIndex = 8;
            lblVergiNo.Text = "Vergi No";
            // 
            // lblToptanciTanim
            // 
            lblToptanciTanim.AutoSize = true;
            lblToptanciTanim.Font = new Font("Noto Sans ExtBd", 10.2F, FontStyle.Bold);
            lblToptanciTanim.Location = new Point(32, 25);
            lblToptanciTanim.Name = "lblToptanciTanim";
            lblToptanciTanim.Size = new Size(137, 24);
            lblToptanciTanim.TabIndex = 9;
            lblToptanciTanim.Text = "Toptancı Tanımı";
            // 
            // colAd
            // 
            colAd.HeaderText = "Ad";
            colAd.MinimumWidth = 6;
            colAd.Name = "colAd";
            // 
            // colFirma
            // 
            colFirma.HeaderText = "Firma";
            colFirma.MinimumWidth = 6;
            colFirma.Name = "colFirma";
            // 
            // colVergiNo
            // 
            colVergiNo.HeaderText = "Vergi No";
            colVergiNo.MinimumWidth = 6;
            colVergiNo.Name = "colVergiNo";
            // 
            // ToptanciForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 586);
            Controls.Add(lblToptanciTanim);
            Controls.Add(lblVergiNo);
            Controls.Add(lblFirmaAdi);
            Controls.Add(lblYetkiliAdi);
            Controls.Add(dgvToptancilar);
            Controls.Add(btnEkle);
            Controls.Add(txtVergiNo);
            Controls.Add(txtFirmaAdi);
            Controls.Add(txtAd);
            Name = "ToptanciForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ToptanciForm";
            Load += ToptanciForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvToptancilar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAd;
        private TextBox txtFirmaAdi;
        private TextBox txtVergiNo;
        private Button btnEkle;
        private DataGridView dgvToptancilar;
        private Label lblYetkiliAdi;
        private Label lblFirmaAdi;
        private Label lblVergiNo;
        private Label lblToptanciTanim;
        private DataGridViewTextBoxColumn colAd;
        private DataGridViewTextBoxColumn colFirma;
        private DataGridViewTextBoxColumn colVergiNo;
    }
}
