namespace veritabaniProje
{
    partial class anaArayüz
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
            this.satisArayuzu = new System.Windows.Forms.Button();
            this.musteriArayuzu = new System.Windows.Forms.Button();
            this.stokArayuzu = new System.Windows.Forms.Button();
            this.raporlamaArayuzu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // satisArayuzu
            // 
            this.satisArayuzu.Location = new System.Drawing.Point(64, 65);
            this.satisArayuzu.Name = "satisArayuzu";
            this.satisArayuzu.Size = new System.Drawing.Size(174, 76);
            this.satisArayuzu.TabIndex = 0;
            this.satisArayuzu.Text = "Satış Arayüzü";
            this.satisArayuzu.UseVisualStyleBackColor = true;
            this.satisArayuzu.Click += new System.EventHandler(this.button1_Click);
            // 
            // musteriArayuzu
            // 
            this.musteriArayuzu.Location = new System.Drawing.Point(315, 65);
            this.musteriArayuzu.Name = "musteriArayuzu";
            this.musteriArayuzu.Size = new System.Drawing.Size(190, 76);
            this.musteriArayuzu.TabIndex = 1;
            this.musteriArayuzu.Text = "Müşteri Arayüzü";
            this.musteriArayuzu.UseVisualStyleBackColor = true;
            this.musteriArayuzu.Click += new System.EventHandler(this.button2_Click);
            // 
            // stokArayuzu
            // 
            this.stokArayuzu.Location = new System.Drawing.Point(64, 195);
            this.stokArayuzu.Name = "stokArayuzu";
            this.stokArayuzu.Size = new System.Drawing.Size(174, 80);
            this.stokArayuzu.TabIndex = 2;
            this.stokArayuzu.Text = "Stok Ekleme Arayüzü";
            this.stokArayuzu.UseVisualStyleBackColor = true;
            this.stokArayuzu.Click += new System.EventHandler(this.button3_Click);
            // 
            // raporlamaArayuzu
            // 
            this.raporlamaArayuzu.Location = new System.Drawing.Point(315, 195);
            this.raporlamaArayuzu.Name = "raporlamaArayuzu";
            this.raporlamaArayuzu.Size = new System.Drawing.Size(190, 76);
            this.raporlamaArayuzu.TabIndex = 3;
            this.raporlamaArayuzu.Text = "Raporlama Arayüzü";
            this.raporlamaArayuzu.UseVisualStyleBackColor = true;
            this.raporlamaArayuzu.Click += new System.EventHandler(this.button4_Click);
            // 
            // anaArayüz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 359);
            this.Controls.Add(this.raporlamaArayuzu);
            this.Controls.Add(this.stokArayuzu);
            this.Controls.Add(this.musteriArayuzu);
            this.Controls.Add(this.satisArayuzu);
            this.Name = "anaArayüz";
            this.Text = "anaArayüz";
            this.Load += new System.EventHandler(this.anaArayüz_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button satisArayuzu;
        private System.Windows.Forms.Button musteriArayuzu;
        private System.Windows.Forms.Button stokArayuzu;
        private System.Windows.Forms.Button raporlamaArayuzu;
    }
}