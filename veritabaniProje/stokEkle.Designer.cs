
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.veritabaniProjeDataSetUrun = new veritabaniProje.veritabaniProjeDataSetUrun();
            this.veritabaniProjeDataSetUrunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veritabaniProjeDataSet = new veritabaniProje.veritabaniProjeDataSet();
            this.tIrsaliyesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tIrsaliyesTableAdapter = new veritabaniProje.veritabaniProjeDataSetTableAdapters.tIrsaliyesTableAdapter();
            this.irsaliyeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girisTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girdiFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tedarikciIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabaniProjeDataSetUrun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabaniProjeDataSetUrunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabaniProjeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIrsaliyesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Sienna;
            this.button1.Location = new System.Drawing.Point(271, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Stok Ekle\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.irsaliyeIDDataGridViewTextBoxColumn,
            this.girisTarihDataGridViewTextBoxColumn,
            this.urunIdDataGridViewTextBoxColumn,
            this.girdiFiyatDataGridViewTextBoxColumn,
            this.miktarDataGridViewTextBoxColumn,
            this.tedarikciIdDataGridViewTextBoxColumn,
            this.urunAdiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tIrsaliyesBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Sienna;
            this.dataGridView1.Location = new System.Drawing.Point(70, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(659, 277);
            this.dataGridView1.TabIndex = 1;
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
            // veritabaniProjeDataSetUrun
            // 
            this.veritabaniProjeDataSetUrun.DataSetName = "veritabaniProjeDataSetUrun";
            this.veritabaniProjeDataSetUrun.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // veritabaniProjeDataSetUrunBindingSource
            // 
            this.veritabaniProjeDataSetUrunBindingSource.DataSource = this.veritabaniProjeDataSetUrun;
            this.veritabaniProjeDataSetUrunBindingSource.Position = 0;
            // 
            // veritabaniProjeDataSet
            // 
            this.veritabaniProjeDataSet.DataSetName = "veritabaniProjeDataSet";
            this.veritabaniProjeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tIrsaliyesBindingSource
            // 
            this.tIrsaliyesBindingSource.DataMember = "tIrsaliyes";
            this.tIrsaliyesBindingSource.DataSource = this.veritabaniProjeDataSet;
            // 
            // tIrsaliyesTableAdapter
            // 
            this.tIrsaliyesTableAdapter.ClearBeforeFill = true;
            // 
            // irsaliyeIDDataGridViewTextBoxColumn
            // 
            this.irsaliyeIDDataGridViewTextBoxColumn.DataPropertyName = "irsaliyeID";
            this.irsaliyeIDDataGridViewTextBoxColumn.HeaderText = "irsaliyeID";
            this.irsaliyeIDDataGridViewTextBoxColumn.Name = "irsaliyeIDDataGridViewTextBoxColumn";
            // 
            // girisTarihDataGridViewTextBoxColumn
            // 
            this.girisTarihDataGridViewTextBoxColumn.DataPropertyName = "girisTarih";
            this.girisTarihDataGridViewTextBoxColumn.HeaderText = "girisTarih";
            this.girisTarihDataGridViewTextBoxColumn.Name = "girisTarihDataGridViewTextBoxColumn";
            // 
            // urunIdDataGridViewTextBoxColumn
            // 
            this.urunIdDataGridViewTextBoxColumn.DataPropertyName = "urunId";
            this.urunIdDataGridViewTextBoxColumn.HeaderText = "urunId";
            this.urunIdDataGridViewTextBoxColumn.Name = "urunIdDataGridViewTextBoxColumn";
            this.urunIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // girdiFiyatDataGridViewTextBoxColumn
            // 
            this.girdiFiyatDataGridViewTextBoxColumn.DataPropertyName = "girdiFiyat";
            this.girdiFiyatDataGridViewTextBoxColumn.HeaderText = "girdiFiyat";
            this.girdiFiyatDataGridViewTextBoxColumn.Name = "girdiFiyatDataGridViewTextBoxColumn";
            // 
            // miktarDataGridViewTextBoxColumn
            // 
            this.miktarDataGridViewTextBoxColumn.DataPropertyName = "miktar";
            this.miktarDataGridViewTextBoxColumn.HeaderText = "miktar";
            this.miktarDataGridViewTextBoxColumn.Name = "miktarDataGridViewTextBoxColumn";
            // 
            // tedarikciIdDataGridViewTextBoxColumn
            // 
            this.tedarikciIdDataGridViewTextBoxColumn.DataPropertyName = "tedarikciId";
            this.tedarikciIdDataGridViewTextBoxColumn.HeaderText = "tedarikciId";
            this.tedarikciIdDataGridViewTextBoxColumn.Name = "tedarikciIdDataGridViewTextBoxColumn";
            // 
            // urunAdiDataGridViewTextBoxColumn
            // 
            this.urunAdiDataGridViewTextBoxColumn.DataPropertyName = "urunAdi";
            this.urunAdiDataGridViewTextBoxColumn.HeaderText = "urunAdi";
            this.urunAdiDataGridViewTextBoxColumn.Name = "urunAdiDataGridViewTextBoxColumn";
            // 
            // stokEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "stokEkle";
            this.Text = "Stok Ekleme Ekranı";
            this.Load += new System.EventHandler(this.stokEkle_Load_2);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabaniProjeDataSetUrun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabaniProjeDataSetUrunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabaniProjeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIrsaliyesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource veritabaniProjeDataSetUrunBindingSource;
        private veritabaniProjeDataSetUrun veritabaniProjeDataSetUrun;
        private veritabaniProjeDataSet veritabaniProjeDataSet;
        private System.Windows.Forms.BindingSource tIrsaliyesBindingSource;
        private veritabaniProjeDataSetTableAdapters.tIrsaliyesTableAdapter tIrsaliyesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn irsaliyeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn girisTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn girdiFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tedarikciIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
    }
}