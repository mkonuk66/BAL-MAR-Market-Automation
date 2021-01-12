
namespace veritabaniProje
{
    partial class tedarikciBorc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tedarikciGosterim = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.borcOdeme = new System.Windows.Forms.TextBox();
            this.borcOdemeButonu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tedarikciGosterim)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(127, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tedarikçi No : ";
            // 
            // tedarikciGosterim
            // 
            this.tedarikciGosterim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tedarikciGosterim.Location = new System.Drawing.Point(16, 55);
            this.tedarikciGosterim.Name = "tedarikciGosterim";
            this.tedarikciGosterim.RowHeadersWidth = 51;
            this.tedarikciGosterim.RowTemplate.Height = 24;
            this.tedarikciGosterim.Size = new System.Drawing.Size(539, 358);
            this.tedarikciGosterim.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(559, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ödenecek Tutar : ";
            // 
            // borcOdeme
            // 
            this.borcOdeme.Location = new System.Drawing.Point(688, 161);
            this.borcOdeme.Name = "borcOdeme";
            this.borcOdeme.Size = new System.Drawing.Size(100, 22);
            this.borcOdeme.TabIndex = 8;
            // 
            // borcOdemeButonu
            // 
            this.borcOdemeButonu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.borcOdemeButonu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.borcOdemeButonu.ForeColor = System.Drawing.Color.Sienna;
            this.borcOdemeButonu.Location = new System.Drawing.Point(607, 204);
            this.borcOdemeButonu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.borcOdemeButonu.Name = "borcOdemeButonu";
            this.borcOdemeButonu.Size = new System.Drawing.Size(151, 26);
            this.borcOdemeButonu.TabIndex = 9;
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
            this.button1.TabIndex = 10;
            this.button1.Text = "Tamam";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tedarikciBorc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.borcOdemeButonu);
            this.Controls.Add(this.borcOdeme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tedarikciGosterim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "tedarikciBorc";
            this.Text = "tedarikciBorc";
            this.Load += new System.EventHandler(this.tedarikciBorc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tedarikciGosterim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tedarikciGosterim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox borcOdeme;
        private System.Windows.Forms.Button borcOdemeButonu;
        private System.Windows.Forms.Button button1;
    }
}