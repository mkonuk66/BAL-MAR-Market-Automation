
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TarihliKarZarar));
            this.trend = new System.Windows.Forms.DateTimePicker();
            this.karzarar2 = new System.Windows.Forms.DateTimePicker();
            this.karzarar1 = new System.Windows.Forms.DateTimePicker();
            this.trend3 = new System.Windows.Forms.DateTimePicker();
            this.satisTrendButton = new System.Windows.Forms.Button();
            this.karzararButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trend
            // 
            this.trend.Location = new System.Drawing.Point(53, 88);
            this.trend.Name = "trend";
            this.trend.Size = new System.Drawing.Size(200, 22);
            this.trend.TabIndex = 0;
            // 
            // karzarar2
            // 
            this.karzarar2.Location = new System.Drawing.Point(271, 226);
            this.karzarar2.Name = "karzarar2";
            this.karzarar2.Size = new System.Drawing.Size(200, 22);
            this.karzarar2.TabIndex = 2;
            // 
            // karzarar1
            // 
            this.karzarar1.Location = new System.Drawing.Point(53, 226);
            this.karzarar1.Name = "karzarar1";
            this.karzarar1.Size = new System.Drawing.Size(200, 22);
            this.karzarar1.TabIndex = 3;
            this.karzarar1.ValueChanged += new System.EventHandler(this.dateTimePicker4_ValueChanged);
            // 
            // trend3
            // 
            this.trend3.Location = new System.Drawing.Point(271, 88);
            this.trend3.Name = "trend3";
            this.trend3.Size = new System.Drawing.Size(200, 22);
            this.trend3.TabIndex = 4;
            // 
            // satisTrendButton
            // 
            this.satisTrendButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.satisTrendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.satisTrendButton.FlatAppearance.BorderSize = 2;
            this.satisTrendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.satisTrendButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satisTrendButton.ForeColor = System.Drawing.Color.Sienna;
            this.satisTrendButton.Location = new System.Drawing.Point(494, 76);
            this.satisTrendButton.Name = "satisTrendButton";
            this.satisTrendButton.Size = new System.Drawing.Size(204, 62);
            this.satisTrendButton.TabIndex = 6;
            this.satisTrendButton.Text = "Belirli Tarih Aralığında Satış Trendi";
            this.satisTrendButton.UseVisualStyleBackColor = false;
            this.satisTrendButton.Click += new System.EventHandler(this.satisTrendButton_Click);
            // 
            // karzararButton
            // 
            this.karzararButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.karzararButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.karzararButton.FlatAppearance.BorderSize = 2;
            this.karzararButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.karzararButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.karzararButton.ForeColor = System.Drawing.Color.Sienna;
            this.karzararButton.Location = new System.Drawing.Point(494, 208);
            this.karzararButton.Name = "karzararButton";
            this.karzararButton.Size = new System.Drawing.Size(204, 58);
            this.karzararButton.TabIndex = 8;
            this.karzararButton.Text = "Belirli Tarih Aralığında Kar-Zarar Durumu";
            this.karzararButton.UseVisualStyleBackColor = false;
            this.karzararButton.Click += new System.EventHandler(this.karzararButton_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(673, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 58);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TarihliKarZarar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(734, 319);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.karzararButton);
            this.Controls.Add(this.satisTrendButton);
            this.Controls.Add(this.trend3);
            this.Controls.Add(this.karzarar1);
            this.Controls.Add(this.karzarar2);
            this.Controls.Add(this.trend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TarihliKarZarar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kar Zarar Arayüzü";
            this.Load += new System.EventHandler(this.TarihliKarZarar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker trend;
        private System.Windows.Forms.DateTimePicker karzarar2;
        private System.Windows.Forms.DateTimePicker karzarar1;
        private System.Windows.Forms.DateTimePicker trend3;
        private System.Windows.Forms.Button satisTrendButton;
        private System.Windows.Forms.Button karzararButton;
        private System.Windows.Forms.Button button1;
    }
}