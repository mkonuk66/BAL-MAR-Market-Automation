
namespace veritabaniProje
{
    partial class TarihliKarZarar
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker6 = new System.Windows.Forms.DateTimePicker();
            this.satisTrendButton = new System.Windows.Forms.Button();
            this.ürünListeButton = new System.Windows.Forms.Button();
            this.karzararButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(76, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(76, 319);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(300, 186);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker3.TabIndex = 2;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(76, 185);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker4.TabIndex = 3;
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Location = new System.Drawing.Point(300, 60);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker5.TabIndex = 4;
            // 
            // dateTimePicker6
            // 
            this.dateTimePicker6.Location = new System.Drawing.Point(300, 319);
            this.dateTimePicker6.Name = "dateTimePicker6";
            this.dateTimePicker6.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker6.TabIndex = 5;
            // 
            // satisTrendButton
            // 
            this.satisTrendButton.Location = new System.Drawing.Point(550, 51);
            this.satisTrendButton.Name = "satisTrendButton";
            this.satisTrendButton.Size = new System.Drawing.Size(204, 45);
            this.satisTrendButton.TabIndex = 6;
            this.satisTrendButton.Text = "Belirli Tarih Aralığında Satış Trendi";
            this.satisTrendButton.UseVisualStyleBackColor = true;
            this.satisTrendButton.Click += new System.EventHandler(this.satisTrendButton_Click);
            // 
            // ürünListeButton
            // 
            this.ürünListeButton.Location = new System.Drawing.Point(550, 306);
            this.ürünListeButton.Name = "ürünListeButton";
            this.ürünListeButton.Size = new System.Drawing.Size(204, 52);
            this.ürünListeButton.TabIndex = 7;
            this.ürünListeButton.Text = "Belirli Tarih Aralığında Satılan Ürün Listesi";
            this.ürünListeButton.UseVisualStyleBackColor = true;
            this.ürünListeButton.Click += new System.EventHandler(this.ürünListeButton_Click);
            // 
            // karzararButton
            // 
            this.karzararButton.Location = new System.Drawing.Point(550, 176);
            this.karzararButton.Name = "karzararButton";
            this.karzararButton.Size = new System.Drawing.Size(204, 44);
            this.karzararButton.TabIndex = 8;
            this.karzararButton.Text = "Belirli Tarih Aralığında Kar-Zarar Durumu";
            this.karzararButton.UseVisualStyleBackColor = true;
            this.karzararButton.Click += new System.EventHandler(this.karzararButton_Click);
            // 
            // TarihliKarZarar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.karzararButton);
            this.Controls.Add(this.ürünListeButton);
            this.Controls.Add(this.satisTrendButton);
            this.Controls.Add(this.dateTimePicker6);
            this.Controls.Add(this.dateTimePicker5);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "TarihliKarZarar";
            this.Text = "Kar Zarar Arayüzü";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.DateTimePicker dateTimePicker6;
        private System.Windows.Forms.Button satisTrendButton;
        private System.Windows.Forms.Button ürünListeButton;
        private System.Windows.Forms.Button karzararButton;
    }
}