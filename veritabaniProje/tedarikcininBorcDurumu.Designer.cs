
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tedarikcininBorcDurumu));
            this.tedarikciGosterim = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.borcOdeme = new System.Windows.Forms.TextBox();
            this.borcOdemeButonu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tedarikciGosterim)).BeginInit();
            this.SuspendLayout();
            // 
            // tedarikciGosterim
            // 
            this.tedarikciGosterim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tedarikciGosterim.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.tedarikciGosterim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tedarikciGosterim.Location = new System.Drawing.Point(33, 59);
            this.tedarikciGosterim.Name = "tedarikciGosterim";
            this.tedarikciGosterim.RowHeadersWidth = 51;
            this.tedarikciGosterim.RowTemplate.Height = 24;
            this.tedarikciGosterim.Size = new System.Drawing.Size(571, 204);
            this.tedarikciGosterim.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tedarikci Numarası :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ödenecek Tutar : ";
            // 
            // borcOdeme
            // 
            this.borcOdeme.Location = new System.Drawing.Point(274, 293);
            this.borcOdeme.Name = "borcOdeme";
            this.borcOdeme.Size = new System.Drawing.Size(100, 22);
            this.borcOdeme.TabIndex = 9;
            this.borcOdeme.TextChanged += new System.EventHandler(this.borcOdeme_TextChanged);
            // 
            // borcOdemeButonu
            // 
            this.borcOdemeButonu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.borcOdemeButonu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.borcOdemeButonu.ForeColor = System.Drawing.Color.Sienna;
            this.borcOdemeButonu.Location = new System.Drawing.Point(177, 336);
            this.borcOdemeButonu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.borcOdemeButonu.Name = "borcOdemeButonu";
            this.borcOdemeButonu.Size = new System.Drawing.Size(161, 37);
            this.borcOdemeButonu.TabIndex = 10;
            this.borcOdemeButonu.Text = "Borç Ödeme";
            this.borcOdemeButonu.UseVisualStyleBackColor = false;
            this.borcOdemeButonu.Click += new System.EventHandler(this.borcOdemeButonu_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(562, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 53);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tedarikcininBorcDurumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(635, 416);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.borcOdemeButonu);
            this.Controls.Add(this.borcOdeme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tedarikciGosterim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tedarikcininBorcDurumu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button button2;
    }
}