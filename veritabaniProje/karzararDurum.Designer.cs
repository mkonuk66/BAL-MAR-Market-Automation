
namespace veritabaniProje
{
    partial class karzararDurum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(karzararDurum));
            this.tedarikciKar = new System.Windows.Forms.DataGridView();
            this.satisKar = new System.Windows.Forms.DataGridView();
            this.hesaplama = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tedarikciBorc = new System.Windows.Forms.Label();
            this.toplamsatis = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.netKar = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tedarikciKar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisKar)).BeginInit();
            this.SuspendLayout();
            // 
            // tedarikciKar
            // 
            this.tedarikciKar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tedarikciKar.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.tedarikciKar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tedarikciKar.Location = new System.Drawing.Point(12, 12);
            this.tedarikciKar.Name = "tedarikciKar";
            this.tedarikciKar.RowHeadersWidth = 51;
            this.tedarikciKar.RowTemplate.Height = 24;
            this.tedarikciKar.Size = new System.Drawing.Size(532, 236);
            this.tedarikciKar.TabIndex = 0;
            // 
            // satisKar
            // 
            this.satisKar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.satisKar.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.satisKar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.satisKar.Location = new System.Drawing.Point(12, 268);
            this.satisKar.Name = "satisKar";
            this.satisKar.RowHeadersWidth = 51;
            this.satisKar.RowTemplate.Height = 24;
            this.satisKar.Size = new System.Drawing.Size(532, 245);
            this.satisKar.TabIndex = 1;
            // 
            // hesaplama
            // 
            this.hesaplama.FlatAppearance.BorderSize = 3;
            this.hesaplama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hesaplama.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesaplama.ForeColor = System.Drawing.Color.Sienna;
            this.hesaplama.Location = new System.Drawing.Point(610, 126);
            this.hesaplama.Name = "hesaplama";
            this.hesaplama.Size = new System.Drawing.Size(218, 60);
            this.hesaplama.TabIndex = 2;
            this.hesaplama.Text = "Kar-Zarar Durumunu Hesapla";
            this.hesaplama.UseVisualStyleBackColor = true;
            this.hesaplama.Click += new System.EventHandler(this.hesaplama_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(579, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tedarikcilere olan toplam borcunuz :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(594, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yaptığınız toplam satış Tutarı : ";
            // 
            // tedarikciBorc
            // 
            this.tedarikciBorc.AutoSize = true;
            this.tedarikciBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tedarikciBorc.Location = new System.Drawing.Point(673, 268);
            this.tedarikciBorc.Name = "tedarikciBorc";
            this.tedarikciBorc.Size = new System.Drawing.Size(0, 17);
            this.tedarikciBorc.TabIndex = 6;
            // 
            // toplamsatis
            // 
            this.toplamsatis.AutoSize = true;
            this.toplamsatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplamsatis.Location = new System.Drawing.Point(673, 356);
            this.toplamsatis.Name = "toplamsatis";
            this.toplamsatis.Size = new System.Drawing.Size(0, 17);
            this.toplamsatis.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(718, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(581, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Net Kar Miktarı : ";
            // 
            // netKar
            // 
            this.netKar.AutoSize = true;
            this.netKar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.netKar.Location = new System.Drawing.Point(700, 434);
            this.netKar.Name = "netKar";
            this.netKar.Size = new System.Drawing.Size(0, 17);
            this.netKar.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(803, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 65);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // karzararDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(876, 524);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.netKar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toplamsatis);
            this.Controls.Add(this.tedarikciBorc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hesaplama);
            this.Controls.Add(this.satisKar);
            this.Controls.Add(this.tedarikciKar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "karzararDurum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarihli Kar Zarar Durumu";
            this.Load += new System.EventHandler(this.karzararDurum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tedarikciKar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisKar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tedarikciKar;
        private System.Windows.Forms.DataGridView satisKar;
        private System.Windows.Forms.Button hesaplama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tedarikciBorc;
        private System.Windows.Forms.Label toplamsatis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label netKar;
        private System.Windows.Forms.Button button1;
    }
}