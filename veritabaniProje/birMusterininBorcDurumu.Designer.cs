
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
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Numarası :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 14);
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
            this.button1.Location = new System.Drawing.Point(684, 402);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 37);
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
            this.borcOdemeButonu.Location = new System.Drawing.Point(626, 241);
            this.borcOdemeButonu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.borcOdemeButonu.Name = "borcOdemeButonu";
            this.borcOdemeButonu.Size = new System.Drawing.Size(151, 26);
            this.borcOdemeButonu.TabIndex = 3;
            this.borcOdemeButonu.Text = "Borç Ödeme";
            this.borcOdemeButonu.UseVisualStyleBackColor = false;
            this.borcOdemeButonu.Click += new System.EventHandler(this.button2_Click);
            // 
            // tMusterisBindingSource
            // 
            this.tMusterisBindingSource.CurrentChanged += new System.EventHandler(this.tMusterisBindingSource_CurrentChanged);
            // 
            // musteriGosterim
            // 
            this.musteriGosterim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.musteriGosterim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.musteriGosterim.Location = new System.Drawing.Point(16, 60);
            this.musteriGosterim.Name = "musteriGosterim";
            this.musteriGosterim.RowHeadersWidth = 51;
            this.musteriGosterim.RowTemplate.Height = 24;
            this.musteriGosterim.Size = new System.Drawing.Size(772, 129);
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
            this.borcGosterim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.borcGosterim.Location = new System.Drawing.Point(16, 224);
            this.borcGosterim.Name = "borcGosterim";
            this.borcGosterim.RowHeadersWidth = 51;
            this.borcGosterim.RowTemplate.Height = 24;
            this.borcGosterim.Size = new System.Drawing.Size(336, 139);
            this.borcGosterim.TabIndex = 5;
            this.borcGosterim.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.borcGosterim_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ödenecek Tutar : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // borcOdeme
            // 
            this.borcOdeme.Location = new System.Drawing.Point(504, 243);
            this.borcOdeme.Name = "borcOdeme";
            this.borcOdeme.Size = new System.Drawing.Size(100, 22);
            this.borcOdeme.TabIndex = 7;
            // 
            // birMusterininBorcDurumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.borcOdeme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.borcGosterim);
            this.Controls.Add(this.musteriGosterim);
            this.Controls.Add(this.borcOdemeButonu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "birMusterininBorcDurumu";
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
    }
}