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
            numYas = new NumericUpDown();
            txtFirmaAdi = new TextBox();
            txtVergiNo = new TextBox();
            btnEkle = new Button();
            dgvToptancilar = new DataGridView();
            colAd = new DataGridViewTextBoxColumn();
            colYas = new DataGridViewTextBoxColumn();
            colFirma = new DataGridViewTextBoxColumn();
            colVergiNo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)numYas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvToptancilar).BeginInit();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(104, 83);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 0;
            // 
            // numYas
            // 
            numYas.Location = new Point(249, 83);
            numYas.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            numYas.Name = "numYas";
            numYas.Size = new Size(150, 27);
            numYas.TabIndex = 1;
            numYas.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // txtFirmaAdi
            // 
            txtFirmaAdi.Location = new Point(405, 83);
            txtFirmaAdi.Name = "txtFirmaAdi";
            txtFirmaAdi.Size = new Size(125, 27);
            txtFirmaAdi.TabIndex = 2;
            // 
            // txtVergiNo
            // 
            txtVergiNo.Location = new Point(547, 82);
            txtVergiNo.Name = "txtVergiNo";
            txtVergiNo.Size = new Size(125, 27);
            txtVergiNo.TabIndex = 3;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(104, 162);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // dgvToptancilar
            // 
            dgvToptancilar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvToptancilar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvToptancilar.Columns.AddRange(new DataGridViewColumn[] { colAd, colYas, colFirma, colVergiNo });
            dgvToptancilar.Location = new Point(110, 220);
            dgvToptancilar.Name = "dgvToptancilar";
            dgvToptancilar.RowHeadersWidth = 51;
            dgvToptancilar.Size = new Size(588, 188);
            dgvToptancilar.TabIndex = 5;
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
            ClientSize = new Size(800, 450);
            Controls.Add(dgvToptancilar);
            Controls.Add(btnEkle);
            Controls.Add(txtVergiNo);
            Controls.Add(txtFirmaAdi);
            Controls.Add(numYas);
            Controls.Add(txtAd);
            Name = "ToptanciForm";
            Text = "ToptanciForm";
            Load += ToptanciForm_Load;
            ((System.ComponentModel.ISupportInitialize)numYas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvToptancilar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAd;
        private NumericUpDown numYas;
        private TextBox txtFirmaAdi;
        private TextBox txtVergiNo;
        private Button btnEkle;
        private DataGridView dgvToptancilar;
        private DataGridViewTextBoxColumn colAd;
        private DataGridViewTextBoxColumn colYas;
        private DataGridViewTextBoxColumn colFirma;
        private DataGridViewTextBoxColumn colVergiNo;
    }
}