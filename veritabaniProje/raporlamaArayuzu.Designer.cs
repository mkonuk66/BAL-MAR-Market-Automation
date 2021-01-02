
namespace veritabaniProje
{
    partial class raporlamaArayuzu
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
            this.musteriRaporu = new System.Windows.Forms.Button();
            this.musteriSatis = new System.Windows.Forms.Button();
            this.karzararDurum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // musteriRaporu
            // 
            this.musteriRaporu.Location = new System.Drawing.Point(438, 104);
            this.musteriRaporu.Name = "musteriRaporu";
            this.musteriRaporu.Size = new System.Drawing.Size(249, 93);
            this.musteriRaporu.TabIndex = 3;
            this.musteriRaporu.Text = "Müşteri Borç Durum Raporu";
            this.musteriRaporu.UseVisualStyleBackColor = true;
            this.musteriRaporu.Click += new System.EventHandler(this.musteriRaporu_Click);
            // 
            // musteriSatis
            // 
            this.musteriSatis.Location = new System.Drawing.Point(119, 104);
            this.musteriSatis.Name = "musteriSatis";
            this.musteriSatis.Size = new System.Drawing.Size(249, 93);
            this.musteriSatis.TabIndex = 4;
            this.musteriSatis.Text = "Müşteri Bazlı Satış Raporu";
            this.musteriSatis.UseVisualStyleBackColor = true;
            this.musteriSatis.Click += new System.EventHandler(this.musteriSatis_Click);
            // 
            // karzararDurum
            // 
            this.karzararDurum.Location = new System.Drawing.Point(275, 261);
            this.karzararDurum.Name = "karzararDurum";
            this.karzararDurum.Size = new System.Drawing.Size(249, 93);
            this.karzararDurum.TabIndex = 5;
            this.karzararDurum.Text = "Belirlenen Tarihlerde Kar-Zarar Durum Raporu";
            this.karzararDurum.UseVisualStyleBackColor = true;
            this.karzararDurum.Click += new System.EventHandler(this.karzararDurum_Click);
            // 
            // raporlamaArayuzu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.karzararDurum);
            this.Controls.Add(this.musteriSatis);
            this.Controls.Add(this.musteriRaporu);
            this.Name = "raporlamaArayuzu";
            this.Text = "Raporlama Arayüzü";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button musteriRaporu;
        private System.Windows.Forms.Button musteriSatis;
        private System.Windows.Forms.Button karzararDurum;
    }
}