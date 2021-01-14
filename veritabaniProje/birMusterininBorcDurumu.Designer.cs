
namespace veritabaniProje
{
    partial class birMusterininBorcDurumu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(birMusterininBorcDurumu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.borcOdemeButonu = new System.Windows.Forms.Button();
            this.tMusterisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musteriGosterim = new System.Windows.Forms.DataGridView();
            this.veritabaniProjeDataSet1 = new veritabaniProje.veritabaniProjeDataSet1();
            this.tMusterisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tMusterisTableAdapter = new veritabaniProje.veritabaniProjeDataSet1TableAdapters.tMusterisTableAdapter();
            this.borcGosterim = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.borcOdeme = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tMusterisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriGosterim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabaniProjeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMusterisBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borcGosterim)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Numarası :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Sienna;
            this.button1.Location = new System.Drawing.Point(720, 429);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tamam";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // borcOdemeButonu
            // 
            this.borcOdemeButonu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.borcOdemeButonu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.borcOdemeButonu.ForeColor = System.Drawing.Color.Sienna;
            this.borcOdemeButonu.Location = new System.Drawing.Point(660, 365);
            this.borcOdemeButonu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.borcOdemeButonu.Name = "borcOdemeButonu";
            this.borcOdemeButonu.Size = new System.Drawing.Size(139, 31);
            this.borcOdemeButonu.TabIndex = 3;
            this.borcOdemeButonu.Text = "Borç Ödeme";
            this.borcOdemeButonu.UseVisualStyleBackColor = false;
            this.borcOdemeButonu.Click += new System.EventHandler(this.button2_Click);
            // 
            // musteriGosterim
            // 
            this.musteriGosterim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.musteriGosterim.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.musteriGosterim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.musteriGosterim.Location = new System.Drawing.Point(32, 96);
            this.musteriGosterim.Name = "musteriGosterim";
            this.musteriGosterim.RowHeadersWidth = 51;
            this.musteriGosterim.RowTemplate.Height = 24;
            this.musteriGosterim.Size = new System.Drawing.Size(794, 129);
            this.musteriGosterim.TabIndex = 4;
            this.musteriGosterim.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.musteriGosterim_CellContentClick);
            // 
            // veritabaniProjeDataSet1
            // 
            this.veritabaniProjeDataSet1.DataSetName = "veritabaniProjeDataSet1";
            this.veritabaniProjeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tMusterisBindingSource1
            // 
            this.tMusterisBindingSource1.DataMember = "tMusteris";
            this.tMusterisBindingSource1.DataSource = this.veritabaniProjeDataSet1;
            // 
            // tMusterisTableAdapter
            // 
            this.tMusterisTableAdapter.ClearBeforeFill = true;
            // 
            // borcGosterim
            // 
            this.borcGosterim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.borcGosterim.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.borcGosterim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.borcGosterim.Location = new System.Drawing.Point(32, 256);
            this.borcGosterim.Name = "borcGosterim";
            this.borcGosterim.RowHeadersWidth = 51;
            this.borcGosterim.RowTemplate.Height = 24;
            this.borcGosterim.Size = new System.Drawing.Size(559, 162);
            this.borcGosterim.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(597, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ödenecek Tutar : ";
            // 
            // borcOdeme
            // 
            this.borcOdeme.Location = new System.Drawing.Point(726, 327);
            this.borcOdeme.Name = "borcOdeme";
            this.borcOdeme.Size = new System.Drawing.Size(100, 22);
            this.borcOdeme.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(805, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 65);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // birMusterininBorcDurumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(869, 502);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.borcOdeme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.borcGosterim);
            this.Controls.Add(this.musteriGosterim);
            this.Controls.Add(this.borcOdemeButonu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "birMusterininBorcDurumu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşterinin Borç Durumu";
            this.Load += new System.EventHandler(this.birMusterininBorcDurumu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tMusterisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriGosterim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabaniProjeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMusterisBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borcGosterim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button borcOdemeButonu;
        private System.Windows.Forms.BindingSource tMusterisBindingSource;
        private System.Windows.Forms.DataGridView musteriGosterim;
        private veritabaniProjeDataSet1 veritabaniProjeDataSet1;
        private System.Windows.Forms.BindingSource tMusterisBindingSource1;
        private veritabaniProjeDataSet1TableAdapters.tMusterisTableAdapter tMusterisTableAdapter;
        private System.Windows.Forms.DataGridView borcGosterim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox borcOdeme;
        private System.Windows.Forms.Button button2;
    }
}