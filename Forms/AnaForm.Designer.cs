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
            SuspendLayout();
            // 
            // btnMusteriler
            // 
            btnMusteriler.Location = new Point(325, 159);
            btnMusteriler.Name = "btnMusteriler";
            btnMusteriler.Size = new Size(131, 29);
            btnMusteriler.TabIndex = 0;
            btnMusteriler.Text = "Müşteri Yönetimi";
            btnMusteriler.UseVisualStyleBackColor = true;
            // 
            // lblMusteriSayisi
            // 
            lblMusteriSayisi.AutoSize = true;
            lblMusteriSayisi.Location = new Point(325, 203);
            lblMusteriSayisi.Name = "lblMusteriSayisi";
            lblMusteriSayisi.Size = new Size(114, 20);
            lblMusteriSayisi.TabIndex = 1;
            lblMusteriSayisi.Text = "Müşteri Sayısı: 0";
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}