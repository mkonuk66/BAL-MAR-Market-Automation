
namespace veritabaniProje
{
    partial class MusteriBorcDurum
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
            this.musteriAdSoyad = new System.Windows.Forms.Label();
            this.toplamSatis = new System.Windows.Forms.Label();
            this.toplamOdeme = new System.Windows.Forms.Label();
            this.toplamKalan = new System.Windows.Forms.Label();
            this.musteriBilgi = new System.Windows.Forms.TextBox();
            this.toplamSat = new System.Windows.Forms.TextBox();
            this.toplamKala = new System.Windows.Forms.TextBox();
            this.toplamOde = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sutunEkle = new System.Windows.Forms.Button();
            this.wordAktar = new System.Windows.Forms.Button();
            this.veriEkle = new System.Windows.Forms.Button();
            this.veriSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // musteriAdSoyad
            // 
            this.musteriAdSoyad.AutoSize = true;
            this.musteriAdSoyad.Location = new System.Drawing.Point(32, 53);
            this.musteriAdSoyad.Name = "musteriAdSoyad";
            this.musteriAdSoyad.Size = new System.Drawing.Size(152, 17);
            this.musteriAdSoyad.TabIndex = 0;
            this.musteriAdSoyad.Text = "Müşteri Adı ve Soyadı :";
            // 
            // toplamSatis
            // 
            this.toplamSatis.AutoSize = true;
            this.toplamSatis.Location = new System.Drawing.Point(33, 136);
            this.toplamSatis.Name = "toplamSatis";
            this.toplamSatis.Size = new System.Drawing.Size(102, 17);
            this.toplamSatis.TabIndex = 1;
            this.toplamSatis.Text = "Toplam Satış : ";
            // 
            // toplamOdeme
            // 
            this.toplamOdeme.AutoSize = true;
            this.toplamOdeme.Location = new System.Drawing.Point(33, 220);
            this.toplamOdeme.Name = "toplamOdeme";
            this.toplamOdeme.Size = new System.Drawing.Size(113, 17);
            this.toplamOdeme.TabIndex = 2;
            this.toplamOdeme.Text = "Toplam Ödeme :";
            // 
            // toplamKalan
            // 
            this.toplamKalan.AutoSize = true;
            this.toplamKalan.Location = new System.Drawing.Point(33, 318);
            this.toplamKalan.Name = "toplamKalan";
            this.toplamKalan.Size = new System.Drawing.Size(103, 17);
            this.toplamKalan.TabIndex = 3;
            this.toplamKalan.Text = "Toplam Kalan :";
            // 
            // musteriBilgi
            // 
            this.musteriBilgi.Location = new System.Drawing.Point(202, 53);
            this.musteriBilgi.Name = "musteriBilgi";
            this.musteriBilgi.Size = new System.Drawing.Size(151, 22);
            this.musteriBilgi.TabIndex = 4;
            // 
            // toplamSat
            // 
            this.toplamSat.Location = new System.Drawing.Point(202, 136);
            this.toplamSat.Name = "toplamSat";
            this.toplamSat.Size = new System.Drawing.Size(151, 22);
            this.toplamSat.TabIndex = 5;
            // 
            // toplamKala
            // 
            this.toplamKala.Location = new System.Drawing.Point(202, 318);
            this.toplamKala.Name = "toplamKala";
            this.toplamKala.Size = new System.Drawing.Size(151, 22);
            this.toplamKala.TabIndex = 6;
            // 
            // toplamOde
            // 
            this.toplamOde.Location = new System.Drawing.Point(202, 220);
            this.toplamOde.Name = "toplamOde";
            this.toplamOde.Size = new System.Drawing.Size(151, 22);
            this.toplamOde.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(436, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(311, 185);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sutunEkle
            // 
            this.sutunEkle.Location = new System.Drawing.Point(446, 243);
            this.sutunEkle.Name = "sutunEkle";
            this.sutunEkle.Size = new System.Drawing.Size(124, 55);
            this.sutunEkle.TabIndex = 9;
            this.sutunEkle.Text = "Sutün Ekle";
            this.sutunEkle.UseVisualStyleBackColor = true;
            this.sutunEkle.Click += new System.EventHandler(this.sutunEkle_Click);
            // 
            // wordAktar
            // 
            this.wordAktar.Location = new System.Drawing.Point(610, 318);
            this.wordAktar.Name = "wordAktar";
            this.wordAktar.Size = new System.Drawing.Size(125, 57);
            this.wordAktar.TabIndex = 10;
            this.wordAktar.Text = "Worde Aktar";
            this.wordAktar.UseVisualStyleBackColor = true;
            this.wordAktar.Click += new System.EventHandler(this.wordAktar_Click);
            // 
            // veriEkle
            // 
            this.veriEkle.Location = new System.Drawing.Point(610, 243);
            this.veriEkle.Name = "veriEkle";
            this.veriEkle.Size = new System.Drawing.Size(125, 55);
            this.veriEkle.TabIndex = 11;
            this.veriEkle.Text = "Veri Ekle";
            this.veriEkle.UseVisualStyleBackColor = true;
            this.veriEkle.Click += new System.EventHandler(this.veriEkle_Click);
            // 
            // veriSil
            // 
            this.veriSil.Location = new System.Drawing.Point(446, 318);
            this.veriSil.Name = "veriSil";
            this.veriSil.Size = new System.Drawing.Size(124, 57);
            this.veriSil.TabIndex = 12;
            this.veriSil.Text = "Veri Sil";
            this.veriSil.UseVisualStyleBackColor = true;
            this.veriSil.Click += new System.EventHandler(this.veriSil_Click);
            // 
            // MusteriBorcDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.veriSil);
            this.Controls.Add(this.veriEkle);
            this.Controls.Add(this.wordAktar);
            this.Controls.Add(this.sutunEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toplamOde);
            this.Controls.Add(this.toplamKala);
            this.Controls.Add(this.toplamSat);
            this.Controls.Add(this.musteriBilgi);
            this.Controls.Add(this.toplamKalan);
            this.Controls.Add(this.toplamOdeme);
            this.Controls.Add(this.toplamSatis);
            this.Controls.Add(this.musteriAdSoyad);
            this.Name = "MusteriBorcDurum";
            this.Text = "Müşteri Borç Durumu";
            this.Load += new System.EventHandler(this.MusteriBorcDurum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label musteriAdSoyad;
        private System.Windows.Forms.Label toplamSatis;
        private System.Windows.Forms.Label toplamOdeme;
        private System.Windows.Forms.Label toplamKalan;
        private System.Windows.Forms.TextBox musteriBilgi;
        private System.Windows.Forms.TextBox toplamSat;
        private System.Windows.Forms.TextBox toplamKala;
        private System.Windows.Forms.TextBox toplamOde;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button sutunEkle;
        private System.Windows.Forms.Button wordAktar;
        private System.Windows.Forms.Button veriEkle;
        private System.Windows.Forms.Button veriSil;
    }
}