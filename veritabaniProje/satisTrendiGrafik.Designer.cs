
namespace veritabaniProje
{
    partial class satisTrendiGrafik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(satisTrendiGrafik));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.trendgrafik = new System.Windows.Forms.DataGridView();
            this.tSatisBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.veritabaniProjeDataSet5 = new veritabaniProje.veritabaniProjeDataSet5();
            this.button1 = new System.Windows.Forms.Button();
            this.tSatisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veritabaniProjeDataSet3 = new veritabaniProje.veritabaniProjeDataSet3();
            this.tSatisTableAdapter = new veritabaniProje.veritabaniProjeDataSet3TableAdapters.tSatisTableAdapter();
            this.veritabaniProjeDataSet4 = new veritabaniProje.veritabaniProjeDataSet4();
            this.tSatisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tSatisTableAdapter1 = new veritabaniProje.veritabaniProjeDataSet4TableAdapters.tSatisTableAdapter();
            this.tSatisTableAdapter2 = new veritabaniProje.veritabaniProjeDataSet5TableAdapters.tSatisTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trendgrafik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSatisBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabaniProjeDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSatisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabaniProjeDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabaniProjeDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSatisBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(509, 88);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Satis";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(419, 374);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // trendgrafik
            // 
            this.trendgrafik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.trendgrafik.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.trendgrafik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trendgrafik.Location = new System.Drawing.Point(13, 88);
            this.trendgrafik.Name = "trendgrafik";
            this.trendgrafik.RowHeadersWidth = 51;
            this.trendgrafik.RowTemplate.Height = 24;
            this.trendgrafik.Size = new System.Drawing.Size(451, 374);
            this.trendgrafik.TabIndex = 1;
            // 
            // tSatisBindingSource2
            // 
            this.tSatisBindingSource2.DataMember = "tSatis";
            this.tSatisBindingSource2.DataSource = this.veritabaniProjeDataSet5;
            // 
            // veritabaniProjeDataSet5
            // 
            this.veritabaniProjeDataSet5.DataSetName = "veritabaniProjeDataSet5";
            this.veritabaniProjeDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Sienna;
            this.button1.Location = new System.Drawing.Point(789, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tSatisBindingSource
            // 
            this.tSatisBindingSource.DataMember = "tSatis";
            this.tSatisBindingSource.DataSource = this.veritabaniProjeDataSet3;
            // 
            // veritabaniProjeDataSet3
            // 
            this.veritabaniProjeDataSet3.DataSetName = "veritabaniProjeDataSet3";
            this.veritabaniProjeDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tSatisTableAdapter
            // 
            this.tSatisTableAdapter.ClearBeforeFill = true;
            // 
            // veritabaniProjeDataSet4
            // 
            this.veritabaniProjeDataSet4.DataSetName = "veritabaniProjeDataSet4";
            this.veritabaniProjeDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tSatisBindingSource1
            // 
            this.tSatisBindingSource1.DataMember = "tSatis";
            this.tSatisBindingSource1.DataSource = this.veritabaniProjeDataSet4;
            // 
            // tSatisTableAdapter1
            // 
            this.tSatisTableAdapter1.ClearBeforeFill = true;
            // 
            // tSatisTableAdapter2
            // 
            this.tSatisTableAdapter2.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(905, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 63);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // satisTrendiGrafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(966, 555);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trendgrafik);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "satisTrendiGrafik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Trendi Grafiği";
            this.Load += new System.EventHandler(this.satisTrendiGrafik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trendgrafik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSatisBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabaniProjeDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSatisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabaniProjeDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabaniProjeDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSatisBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView trendgrafik;
        private veritabaniProjeDataSet3 veritabaniProjeDataSet3;
        private System.Windows.Forms.BindingSource tSatisBindingSource;
        private veritabaniProjeDataSet3TableAdapters.tSatisTableAdapter tSatisTableAdapter;
        private System.Windows.Forms.Button button1;
        private veritabaniProjeDataSet4 veritabaniProjeDataSet4;
        private System.Windows.Forms.BindingSource tSatisBindingSource1;
        private veritabaniProjeDataSet4TableAdapters.tSatisTableAdapter tSatisTableAdapter1;
        private veritabaniProjeDataSet5 veritabaniProjeDataSet5;
        private System.Windows.Forms.BindingSource tSatisBindingSource2;
        private veritabaniProjeDataSet5TableAdapters.tSatisTableAdapter tSatisTableAdapter2;
        private System.Windows.Forms.Button button2;
    }
}