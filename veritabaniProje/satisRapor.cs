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
    public partial class satisRapor : Form
    {
        Entity.Context dbcontext = new Entity.Context();
        SqlConnection baglanti = new SqlConnection(@"Server=DESKTOP-HU112LL; Database =veritabaniProje; Trusted_Connection =True;");
        SqlDataAdapter adborcsorgu = new SqlDataAdapter();
        DataSet satissorguds = new DataSet();

        public satisRapor()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void satisRapor_Load(object sender, EventArgs e)
        {
            DataTable satissorgudt = new DataTable();
            SqlDataAdapter satissorgu = new SqlDataAdapter("select urunAdi,sum (satisMiktar) as miktar,sum (satisTutar) as tutar from tSatis group by urunAdi order by miktar desc", baglanti);
            baglanti.Open();
            satissorgu.Fill(satissorguds, "tSatis");
            satissorgudt = satissorguds.Tables["tSatis"];
            satisRaporListe.DataSource = satissorgudt;
            baglanti.Close();
            satisRaporListe.Columns[0].HeaderText = "Ürün Adı";
            satisRaporListe.Columns[1].HeaderText = "Toplam Satış Miktarı";
            satisRaporListe.Columns[2].HeaderText = "Toplam Tutar";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
