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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // satisArayuzu
            // 
            this.satisArayuzu.BackColor = System.Drawing.Color.Gainsboro;
            this.satisArayuzu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.satisArayuzu.ForeColor = System.Drawing.Color.Sienna;
            this.satisArayuzu.Location = new System.Drawing.Point(85, 96);
            this.satisArayuzu.Margin = new System.Windows.Forms.Padding(4);
            this.satisArayuzu.Name = "satisArayuzu";
            this.satisArayuzu.Size = new System.Drawing.Size(232, 94);
            this.satisArayuzu.TabIndex = 0;
            this.satisArayuzu.Text = "Satış Arayüzü";
            this.satisArayuzu.UseVisualStyleBackColor = false;
            this.satisArayuzu.Click += new System.EventHandler(this.button1_Click);
            // 
            // musteriArayuzu
            // 
            this.musteriArayuzu.BackColor = System.Drawing.Color.Gainsboro;
            this.musteriArayuzu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.musteriArayuzu.ForeColor = System.Drawing.Color.Sienna;
            this.musteriArayuzu.Location = new System.Drawing.Point(420, 96);
            this.musteriArayuzu.Margin = new System.Windows.Forms.Padding(4);
            this.musteriArayuzu.Name = "musteriArayuzu";
            this.musteriArayuzu.Size = new System.Drawing.Size(253, 94);
            this.musteriArayuzu.TabIndex = 1;
            this.musteriArayuzu.Text = "Müşteri Arayüzü /\r\n Borç Ödeme\r\n";
            this.musteriArayuzu.UseVisualStyleBackColor = false;
            this.musteriArayuzu.Click += new System.EventHandler(this.button2_Click);
            // 
            // stokArayuzu
            // 
            this.stokArayuzu.BackColor = System.Drawing.Color.Gainsboro;
            this.stokArayuzu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.stokArayuzu.ForeColor = System.Drawing.Color.Sienna;
            this.stokArayuzu.Location = new System.Drawing.Point(85, 263);
            this.stokArayuzu.Margin = new System.Windows.Forms.Padding(4);
            this.stokArayuzu.Name = "stokArayuzu";
            this.stokArayuzu.Size = new System.Drawing.Size(232, 98);
            this.stokArayuzu.TabIndex = 2;
            this.stokArayuzu.Text = "Stok Arayüzü";
            this.stokArayuzu.UseVisualStyleBackColor = false;
            this.stokArayuzu.Click += new System.EventHandler(this.button3_Click);
            // 
            // raporlamaArayuzu
            // 
            this.raporlamaArayuzu.BackColor = System.Drawing.Color.Gainsboro;
            this.raporlamaArayuzu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.raporlamaArayuzu.ForeColor = System.Drawing.Color.Sienna;
            this.raporlamaArayuzu.Location = new System.Drawing.Point(420, 263);
            this.raporlamaArayuzu.Margin = new System.Windows.Forms.Padding(4);
            this.raporlamaArayuzu.Name = "raporlamaArayuzu";
            this.raporlamaArayuzu.Size = new System.Drawing.Size(253, 94);
            this.raporlamaArayuzu.TabIndex = 3;
            this.raporlamaArayuzu.Text = "Raporlama Arayüzü";
            this.raporlamaArayuzu.UseVisualStyleBackColor = false;
            this.raporlamaArayuzu.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(294, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "ANA MENÜ";
            // 
            // anaArayüz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(755, 422);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.raporlamaArayuzu);
            this.Controls.Add(this.stokArayuzu);
            this.Controls.Add(this.musteriArayuzu);
            this.Controls.Add(this.satisArayuzu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "anaArayüz";
            this.Text = "ANA MENÜ";
            this.Load += new System.EventHandler(this.anaArayüz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button satisArayuzu;
        private System.Windows.Forms.Button musteriArayuzu;
        private System.Windows.Forms.Button stokArayuzu;
        private System.Windows.Forms.Button raporlamaArayuzu;
        private System.Windows.Forms.Label label1;
    }
}