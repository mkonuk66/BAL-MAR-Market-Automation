
namespace veritabaniProje
{
    partial class satisMusteri
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
            this.button1 = new System.Windows.Forms.Button();
            this.musteriIdsatis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(95, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Numarası Giriniz:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "TAMAM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // musteriIdsatis
            // 
            this.musteriIdsatis.Location = new System.Drawing.Point(99, 82);
            this.musteriIdsatis.Name = "musteriIdsatis";
            this.musteriIdsatis.Size = new System.Drawing.Size(180, 20);
            this.musteriIdsatis.TabIndex = 2;
            this.musteriIdsatis.TextChanged += new System.EventHandler(this.musteriIdsatis_TextChanged);
            // 
            // satisMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 173);
            this.Controls.Add(this.musteriIdsatis);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "satisMusteri";
            this.Text = "satisMusteri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox musteriIdsatis;
    }
}