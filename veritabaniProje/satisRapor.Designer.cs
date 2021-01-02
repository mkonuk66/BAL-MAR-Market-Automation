
namespace veritabaniProje
{
    partial class satisRapor
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
            this.musteriıd = new System.Windows.Forms.Label();
            this.toplamtu = new System.Windows.Forms.Label();
            this.toplamsat = new System.Windows.Forms.Label();
            this.urunad = new System.Windows.Forms.Label();
            this.musteriNumber = new System.Windows.Forms.TextBox();
            this.toplamTutar = new System.Windows.Forms.TextBox();
            this.urunAdi = new System.Windows.Forms.TextBox();
            this.satisMiktari = new System.Windows.Forms.TextBox();
            this.satisListe = new System.Windows.Forms.DataGridView();
            this.sutunEkle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.veriSil = new System.Windows.Forms.Button();
            this.veriEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.satisListe)).BeginInit();
            this.SuspendLayout();
            // 
            // musteriıd
            // 
            this.musteriıd.AutoSize = true;
            this.musteriıd.Location = new System.Drawing.Point(46, 37);
            this.musteriıd.Name = "musteriıd";
            this.musteriıd.Size = new System.Drawing.Size(79, 17);
            this.musteriıd.TabIndex = 0;
            this.musteriıd.Text = "Müşteri ID :";
            // 
            // toplamtu
            // 
            this.toplamtu.AutoSize = true;
            this.toplamtu.Location = new System.Drawing.Point(46, 181);
            this.toplamtu.Name = "toplamtu";
            this.toplamtu.Size = new System.Drawing.Size(105, 17);
            this.toplamtu.TabIndex = 1;
            this.toplamtu.Text = "Toplam Tutar : ";
            // 
            // toplamsat
            // 
            this.toplamsat.AutoSize = true;
            this.toplamsat.Location = new System.Drawing.Point(46, 135);
            this.toplamsat.Name = "toplamsat";
            this.toplamsat.Size = new System.Drawing.Size(143, 17);
            this.toplamsat.TabIndex = 2;
            this.toplamsat.Text = "Toplam Satış Miktarı :";
            // 
            // urunad
            // 
            this.urunad.AutoSize = true;
            this.urunad.Location = new System.Drawing.Point(46, 83);
            this.urunad.Name = "urunad";
            this.urunad.Size = new System.Drawing.Size(71, 17);
            this.urunad.TabIndex = 3;
            this.urunad.Text = "Ürün Adı :";
            // 
            // musteriNumber
            // 
            this.musteriNumber.Location = new System.Drawing.Point(195, 37);
            this.musteriNumber.Name = "musteriNumber";
            this.musteriNumber.Size = new System.Drawing.Size(135, 22);
            this.musteriNumber.TabIndex = 4;
            // 
            // toplamTutar
            // 
            this.toplamTutar.Location = new System.Drawing.Point(195, 181);
            this.toplamTutar.Name = "toplamTutar";
            this.toplamTutar.Size = new System.Drawing.Size(135, 22);
            this.toplamTutar.TabIndex = 5;
            // 
            // urunAdi
            // 
            this.urunAdi.Location = new System.Drawing.Point(195, 83);
            this.urunAdi.Name = "urunAdi";
            this.urunAdi.Size = new System.Drawing.Size(135, 22);
            this.urunAdi.TabIndex = 6;
            this.urunAdi.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // satisMiktari
            // 
            this.satisMiktari.Location = new System.Drawing.Point(195, 135);
            this.satisMiktari.Name = "satisMiktari";
            this.satisMiktari.Size = new System.Drawing.Size(135, 22);
            this.satisMiktari.TabIndex = 7;
            // 
            // satisListe
            // 
            this.satisListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.satisListe.Location = new System.Drawing.Point(349, 37);
            this.satisListe.Name = "satisListe";
            this.satisListe.RowHeadersWidth = 51;
            this.satisListe.RowTemplate.Height = 24;
            this.satisListe.Size = new System.Drawing.Size(335, 320);
            this.satisListe.TabIndex = 8;
            this.satisListe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sutunEkle
            // 
            this.sutunEkle.Location = new System.Drawing.Point(195, 227);
            this.sutunEkle.Name = "sutunEkle";
            this.sutunEkle.Size = new System.Drawing.Size(125, 57);
            this.sutunEkle.TabIndex = 9;
            this.sutunEkle.Text = "Sutün Ekle";
            this.sutunEkle.UseVisualStyleBackColor = true;
            this.sutunEkle.Click += new System.EventHandler(this.sutunEkle_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(49, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 57);
            this.button2.TabIndex = 10;
            this.button2.Text = "Müşteri Bulmak İçin Tıkla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // veriSil
            // 
            this.veriSil.Location = new System.Drawing.Point(195, 300);
            this.veriSil.Name = "veriSil";
            this.veriSil.Size = new System.Drawing.Size(125, 57);
            this.veriSil.TabIndex = 11;
            this.veriSil.Text = "Veri Sil";
            this.veriSil.UseVisualStyleBackColor = true;
            this.veriSil.Click += new System.EventHandler(this.veriSil_Click);
            // 
            // veriEkle
            // 
            this.veriEkle.Location = new System.Drawing.Point(49, 300);
            this.veriEkle.Name = "veriEkle";
            this.veriEkle.Size = new System.Drawing.Size(130, 57);
            this.veriEkle.TabIndex = 12;
            this.veriEkle.Text = "Veri Ekle";
            this.veriEkle.UseVisualStyleBackColor = true;
            this.veriEkle.Click += new System.EventHandler(this.veriEkle_Click);
            // 
            // satisRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 386);
            this.Controls.Add(this.veriEkle);
            this.Controls.Add(this.veriSil);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sutunEkle);
            this.Controls.Add(this.satisListe);
            this.Controls.Add(this.satisMiktari);
            this.Controls.Add(this.urunAdi);
            this.Controls.Add(this.toplamTutar);
            this.Controls.Add(this.musteriNumber);
            this.Controls.Add(this.urunad);
            this.Controls.Add(this.toplamsat);
            this.Controls.Add(this.toplamtu);
            this.Controls.Add(this.musteriıd);
            this.Name = "satisRapor";
            this.Text = "Satış Raporu";
            ((System.ComponentModel.ISupportInitialize)(this.satisListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label musteriıd;
        private System.Windows.Forms.Label toplamtu;
        private System.Windows.Forms.Label toplamsat;
        private System.Windows.Forms.Label urunad;
        private System.Windows.Forms.TextBox musteriNumber;
        private System.Windows.Forms.TextBox toplamTutar;
        private System.Windows.Forms.TextBox urunAdi;
        private System.Windows.Forms.TextBox satisMiktari;
        private System.Windows.Forms.DataGridView satisListe;
        private System.Windows.Forms.Button sutunEkle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button veriSil;
        private System.Windows.Forms.Button veriEkle;
    }
}