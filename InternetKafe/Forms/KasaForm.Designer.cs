namespace InternetKafe
{
    partial class KasaForm
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
            lstIslemler = new ListBox();
            lblToplamGelir = new Label();
            lblToplamGider = new Label();
            lblNetKar = new Label();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblIslemGecmisi = new Label();
            btnTamReset = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // lstIslemler
            // 
            lstIslemler.Dock = DockStyle.Fill;
            lstIslemler.FormattingEnabled = true;
            lstIslemler.Location = new Point(3, 120);
            lstIslemler.Name = "lstIslemler";
            lstIslemler.Size = new Size(673, 463);
            lstIslemler.TabIndex = 0;
            // 
            // lblToplamGelir
            // 
            lblToplamGelir.AutoSize = true;
            lblToplamGelir.BackColor = Color.White;
            lblToplamGelir.Dock = DockStyle.Fill;
            lblToplamGelir.Font = new Font("Rockwell", 16.2F, FontStyle.Bold);
            lblToplamGelir.ForeColor = Color.Lime;
            lblToplamGelir.Location = new Point(3, 0);
            lblToplamGelir.Name = "lblToplamGelir";
            lblToplamGelir.Size = new Size(229, 195);
            lblToplamGelir.TabIndex = 1;
            lblToplamGelir.Text = "Toplam\r\nGelir:\r\n₺0,00";
            lblToplamGelir.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblToplamGider
            // 
            lblToplamGider.AutoSize = true;
            lblToplamGider.BackColor = Color.White;
            lblToplamGider.Dock = DockStyle.Fill;
            lblToplamGider.Font = new Font("Rockwell", 16.2F, FontStyle.Bold);
            lblToplamGider.ForeColor = Color.Red;
            lblToplamGider.Location = new Point(3, 195);
            lblToplamGider.Name = "lblToplamGider";
            lblToplamGider.Size = new Size(229, 195);
            lblToplamGider.TabIndex = 2;
            lblToplamGider.Text = "Toplam Gider:\r\n₺0,00";
            lblToplamGider.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNetKar
            // 
            lblNetKar.AutoSize = true;
            lblNetKar.BackColor = Color.White;
            lblNetKar.Dock = DockStyle.Fill;
            lblNetKar.Font = new Font("Rockwell", 16.2F, FontStyle.Bold);
            lblNetKar.Location = new Point(3, 390);
            lblNetKar.Name = "lblNetKar";
            lblNetKar.Size = new Size(229, 196);
            lblNetKar.TabIndex = 3;
            lblNetKar.Text = "Net Kâr:\r\n₺0,00";
            lblNetKar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(235, 586);
            panel1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblNetKar, 0, 2);
            tableLayoutPanel1.Controls.Add(lblToplamGider, 0, 1);
            tableLayoutPanel1.Controls.Add(lblToplamGelir, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(235, 586);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(235, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(679, 586);
            panel2.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Controls.Add(lstIslemler, 0, 1);
            tableLayoutPanel2.Controls.Add(lblIslemGecmisi, 0, 0);
            tableLayoutPanel2.Controls.Add(btnTamReset, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.Size = new Size(679, 586);
            tableLayoutPanel2.TabIndex = 1;
            tableLayoutPanel2.SetColumnSpan(lstIslemler, 2);
            // 
            // lblIslemGecmisi
            // 
            lblIslemGecmisi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblIslemGecmisi.AutoSize = true;
            lblIslemGecmisi.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblIslemGecmisi.Location = new Point(3, 0);
            lblIslemGecmisi.Name = "lblIslemGecmisi";
            lblIslemGecmisi.Size = new Size(673, 117);
            lblIslemGecmisi.TabIndex = 1;
            lblIslemGecmisi.Text = "İŞLEM GEÇMİŞİ";
            lblIslemGecmisi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnTamReset
            // 
            btnTamReset.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnTamReset.Location = new Point(478, 24);
            btnTamReset.Margin = new Padding(3, 24, 18, 24);
            btnTamReset.Name = "btnTamReset";
            btnTamReset.Size = new Size(183, 69);
            btnTamReset.TabIndex = 2;
            btnTamReset.Text = "Tam Reset";
            btnTamReset.UseVisualStyleBackColor = true;
            btnTamReset.Click += btnTamReset_Click;
            // 
            // KasaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 586);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "KasaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "KasaForm";
            Load += KasaForm_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstIslemler;
        private Label lblToplamGelir;
        private Label lblToplamGider;
        private Label lblNetKar;
        private Panel panel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblIslemGecmisi;
        private Button btnTamReset;
    }
}
