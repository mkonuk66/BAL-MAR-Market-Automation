
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(satisEkrani));
            this.addID = new System.Windows.Forms.TextBox();
            this.addProductButton = new System.Windows.Forms.Button();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.cashButton = new System.Windows.Forms.Button();
            this.debtButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.sifreText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.urunMiktar1 = new System.Windows.Forms.TextBox();
            this.urunMiktar = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.musArama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addID
            // 
            this.addID.Location = new System.Drawing.Point(300, 95);
            this.addID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addID.Name = "addID";
            this.addID.Size = new System.Drawing.Size(228, 22);
            this.addID.TabIndex = 1;
            this.addID.TextChanged += new System.EventHandler(this.addID_TextChanged);
            this.addID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addID_KeyPress);
            // 
            // addProductButton
            // 
            this.addProductButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addProductButton.ForeColor = System.Drawing.Color.Sienna;
            this.addProductButton.Location = new System.Drawing.Point(513, 164);
            this.addProductButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(120, 52);
            this.addProductButton.TabIndex = 3;
            this.addProductButton.Text = "Ürünü Ekle";
            this.addProductButton.UseVisualStyleBackColor = false;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deleteProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteProductButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteProductButton.ForeColor = System.Drawing.Color.Sienna;
            this.deleteProductButton.Location = new System.Drawing.Point(61, 126);
            this.deleteProductButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(123, 54);
            this.deleteProductButton.TabIndex = 4;
            this.deleteProductButton.Text = "Ürünü Sil";
            this.deleteProductButton.UseVisualStyleBackColor = false;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // cashButton
            // 
            this.cashButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cashButton.ForeColor = System.Drawing.Color.Sienna;
            this.cashButton.Location = new System.Drawing.Point(77, 468);
            this.cashButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cashButton.Name = "cashButton";
            this.cashButton.Size = new System.Drawing.Size(136, 46);
            this.cashButton.TabIndex = 5;
            this.cashButton.Text = "Peşin";
            this.cashButton.UseVisualStyleBackColor = false;
            this.cashButton.Click += new System.EventHandler(this.cashButton_Click);
            // 
            // debtButton
            // 
            this.debtButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.debtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.debtButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.debtButton.ForeColor = System.Drawing.Color.Sienna;
            this.debtButton.Location = new System.Drawing.Point(421, 468);
            this.debtButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.debtButton.Name = "debtButton";
            this.debtButton.Size = new System.Drawing.Size(128, 46);
            this.debtButton.TabIndex = 6;
            this.debtButton.Text = "Cari";
            this.debtButton.UseVisualStyleBackColor = false;
            this.debtButton.Click += new System.EventHandler(this.debtButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(73, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "BARKOD NO GİRİNİZ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(223, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "ÖDEME BİÇİMİ";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Items.AddRange(new object[] {
            "Sepet",
            "---------"});
            this.listBox1.Location = new System.Drawing.Point(659, 82);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(248, 382);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(637, 497);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tutar Toplamı :\r\n";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(875, -2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 69);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.sifreText);
            this.panel1.Controls.Add(this.deleteProductButton);
            this.panel1.Location = new System.Drawing.Point(95, 148);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 185);
            this.panel1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ürünü silmek için şifrenizi giriniz.";
            // 
            // sifreText
            // 
            this.sifreText.Location = new System.Drawing.Point(34, 64);
            this.sifreText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sifreText.Name = "sifreText";
            this.sifreText.Size = new System.Drawing.Size(176, 22);
            this.sifreText.TabIndex = 5;
            this.sifreText.TextChanged += new System.EventHandler(this.sifreText_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Hoşgeldiniz..";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // urunMiktar1
            // 
            this.urunMiktar1.Location = new System.Drawing.Point(300, 49);
            this.urunMiktar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.urunMiktar1.Name = "urunMiktar1";
            this.urunMiktar1.Size = new System.Drawing.Size(228, 22);
            this.urunMiktar1.TabIndex = 16;
            // 
            // urunMiktar
            // 
            this.urunMiktar.AutoSize = true;
            this.urunMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.urunMiktar.Location = new System.Drawing.Point(152, 50);
            this.urunMiktar.Name = "urunMiktar";
            this.urunMiktar.Size = new System.Drawing.Size(124, 20);
            this.urunMiktar.TabIndex = 17;
            this.urunMiktar.Text = "Ürün Miktarı :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(421, 352);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 43);
            this.button2.TabIndex = 18;
            this.button2.Text = "Yeni Müşteri Ekleme";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // musArama
            // 
            this.musArama.Location = new System.Drawing.Point(421, 441);
            this.musArama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.musArama.Name = "musArama";
            this.musArama.Size = new System.Drawing.Size(128, 22);
            this.musArama.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Müşteri Numarası Giriniz :\r\n";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(61, 91);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 21);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Şifreyi Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // satisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(939, 550);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.musArama);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.urunMiktar);
            this.Controls.Add(this.urunMiktar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.debtButton);
            this.Controls.Add(this.cashButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.addID);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "satisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SATIŞ EKRANI";
            this.Load += new System.EventHandler(this.satisEkrani_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox addID;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button cashButton;
        private System.Windows.Forms.Button debtButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sifreText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox urunMiktar1;
        private System.Windows.Forms.Label urunMiktar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox musArama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}