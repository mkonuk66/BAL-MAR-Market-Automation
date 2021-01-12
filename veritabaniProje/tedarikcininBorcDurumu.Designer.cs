
namespace veritabaniProje
{
    partial class tedarikcininBorcDurumu
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
            this.tedarikciGosterim = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.borcOdeme = new System.Windows.Forms.TextBox();
            this.borcOdemeButonu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tedarikciGosterim)).BeginInit();
            this.SuspendLayout();
            // 
            // tedarikciGosterim
            // 
            this.tedarikciGosterim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tedarikciGosterim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tedarikciGosterim.Location = new System.Drawing.Point(12, 47);
            this.tedarikciGosterim.Name = "tedarikciGosterim";
            this.tedarikciGosterim.RowHeadersWidth = 51;
            this.tedarikciGosterim.RowTemplate.Height = 24;
            this.tedarikciGosterim.Size = new System.Drawing.Size(553, 363);
            this.tedarikciGosterim.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tedarikci Numarası :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ödenecek Tutar : ";
            // 
            // borcOdeme
            // 
            this.borcOdeme.Location = new System.Drawing.Point(688, 132);
            this.borcOdeme.Name = "borcOdeme";
            this.borcOdeme.Size = new System.Drawing.Size(100, 22);
            this.borcOdeme.TabIndex = 9;
            // 
            // borcOdemeButonu
            // 
            this.borcOdemeButonu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.borcOdemeButonu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.borcOdemeButonu.ForeColor = System.Drawing.Color.Sienna;
            this.borcOdemeButonu.Location = new System.Drawing.Point(601, 182);
            this.borcOdemeButonu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.borcOdemeButonu.Name = "borcOdemeButonu";
            this.borcOdemeButonu.Size = new System.Drawing.Size(151, 26);
            this.borcOdemeButonu.TabIndex = 10;
            this.borcOdemeButonu.Text = "Borç Ödeme";
            this.borcOdemeButonu.UseVisualStyleBackColor = false;
            this.borcOdemeButonu.Click += new System.EventHandler(this.borcOdemeButonu_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Sienna;
            this.button1.Location = new System.Drawing.Point(684, 402);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Tamam";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tedarikcininBorcDurumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.borcOdemeButonu);
            this.Controls.Add(this.borcOdeme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tedarikciGosterim);
            this.Name = "tedarikcininBorcDurumu";
            this.Text = "tedarikcininBorcDurumu";
            this.Load += new System.EventHandler(this.tedarikcininBorcDurumu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tedarikciGosterim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tedarikciGosterim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox borcOdeme;
        private System.Windows.Forms.Button borcOdemeButonu;
        private System.Windows.Forms.Button button1;
    }
}