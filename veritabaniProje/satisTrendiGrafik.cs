using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace veritabaniProje
{
    public partial class satisTrendiGrafik : Form
    {
        Entity.Context dbcontext = new Entity.Context();
        SqlConnection baglanti = new SqlConnection(@"Server=DESKTOP-HU112LL; Database =veritabaniProje; Trusted_Connection =True;");
        SqlDataAdapter grafik = new SqlDataAdapter();

        public satisTrendiGrafik()
        {
            InitializeComponent();
        }

        private void satisTrendiGrafik_Load(object sender, EventArgs e)
        {
            string tarih1 = TarihliKarZarar.trend1;
            string tarih2 = TarihliKarZarar.trend2;
            // TODO: Bu kod satırı 'veritabaniProjeDataSet5.tSatis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tSatisTableAdapter2.Fill(this.veritabaniProjeDataSet5.tSatis);
            // TODO: Bu kod satırı 'veritabaniProjeDataSet4.tSatis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tSatisTableAdapter1.Fill(this.veritabaniProjeDataSet4.tSatis);
            // TODO: Bu kod satırı 'veritabaniProjeDataSet3.tSatis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tSatisTableAdapter.Fill(this.veritabaniProjeDataSet3.tSatis);

            DataTable grafikdt = new DataTable();
            DataSet grafikds = new DataSet();
            SqlDataAdapter grafiksorgu = new SqlDataAdapter("select satisTarih, sum (satisMiktar) as miktar from tSatis where satisTarih between '" + tarih1 + "' and '" + tarih2 + "' group by satisTarih", baglanti);
            baglanti.Open();
            grafiksorgu.Fill(grafikds, "tSatis");
            grafikdt = grafikds.Tables["tSatis"];
            trendgrafik.DataSource = grafikdt;
            baglanti.Close();
            trendgrafik.Columns[0].HeaderText = "Satış Tarihi";
            trendgrafik.Columns[1].HeaderText = "Satış Miktarı";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series["Satis"].XValueMember = "satisTarih";
            chart1.Series["Satis"].YValueMembers = "miktar";
            chart1.DataSource = trendgrafik.DataSource;
            chart1.DataBind();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
