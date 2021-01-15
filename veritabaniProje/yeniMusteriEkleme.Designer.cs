
namespace veritabaniProje
{
    partial class yeniMusteriEkleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yeniMusteriEkleme));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.musteriadi = new System.Windows.Forms.TextBox();
            this.musterisoyad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.telno = new System.Windows.Forms.TextBox();
            this.kayittarihi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(87, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yeni Müşteri Kaydı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyadı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon Numarası :";
            // 
            // musteriadi
            // 
            this.musteriadi.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.musteriadi.ForeColor = System.Drawing.SystemColors.Window;
            this.musteriadi.Location = new System.Drawing.Point(208, 138);
            this.musteriadi.Name = "musteriadi";
            this.musteriadi.Size = new System.Drawing.Size(195, 22);
            this.musteriadi.TabIndex = 4;
            this.musteriadi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // musterisoyad
            // 
            this.musterisoyad.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.musterisoyad.ForeColor = System.Drawing.SystemColors.Window;
            this.musterisoyad.Location = new System.Drawing.Point(208, 195);
            this.musterisoyad.Name = "musterisoyad";
            this.musterisoyad.Size = new System.Drawing.Size(195, 22);
            this.musterisoyad.TabIndex = 5;
            this.musterisoyad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Sienna;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(522, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 73);
            this.button1.TabIndex = 7;
            this.button1.Text = "    Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // telno
            // 
            this.telno.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.telno.ForeColor = System.Drawing.SystemColors.Window;
            this.telno.Location = new System.Drawing.Point(208, 256);
            this.telno.Name = "telno";
            this.telno.Size = new System.Drawing.Size(195, 22);
            this.telno.TabIndex = 8;
            this.telno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // kayittarihi
            // 
            this.kayittarihi.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.kayittarihi.Location = new System.Drawing.Point(208, 307);
            this.kayittarihi.Name = "kayittarihi";
            this.kayittarihi.Size = new System.Drawing.Size(195, 22);
            this.kayittarihi.TabIndex = 9;
            this.kayittarihi.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Müşteri Kayıt Tarihi :";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(680, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 59);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // yeniMusteriEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(746, 387);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kayittarihi);
            this.Controls.Add(this.telno);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.musterisoyad);
            this.Controls.Add(this.musteriadi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "yeniMusteriEkleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Müşteri Kaydı";
            this.Load += new System.EventHandler(this.yeniMusteriEkleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox musteriadi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox telno;
        private System.Windows.Forms.DateTimePicker kayittarihi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox musterisoyad;
        private System.Windows.Forms.Button button2;
    }
}