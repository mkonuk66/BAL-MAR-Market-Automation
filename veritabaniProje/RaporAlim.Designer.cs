
namespace veritabaniProje
{
    partial class RaporAlim
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.musteriSatis = new System.Windows.Forms.Button();
            this.musteriRaporu = new System.Windows.Forms.Button();
            this.karzararDurum = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(282, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rapor Alım";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(485, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 53);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(216, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(433, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Almak İstediğiniz Rapor Türünü Seçiniz";
            // 
            // musteriSatis
            // 
            this.musteriSatis.BackColor = System.Drawing.SystemColors.Control;
            this.musteriSatis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.musteriSatis.FlatAppearance.BorderSize = 0;
            this.musteriSatis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musteriSatis.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriSatis.ForeColor = System.Drawing.Color.Sienna;
            this.musteriSatis.Location = new System.Drawing.Point(53, 207);
            this.musteriSatis.Name = "musteriSatis";
            this.musteriSatis.Size = new System.Drawing.Size(249, 93);
            this.musteriSatis.TabIndex = 5;
            this.musteriSatis.Text = "Müşteri Bazlı Satış Raporu";
            this.musteriSatis.UseVisualStyleBackColor = false;
            this.musteriSatis.Click += new System.EventHandler(this.musteriSatis_Click);
            // 
            // musteriRaporu
            // 
            this.musteriRaporu.BackColor = System.Drawing.SystemColors.Control;
            this.musteriRaporu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.musteriRaporu.FlatAppearance.BorderSize = 0;
            this.musteriRaporu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musteriRaporu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriRaporu.ForeColor = System.Drawing.Color.Sienna;
            this.musteriRaporu.Location = new System.Drawing.Point(319, 207);
            this.musteriRaporu.Name = "musteriRaporu";
            this.musteriRaporu.Size = new System.Drawing.Size(249, 93);
            this.musteriRaporu.TabIndex = 6;
            this.musteriRaporu.Text = "Müşteri Borç Durum Raporu";
            this.musteriRaporu.UseVisualStyleBackColor = false;
            this.musteriRaporu.Click += new System.EventHandler(this.musteriRaporu_Click);
            // 
            // karzararDurum
            // 
            this.karzararDurum.BackColor = System.Drawing.SystemColors.Control;
            this.karzararDurum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.karzararDurum.FlatAppearance.BorderSize = 0;
            this.karzararDurum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.karzararDurum.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.karzararDurum.ForeColor = System.Drawing.Color.Sienna;
            this.karzararDurum.Location = new System.Drawing.Point(587, 207);
            this.karzararDurum.Name = "karzararDurum";
            this.karzararDurum.Size = new System.Drawing.Size(249, 93);
            this.karzararDurum.TabIndex = 7;
            this.karzararDurum.Text = "Belirlenen Tarihlerde Kar-Zarar Durum Raporu";
            this.karzararDurum.UseVisualStyleBackColor = false;
            this.karzararDurum.Click += new System.EventHandler(this.karzararDurum_Click);
            // 
            // RaporAlim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.karzararDurum);
            this.Controls.Add(this.musteriRaporu);
            this.Controls.Add(this.musteriSatis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "RaporAlim";
            this.Size = new System.Drawing.Size(890, 403);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button musteriSatis;
        private System.Windows.Forms.Button musteriRaporu;
        private System.Windows.Forms.Button karzararDurum;
    }
}
