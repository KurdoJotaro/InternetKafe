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
            SuspendLayout();
            // 
            // lstIslemler
            // 
            lstIslemler.FormattingEnabled = true;
            lstIslemler.Location = new Point(106, 64);
            lstIslemler.Name = "lstIslemler";
            lstIslemler.Size = new Size(604, 344);
            lstIslemler.TabIndex = 0;
            // 
            // lblToplamGelir
            // 
            lblToplamGelir.AutoSize = true;
            lblToplamGelir.Location = new Point(106, 26);
            lblToplamGelir.Name = "lblToplamGelir";
            lblToplamGelir.Size = new Size(136, 20);
            lblToplamGelir.TabIndex = 1;
            lblToplamGelir.Text = "Toplam Gelir: ₺0,00";
            // 
            // lblToplamGider
            // 
            lblToplamGider.AutoSize = true;
            lblToplamGider.Location = new Point(248, 26);
            lblToplamGider.Name = "lblToplamGider";
            lblToplamGider.Size = new Size(141, 20);
            lblToplamGider.TabIndex = 2;
            lblToplamGider.Text = "Toplam Gider: ₺0,00";
            // 
            // lblNetKar
            // 
            lblNetKar.AutoSize = true;
            lblNetKar.Location = new Point(415, 26);
            lblNetKar.Name = "lblNetKar";
            lblNetKar.Size = new Size(101, 20);
            lblNetKar.TabIndex = 3;
            lblNetKar.Text = "Net Kar: ₺0,00";
            // 
            // KasaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNetKar);
            Controls.Add(lblToplamGider);
            Controls.Add(lblToplamGelir);
            Controls.Add(lstIslemler);
            Name = "KasaForm";
            Text = "KasaForm";
            Load += KasaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstIslemler;
        private Label lblToplamGelir;
        private Label lblToplamGider;
        private Label lblNetKar;
    }
}