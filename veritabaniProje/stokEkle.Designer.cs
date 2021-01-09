
namespace veritabaniProje
{
    partial class stokEkle
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.veritabaniProjeDataSetUrunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.karPayi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.veritabaniProjeDataSetIrsaliye1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veritabaniProjeDataSetIrsaliye1 = new veritabaniProje.veritabaniProjeDataSetIrsaliye();
            this.veritabaniProjeDataSetIrsaliye2 = new veritabaniProje.veritabaniProjeDataSetIrsaliye();
            this.tIrsaliyesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tIrsaliyesTableAdapter1 = new veritabaniProje.veritabaniProjeDataSetIrsaliyeTableAdapters.tIrsaliyesTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.veritabaniProjeDataSetUrunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabaniProjeDataSetIrsaliye1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabaniProjeDataSetIrsaliye1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabaniProjeDataSetIrsaliye2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIrsaliyesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Sienna;
            this.button1.Location = new System.Drawing.Point(271, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Stok Ekle\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button2.ForeColor = System.Drawing.Color.Sienna;
            this.button2.Location = new System.Drawing.Point(12, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "<- Geri Dönmek için Tıkla";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button3.ForeColor = System.Drawing.Color.Sienna;
            this.button3.Location = new System.Drawing.Point(558, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(230, 39);
            this.button3.TabIndex = 3;
            this.button3.Text = "Stok Durumunu Görmek İçin Tıkla ->";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(294, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 20);
            this.button4.TabIndex = 4;
            this.button4.Text = "ONAYLA";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // karPayi
            // 
            this.karPayi.Location = new System.Drawing.Point(171, 11);
            this.karPayi.Name = "karPayi";
            this.karPayi.Size = new System.Drawing.Size(100, 20);
            this.karPayi.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "KÂR MİKTARINI GİRİNİZ : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView1.DataSource = this.tIrsaliyesBindingSource1;
            this.dataGridView1.GridColor = System.Drawing.Color.Sienna;
            this.dataGridView1.Location = new System.Drawing.Point(74, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 242);
            this.dataGridView1.TabIndex = 7;
            // 
            // veritabaniProjeDataSetIrsaliye1BindingSource
            // 
            this.veritabaniProjeDataSetIrsaliye1BindingSource.DataSource = this.veritabaniProjeDataSetIrsaliye1;
            this.veritabaniProjeDataSetIrsaliye1BindingSource.Position = 0;
            // 
            // veritabaniProjeDataSetIrsaliye1
            // 
            this.veritabaniProjeDataSetIrsaliye1.DataSetName = "veritabaniProjeDataSetIrsaliye";
            this.veritabaniProjeDataSetIrsaliye1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // veritabaniProjeDataSetIrsaliye2
            // 
            this.veritabaniProjeDataSetIrsaliye2.DataSetName = "veritabaniProjeDataSetIrsaliye";
            this.veritabaniProjeDataSetIrsaliye2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tIrsaliyesBindingSource1
            // 
            this.tIrsaliyesBindingSource1.DataMember = "tIrsaliyes";
            this.tIrsaliyesBindingSource1.DataSource = this.veritabaniProjeDataSetIrsaliye2;
            // 
            // tIrsaliyesTableAdapter1
            // 
            this.tIrsaliyesTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "urunId";
            this.dataGridViewTextBoxColumn1.HeaderText = "urunId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "irsaliyeID";
            this.dataGridViewTextBoxColumn2.HeaderText = "irsaliyeID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "girisTarih";
            this.dataGridViewTextBoxColumn3.HeaderText = "girisTarih";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "girdiFiyat";
            this.dataGridViewTextBoxColumn4.HeaderText = "girdiFiyat";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "miktar";
            this.dataGridViewTextBoxColumn5.HeaderText = "miktar";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "tedarikciId";
            this.dataGridViewTextBoxColumn6.HeaderText = "tedarikciId";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "urunAdi";
            this.dataGridViewTextBoxColumn7.HeaderText = "urunAdi";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // stokEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.karPayi);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "stokEkle";
            this.Text = "Stok Ekleme Ekranı";
            this.Load += new System.EventHandler(this.stokEkle_Load_2);
            ((System.ComponentModel.ISupportInitialize)(this.veritabaniProjeDataSetUrunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabaniProjeDataSetIrsaliye1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabaniProjeDataSetIrsaliye1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabaniProjeDataSetIrsaliye2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIrsaliyesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource veritabaniProjeDataSetUrunBindingSource;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox karPayi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource veritabaniProjeDataSetIrsaliye1BindingSource;
        private veritabaniProjeDataSetIrsaliye veritabaniProjeDataSetIrsaliye1;
        private veritabaniProjeDataSetIrsaliye veritabaniProjeDataSetIrsaliye2;
        private System.Windows.Forms.BindingSource tIrsaliyesBindingSource1;
        private veritabaniProjeDataSetIrsaliyeTableAdapters.tIrsaliyesTableAdapter tIrsaliyesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}