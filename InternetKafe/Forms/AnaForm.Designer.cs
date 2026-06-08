namespace InternetKafe
{
    partial class AnaForm
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
            btnMusteriler = new Button();
            lblMusteriSayisi = new Label();
            btnBilgisayarlar = new Button();
            lblToplamPC = new Label();
            lblBosPC = new Label();
            SuspendLayout();
            // 
            // btnMusteriler
            // 
            btnMusteriler.Location = new Point(31, 32);
            btnMusteriler.Name = "btnMusteriler";
            btnMusteriler.Size = new Size(131, 29);
            btnMusteriler.TabIndex = 0;
            btnMusteriler.Text = "Müşteri Yönetimi";
            btnMusteriler.UseVisualStyleBackColor = true;
            btnMusteriler.Click += btnMusteriler_Click;
            // 
            // lblMusteriSayisi
            // 
            lblMusteriSayisi.AutoSize = true;
            lblMusteriSayisi.Location = new Point(31, 96);
            lblMusteriSayisi.Name = "lblMusteriSayisi";
            lblMusteriSayisi.Size = new Size(114, 20);
            lblMusteriSayisi.TabIndex = 1;
            lblMusteriSayisi.Text = "Müşteri Sayısı: 0";
            // 
            // btnBilgisayarlar
            // 
            btnBilgisayarlar.Location = new Point(241, 32);
            btnBilgisayarlar.Name = "btnBilgisayarlar";
            btnBilgisayarlar.Size = new Size(167, 29);
            btnBilgisayarlar.TabIndex = 2;
            btnBilgisayarlar.Text = "Bilgisayar Yönetimi";
            btnBilgisayarlar.UseVisualStyleBackColor = true;
            btnBilgisayarlar.Click += btnBilgisayarlar_Click;
            // 
            // lblToplamPC
            // 
            lblToplamPC.AutoSize = true;
            lblToplamPC.Location = new Point(261, 73);
            lblToplamPC.Name = "lblToplamPC";
            lblToplamPC.Size = new Size(95, 20);
            lblToplamPC.TabIndex = 3;
            lblToplamPC.Text = "Toplam PC: 0";
            // 
            // lblBosPC
            // 
            lblBosPC.AutoSize = true;
            lblBosPC.Location = new Point(261, 105);
            lblBosPC.Name = "lblBosPC";
            lblBosPC.Size = new Size(69, 20);
            lblBosPC.TabIndex = 4;
            lblBosPC.Text = "Boş PC: 0";
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblBosPC);
            Controls.Add(lblToplamPC);
            Controls.Add(btnBilgisayarlar);
            Controls.Add(lblMusteriSayisi);
            Controls.Add(btnMusteriler);
            Name = "AnaForm";
            Text = "AnaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMusteriler;
        private Label lblMusteriSayisi;
        private Button btnBilgisayarlar;
        private Label lblToplamPC;
        private Label lblBosPC;
    }
}