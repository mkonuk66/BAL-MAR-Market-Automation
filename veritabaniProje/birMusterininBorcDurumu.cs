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
using System.Data.Sql;
using System.IO;
using veritabaniProje.Entity;

namespace veritabaniProje
{
    public partial class birMusterininBorcDurumu : Form
    {
        Entity.Context dbcontext = new Entity.Context();
        SqlConnection bag = new SqlConnection("Server=DESKTOP-HU112LL; Database =veritabaniProje; Trusted_Connection =True;");
        SqlDataAdapter adtr = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public birMusterininBorcDurumu()
        {
            InitializeComponent();
        }

        private void birMusterininBorcDurumu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'veritabaniProjeDataSet1.tMusteris' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.

            // Müşteri Bilgilerini Gösteriyor 
            this.tMusterisTableAdapter.Fill(this.veritabaniProjeDataSet1.tMusteris);
            label2.Text = kayitliMusteri.gonderilecekveri;
            DataTable dt = new DataTable();
            SqlDataAdapter musterisorgu = new SqlDataAdapter("select * From tMusteris Where musteriId ='" + Convert.ToInt32(label2.Text) + "'", bag);
            ds = new DataSet();
            bag.Open();
            musterisorgu.Fill(ds, "tMusteris");
            dt = ds.Tables["tMusteris"];
            musteriGosterim.DataSource = dt;
            bag.Close();
            musteriGosterim.Columns[0].HeaderText = "Musteri No";
            musteriGosterim.Columns[1].HeaderText = "Adı";
            musteriGosterim.Columns[2].HeaderText = "Soyadı";
            musteriGosterim.Columns[3].HeaderText = "GSM";
            musteriGosterim.Columns[4].HeaderText = "Kayıt Tarihi";
            musteriGosterim.Columns[5].HeaderText = "Müşterinin Borcu";

            //Borc Bilgilerini Gösteriyor

            DataTable dt1 = new DataTable();
            SqlDataAdapter borcsorgu = new SqlDataAdapter("select * From tBorcs Where musteriId ='" + Convert.ToInt32(label2.Text) + "'", bag);
            ds = new DataSet();
            bag.Open();
            borcsorgu.Fill(ds, "tBorcs");
            dt1 = ds.Tables["tBorcs"];
            musteriGosterim.DataSource = dt;
            bag.Close();
            musteriGosterim.Columns[0].HeaderText = "Musteri No";
            musteriGosterim.Columns[1].HeaderText = "Borc Tarihi";
            musteriGosterim.Columns[2].HeaderText = "Borc Miktarı";




        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tMusterisBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void musteriGosterim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void borcGosterim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
