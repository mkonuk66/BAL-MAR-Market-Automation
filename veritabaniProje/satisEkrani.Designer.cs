
namespace veritabaniProje
{
    partial class satisEkrani
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addProductButton = new System.Windows.Forms.Button();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cashButton = new System.Windows.Forms.Button();
            this.debtButton = new System.Windows.Forms.Button();
            this.addID = new System.Windows.Forms.TextBox();
            this.showIDText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(28, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(180, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "ÜRÜN BARKOD NO GİRİNİZ";
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(69, 124);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(115, 33);
            this.addProductButton.TabIndex = 2;
            this.addProductButton.Text = "Ürün Ekle";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Location = new System.Drawing.Point(268, 124);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(115, 33);
            this.deleteProductButton.TabIndex = 3;
            this.deleteProductButton.Text = "Ürün Sil";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(110, 261);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(236, 22);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "ÖDEMENİZİ NASIL YAPACAKSINIZ ?";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // cashButton
            // 
            this.cashButton.Location = new System.Drawing.Point(83, 332);
            this.cashButton.Name = "cashButton";
            this.cashButton.Size = new System.Drawing.Size(101, 53);
            this.cashButton.TabIndex = 5;
            this.cashButton.Text = "Peşin";
            this.cashButton.UseVisualStyleBackColor = true;
            this.cashButton.Click += new System.EventHandler(this.cashButton_Click);
            // 
            // debtButton
            // 
            this.debtButton.Location = new System.Drawing.Point(278, 332);
            this.debtButton.Name = "debtButton";
            this.debtButton.Size = new System.Drawing.Size(105, 53);
            this.debtButton.TabIndex = 6;
            this.debtButton.Text = "Cari";
            this.debtButton.UseVisualStyleBackColor = true;
            this.debtButton.Click += new System.EventHandler(this.debtButton_Click);
            // 
            // addID
            // 
            this.addID.Location = new System.Drawing.Point(268, 42);
            this.addID.Name = "addID";
            this.addID.Size = new System.Drawing.Size(154, 22);
            this.addID.TabIndex = 8;
            this.addID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addID_KeyPress);
            // 
            // showIDText
            // 
            this.showIDText.Location = new System.Drawing.Point(521, 42);
            this.showIDText.Name = "showIDText";
            this.showIDText.Size = new System.Drawing.Size(184, 379);
            this.showIDText.TabIndex = 9;
            this.showIDText.Text = "";
            this.showIDText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.showIDText_KeyPress);
            // 
            // satisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showIDText);
            this.Controls.Add(this.addID);
            this.Controls.Add(this.debtButton);
            this.Controls.Add(this.cashButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.textBox1);
            this.Name = "satisEkrani";
            this.Text = "Satış Ekran";
            this.Load += new System.EventHandler(this.satisEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button cashButton;
        private System.Windows.Forms.Button debtButton;
        private System.Windows.Forms.TextBox addID;
        private System.Windows.Forms.RichTextBox showIDText;
    }
}