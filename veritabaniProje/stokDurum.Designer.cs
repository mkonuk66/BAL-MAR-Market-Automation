
namespace veritabaniProje
{
    partial class stokDurum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stokDurum));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkodNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tUrunsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veritabaniProjeDataSetUrun = new veritabaniProje.veritabaniProjeDataSetUrun();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tUrunsTableAdapter = new veritabaniProje.veritabaniProjeDataSetUrunTableAdapters.tUrunsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUrunsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabaniProjeDataSetUrun)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunIdDataGridViewTextBoxColumn,
            this.barkodNoDataGridViewTextBoxColumn,
            this.urunAdiDataGridViewTextBoxColumn,
            this.miktarDataGridViewTextBoxColumn,
            this.satisFiyatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tUrunsBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Sienna;
            this.dataGridView1.Location = new System.Drawing.Point(88, 170);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(899, 315);
            this.dataGridView1.TabIndex = 0;
            // 
            // urunIdDataGridViewTextBoxColumn
            // 
            this.urunIdDataGridViewTextBoxColumn.DataPropertyName = "urunId";
            this.urunIdDataGridViewTextBoxColumn.HeaderText = "urunId";
            this.urunIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunIdDataGridViewTextBoxColumn.Name = "urunIdDataGridViewTextBoxColumn";
            this.urunIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // barkodNoDataGridViewTextBoxColumn
            // 
            this.barkodNoDataGridViewTextBoxColumn.DataPropertyName = "barkodNo";
            this.barkodNoDataGridViewTextBoxColumn.HeaderText = "barkodNo";
            this.barkodNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.barkodNoDataGridViewTextBoxColumn.Name = "barkodNoDataGridViewTextBoxColumn";
            // 
            // urunAdiDataGridViewTextBoxColumn
            // 
            this.urunAdiDataGridViewTextBoxColumn.DataPropertyName = "urunAdi";
            this.urunAdiDataGridViewTextBoxColumn.HeaderText = "urunAdi";
            this.urunAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunAdiDataGridViewTextBoxColumn.Name = "urunAdiDataGridViewTextBoxColumn";
            // 
            // miktarDataGridViewTextBoxColumn
            // 
            this.miktarDataGridViewTextBoxColumn.DataPropertyName = "miktar";
            this.miktarDataGridViewTextBoxColumn.HeaderText = "miktar";
            this.miktarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.miktarDataGridViewTextBoxColumn.Name = "miktarDataGridViewTextBoxColumn";
            // 
            // satisFiyatDataGridViewTextBoxColumn
            // 
            this.satisFiyatDataGridViewTextBoxColumn.DataPropertyName = "satisFiyat";
            this.satisFiyatDataGridViewTextBoxColumn.HeaderText = "satisFiyat";
            this.satisFiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.satisFiyatDataGridViewTextBoxColumn.Name = "satisFiyatDataGridViewTextBoxColumn";
            // 
            // tUrunsBindingSource
            // 
            this.tUrunsBindingSource.DataMember = "tUruns";
            this.tUrunsBindingSource.DataSource = this.veritabaniProjeDataSetUrun;
            // 
            // veritabaniProjeDataSetUrun
            // 
            this.veritabaniProjeDataSetUrun.DataSetName = "veritabaniProjeDataSetUrun";
            this.veritabaniProjeDataSetUrun.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Sienna;
            this.button2.Location = new System.Drawing.Point(42, 494);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(279, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "<-  Geri  Dönmek İçin Tıkla ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.Sienna;
            this.button3.Location = new System.Drawing.Point(772, 492);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(279, 47);
            this.button3.TabIndex = 3;
            this.button3.Text = "Stok Eklemek İçin Tıkla  ->";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 22F);
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(383, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Stok Durumu";
            // 
            // tUrunsTableAdapter
            // 
            this.tUrunsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1012, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 56);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stokDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "stokDurum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Durum Ekranı";
            this.Load += new System.EventHandler(this.stokDurum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUrunsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabaniProjeDataSetUrun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private veritabaniProjeDataSetUrun veritabaniProjeDataSetUrun;
        private System.Windows.Forms.BindingSource tUrunsBindingSource;
        private veritabaniProjeDataSetUrunTableAdapters.tUrunsTableAdapter tUrunsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}