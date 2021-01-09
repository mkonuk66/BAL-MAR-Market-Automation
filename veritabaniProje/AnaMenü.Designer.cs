
namespace veritabaniProje
{
    partial class AnaMenü
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaMenü));
            this.panel1 = new System.Windows.Forms.Panel();
            this.anamenubuton = new System.Windows.Forms.Button();
            this.raporbuton = new System.Windows.Forms.Button();
            this.stokbuton = new System.Windows.Forms.Button();
            this.musteributon = new System.Windows.Forms.Button();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kapatmabutonu = new System.Windows.Forms.Button();
            this.tarih = new System.Windows.Forms.Label();
            this.saat = new System.Windows.Forms.Label();
            this.tarih_saat_bilgi = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.stokIslemleri1 = new veritabaniProje.StokIslemleri();
            this.raporAlim1 = new veritabaniProje.RaporAlim();
            this.satisİslemleri1 = new veritabaniProje.Satisİslemleri();
            this.musteriMenu1 = new veritabaniProje.MusteriMenu();
            this.anaMenu1 = new veritabaniProje.AnaMenu();
            this.satisButon = new System.Windows.Forms.Button();
            this.borcButon = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.borcButon);
            this.panel1.Controls.Add(this.satisButon);
            this.panel1.Controls.Add(this.anamenubuton);
            this.panel1.Controls.Add(this.raporbuton);
            this.panel1.Controls.Add(this.stokbuton);
            this.panel1.Controls.Add(this.musteributon);
            this.panel1.Controls.Add(this.sidepanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 558);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // anamenubuton
            // 
            this.anamenubuton.FlatAppearance.BorderSize = 0;
            this.anamenubuton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anamenubuton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anamenubuton.Image = ((System.Drawing.Image)(resources.GetObject("anamenubuton.Image")));
            this.anamenubuton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.anamenubuton.Location = new System.Drawing.Point(12, 87);
            this.anamenubuton.Name = "anamenubuton";
            this.anamenubuton.Size = new System.Drawing.Size(190, 61);
            this.anamenubuton.TabIndex = 7;
            this.anamenubuton.Text = " Ana Menü";
            this.anamenubuton.UseVisualStyleBackColor = true;
            this.anamenubuton.Click += new System.EventHandler(this.anamenubuton_Click);
            // 
            // raporbuton
            // 
            this.raporbuton.FlatAppearance.BorderSize = 0;
            this.raporbuton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raporbuton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.raporbuton.Image = ((System.Drawing.Image)(resources.GetObject("raporbuton.Image")));
            this.raporbuton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.raporbuton.Location = new System.Drawing.Point(12, 347);
            this.raporbuton.Name = "raporbuton";
            this.raporbuton.Size = new System.Drawing.Size(189, 61);
            this.raporbuton.TabIndex = 6;
            this.raporbuton.Text = " Rapor Alım";
            this.raporbuton.UseVisualStyleBackColor = true;
            this.raporbuton.Click += new System.EventHandler(this.raporbuton_Click);
            // 
            // stokbuton
            // 
            this.stokbuton.FlatAppearance.BorderSize = 0;
            this.stokbuton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stokbuton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokbuton.Image = ((System.Drawing.Image)(resources.GetObject("stokbuton.Image")));
            this.stokbuton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stokbuton.Location = new System.Drawing.Point(12, 282);
            this.stokbuton.Name = "stokbuton";
            this.stokbuton.Size = new System.Drawing.Size(189, 61);
            this.stokbuton.TabIndex = 5;
            this.stokbuton.Text = "   Stok İşlemleri";
            this.stokbuton.UseVisualStyleBackColor = true;
            this.stokbuton.Click += new System.EventHandler(this.stokbuton_Click);
            // 
            // musteributon
            // 
            this.musteributon.FlatAppearance.BorderSize = 0;
            this.musteributon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musteributon.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteributon.Image = ((System.Drawing.Image)(resources.GetObject("musteributon.Image")));
            this.musteributon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.musteributon.Location = new System.Drawing.Point(12, 217);
            this.musteributon.Name = "musteributon";
            this.musteributon.Size = new System.Drawing.Size(189, 61);
            this.musteributon.TabIndex = 4;
            this.musteributon.Text = "       Müşteri İşlemleri";
            this.musteributon.UseVisualStyleBackColor = true;
            this.musteributon.Click += new System.EventHandler(this.musteributon_Click);
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.OrangeRed;
            this.sidepanel.Location = new System.Drawing.Point(1, 87);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(10, 61);
            this.sidepanel.TabIndex = 3;
            this.sidepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(202, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(890, 19);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OrangeRed;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(230, 0);
            this.panel3.Name = "panel3";
            this.panel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel3.Size = new System.Drawing.Size(122, 148);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Balıkesirin Marketi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "BALMAR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // kapatmabutonu
            // 
            this.kapatmabutonu.FlatAppearance.BorderSize = 0;
            this.kapatmabutonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kapatmabutonu.Image = ((System.Drawing.Image)(resources.GetObject("kapatmabutonu.Image")));
            this.kapatmabutonu.Location = new System.Drawing.Point(1043, 20);
            this.kapatmabutonu.Name = "kapatmabutonu";
            this.kapatmabutonu.Size = new System.Drawing.Size(49, 50);
            this.kapatmabutonu.TabIndex = 3;
            this.kapatmabutonu.UseVisualStyleBackColor = true;
            this.kapatmabutonu.Click += new System.EventHandler(this.kapatmabutonu_Click);
            // 
            // tarih
            // 
            this.tarih.AutoSize = true;
            this.tarih.Location = new System.Drawing.Point(779, 34);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(49, 17);
            this.tarih.TabIndex = 6;
            this.tarih.Text = "Tarih :";
            // 
            // saat
            // 
            this.saat.AutoSize = true;
            this.saat.Location = new System.Drawing.Point(858, 34);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(45, 17);
            this.saat.TabIndex = 7;
            this.saat.Text = "Saat :";
            // 
            // tarih_saat_bilgi
            // 
            this.tarih_saat_bilgi.AutoSize = true;
            this.tarih_saat_bilgi.Location = new System.Drawing.Point(779, 63);
            this.tarih_saat_bilgi.Name = "tarih_saat_bilgi";
            this.tarih_saat_bilgi.Size = new System.Drawing.Size(46, 17);
            this.tarih_saat_bilgi.TabIndex = 8;
            this.tarih_saat_bilgi.Text = "label5";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "label3";
            // 
            // stokIslemleri1
            // 
            this.stokIslemleri1.Location = new System.Drawing.Point(202, 155);
            this.stokIslemleri1.Name = "stokIslemleri1";
            this.stokIslemleri1.Size = new System.Drawing.Size(890, 403);
            this.stokIslemleri1.TabIndex = 14;
            // 
            // raporAlim1
            // 
            this.raporAlim1.Location = new System.Drawing.Point(202, 155);
            this.raporAlim1.Name = "raporAlim1";
            this.raporAlim1.Size = new System.Drawing.Size(890, 403);
            this.raporAlim1.TabIndex = 13;
            // 
            // satisİslemleri1
            // 
            this.satisİslemleri1.Location = new System.Drawing.Point(202, 155);
            this.satisİslemleri1.Name = "satisİslemleri1";
            this.satisİslemleri1.Size = new System.Drawing.Size(890, 403);
            this.satisİslemleri1.TabIndex = 11;
            // 
            // musteriMenu1
            // 
            this.musteriMenu1.Location = new System.Drawing.Point(202, 152);
            this.musteriMenu1.Name = "musteriMenu1";
            this.musteriMenu1.Size = new System.Drawing.Size(890, 406);
            this.musteriMenu1.TabIndex = 10;
            // 
            // anaMenu1
            // 
            this.anaMenu1.Location = new System.Drawing.Point(202, 143);
            this.anaMenu1.Name = "anaMenu1";
            this.anaMenu1.Size = new System.Drawing.Size(890, 412);
            this.anaMenu1.TabIndex = 9;
            // 
            // satisButon
            // 
            this.satisButon.FlatAppearance.BorderSize = 0;
            this.satisButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.satisButon.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satisButon.Image = ((System.Drawing.Image)(resources.GetObject("satisButon.Image")));
            this.satisButon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.satisButon.Location = new System.Drawing.Point(7, 155);
            this.satisButon.Name = "satisButon";
            this.satisButon.Size = new System.Drawing.Size(189, 61);
            this.satisButon.TabIndex = 8;
            this.satisButon.Text = "    Satış İşlemleri";
            this.satisButon.UseVisualStyleBackColor = true;
            this.satisButon.Click += new System.EventHandler(this.satisButon_Click);
            // 
            // borcButon
            // 
            this.borcButon.FlatAppearance.BorderSize = 0;
            this.borcButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borcButon.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.borcButon.Image = ((System.Drawing.Image)(resources.GetObject("borcButon.Image")));
            this.borcButon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.borcButon.Location = new System.Drawing.Point(13, 404);
            this.borcButon.Name = "borcButon";
            this.borcButon.Size = new System.Drawing.Size(189, 61);
            this.borcButon.TabIndex = 9;
            this.borcButon.Text = "       Borç İşlemleri";
            this.borcButon.UseVisualStyleBackColor = true;
            this.borcButon.Click += new System.EventHandler(this.borcButon_Click);
            // 
            // AnaMenü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 558);
            this.Controls.Add(this.stokIslemleri1);
            this.Controls.Add(this.raporAlim1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.satisİslemleri1);
            this.Controls.Add(this.musteriMenu1);
            this.Controls.Add(this.anaMenu1);
            this.Controls.Add(this.tarih_saat_bilgi);
            this.Controls.Add(this.saat);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.kapatmabutonu);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnaMenü";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaMenü";
            this.Load += new System.EventHandler(this.AnaMenü_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button anamenubuton;
        private System.Windows.Forms.Button raporbuton;
        private System.Windows.Forms.Button stokbuton;
        private System.Windows.Forms.Button musteributon;
        private System.Windows.Forms.Button kapatmabutonu;
        private System.Windows.Forms.Label tarih;
        private System.Windows.Forms.Label saat;
        private System.Windows.Forms.Label tarih_saat_bilgi;
        private System.Windows.Forms.Timer timer1;
        private AnaMenu anaMenu1;
        private MusteriMenu musteriMenu1;
        private Satisİslemleri satisİslemleri1;
        private System.Windows.Forms.Label label3;
        private RaporAlim raporAlim1;
        private StokIslemleri stokIslemleri1;
        private System.Windows.Forms.Button borcButon;
        private System.Windows.Forms.Button satisButon;
    }
}