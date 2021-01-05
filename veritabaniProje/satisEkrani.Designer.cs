
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
            this.addID = new System.Windows.Forms.TextBox();
            this.showIDText = new System.Windows.Forms.RichTextBox();
            this.addProductButton = new System.Windows.Forms.Button();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.cashButton = new System.Windows.Forms.Button();
            this.debtButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addID
            // 
            this.addID.Location = new System.Drawing.Point(249, 57);
            this.addID.Name = "addID";
            this.addID.Size = new System.Drawing.Size(196, 22);
            this.addID.TabIndex = 1;
            this.addID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addID_KeyPress);
            // 
            // showIDText
            // 
            this.showIDText.Location = new System.Drawing.Point(568, 84);
            this.showIDText.Name = "showIDText";
            this.showIDText.Size = new System.Drawing.Size(175, 287);
            this.showIDText.TabIndex = 2;
            this.showIDText.Text = "";
            this.showIDText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.showIDText_KeyPress);
            // 
            // addProductButton
            // 
            this.addProductButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addProductButton.ForeColor = System.Drawing.Color.Sienna;
            this.addProductButton.Location = new System.Drawing.Point(81, 136);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(122, 53);
            this.addProductButton.TabIndex = 3;
            this.addProductButton.Text = "Ürünü Ekle";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteProductButton.ForeColor = System.Drawing.Color.Sienna;
            this.deleteProductButton.Location = new System.Drawing.Point(314, 135);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(122, 54);
            this.deleteProductButton.TabIndex = 4;
            this.deleteProductButton.Text = "Ürünü Sil";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // cashButton
            // 
            this.cashButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cashButton.ForeColor = System.Drawing.Color.Sienna;
            this.cashButton.Location = new System.Drawing.Point(81, 363);
            this.cashButton.Name = "cashButton";
            this.cashButton.Size = new System.Drawing.Size(139, 47);
            this.cashButton.TabIndex = 5;
            this.cashButton.Text = "Peşin";
            this.cashButton.UseVisualStyleBackColor = true;
            this.cashButton.Click += new System.EventHandler(this.cashButton_Click);
            // 
            // debtButton
            // 
            this.debtButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.debtButton.ForeColor = System.Drawing.Color.Sienna;
            this.debtButton.Location = new System.Drawing.Point(314, 363);
            this.debtButton.Name = "debtButton";
            this.debtButton.Size = new System.Drawing.Size(131, 47);
            this.debtButton.TabIndex = 6;
            this.debtButton.Text = "Cari";
            this.debtButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "BARKOD NO GİRİNİZ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(183, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "ÖDEME BİÇİMİ";
            // 
            // satisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.debtButton);
            this.Controls.Add(this.cashButton);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.showIDText);
            this.Controls.Add(this.addID);
            this.Name = "satisEkrani";
            this.Text = "SATIŞ EKRANI";
            this.Load += new System.EventHandler(this.satisEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox addID;
        private System.Windows.Forms.RichTextBox showIDText;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button cashButton;
        private System.Windows.Forms.Button debtButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}