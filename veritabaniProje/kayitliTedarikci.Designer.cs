
namespace veritabaniProje
{
    partial class kayitliTedarikci
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
            this.label2 = new System.Windows.Forms.Label();
            this.tedarikciNo = new System.Windows.Forms.TextBox();
            this.noDenetim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(2, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 59);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tedarikciye mevcut olan borçlarınızı görebilmek\r\n         için lütfen tedarikci n" +
    "umarasını giriniz.";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // tedarikciNo
            // 
            this.tedarikciNo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tedarikciNo.ForeColor = System.Drawing.SystemColors.Window;
            this.tedarikciNo.Location = new System.Drawing.Point(116, 116);
            this.tedarikciNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tedarikciNo.Multiline = true;
            this.tedarikciNo.Name = "tedarikciNo";
            this.tedarikciNo.Size = new System.Drawing.Size(236, 22);
            this.tedarikciNo.TabIndex = 4;
            this.tedarikciNo.TextChanged += new System.EventHandler(this.tedarikciNo_TextChanged);
            // 
            // noDenetim
            // 
            this.noDenetim.BackColor = System.Drawing.SystemColors.ControlLight;
            this.noDenetim.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.noDenetim.ForeColor = System.Drawing.Color.Sienna;
            this.noDenetim.Location = new System.Drawing.Point(187, 187);
            this.noDenetim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.noDenetim.Name = "noDenetim";
            this.noDenetim.Size = new System.Drawing.Size(88, 33);
            this.noDenetim.TabIndex = 5;
            this.noDenetim.Text = "Tamam";
            this.noDenetim.UseVisualStyleBackColor = false;
            this.noDenetim.Click += new System.EventHandler(this.button1_Click);
            // 
            // kayitliTedarikci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(463, 258);
            this.Controls.Add(this.noDenetim);
            this.Controls.Add(this.tedarikciNo);
            this.Controls.Add(this.label2);
            this.Name = "kayitliTedarikci";
            this.Text = "kayitliTedarikci";
            this.Load += new System.EventHandler(this.kayitliTedarikci_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tedarikciNo;
        private System.Windows.Forms.Button noDenetim;
    }
}