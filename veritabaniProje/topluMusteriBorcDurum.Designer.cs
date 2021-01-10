
namespace veritabaniProje
{
    partial class topluMusteriBorcDurum
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
            this.topluBorcDurum = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.wordAktar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.topluBorcDurum)).BeginInit();
            this.SuspendLayout();
            // 
            // topluBorcDurum
            // 
            this.topluBorcDurum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.topluBorcDurum.Location = new System.Drawing.Point(31, 80);
            this.topluBorcDurum.Name = "topluBorcDurum";
            this.topluBorcDurum.RowHeadersWidth = 51;
            this.topluBorcDurum.RowTemplate.Height = 24;
            this.topluBorcDurum.Size = new System.Drawing.Size(730, 205);
            this.topluBorcDurum.TabIndex = 0;
            this.topluBorcDurum.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(220, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "TOPLU MÜŞTERİ BORÇ DURUMU";
            // 
            // wordAktar
            // 
            this.wordAktar.Location = new System.Drawing.Point(275, 333);
            this.wordAktar.Name = "wordAktar";
            this.wordAktar.Size = new System.Drawing.Size(228, 51);
            this.wordAktar.TabIndex = 2;
            this.wordAktar.Text = "WORDE AKTAR";
            this.wordAktar.UseVisualStyleBackColor = true;
            this.wordAktar.Click += new System.EventHandler(this.wordAktar_Click);
            // 
            // topluMusteriBorcDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wordAktar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topluBorcDurum);
            this.Name = "topluMusteriBorcDurum";
            this.Text = "Müşteri Borç Durum Raporu";
            this.Load += new System.EventHandler(this.topluMusteriBorcDurum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.topluBorcDurum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView topluBorcDurum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button wordAktar;
    }
}