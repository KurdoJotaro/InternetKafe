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
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lstIslemler
            // 
            lstIslemler.FormattingEnabled = true;
            lstIslemler.Location = new Point(104, 173);
            lstIslemler.Name = "lstIslemler";
            lstIslemler.Size = new Size(290, 184);
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
            lblToplamGelir.Text = "Toplam Gelir:\r\n₺0,00";
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
            panel2.Controls.Add(lstIslemler);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(235, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(679, 586);
            panel2.TabIndex = 5;
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
    }
}