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
        SqlConnection bag = new SqlConnection(@"Server=DESKTOP-HU112LL; Database =veritabaniProje; Trusted_Connection =True;");
        SqlDataAdapter adtr = new SqlDataAdapter();
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
            DataSet ds = new DataSet();
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
            musteriGosterim.Columns[6].HeaderText = "Ödenen Miktar";
            musteriGosterim.Columns[7].HeaderText = "Kalan Borc Miktarı";

            //Borc Bilgilerini Gösteriyor

            DataTable dt1 = new DataTable();
            SqlDataAdapter borcsorgu = new SqlDataAdapter("select musteriId,borcTarihi,borcMiktar From tBorcs Where musteriId ='" + Convert.ToInt32(label2.Text) + "'", bag);
            DataSet ds1 = new DataSet();
            bag.Open();
            borcsorgu.Fill(ds1, "tBorcs");
            dt1 = ds1.Tables["tBorcs"];
            borcGosterim.DataSource = dt1;
            bag.Close();
            borcGosterim.Columns[0].HeaderText = "Musteri No";
            borcGosterim.Columns[1].HeaderText = "Borc Tarihi";
            borcGosterim.Columns[2].HeaderText = "Borc Miktarı";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int mus = Convert.ToInt32(label2.Text);
            float borcode = Convert.ToSingle(borcOdeme.Text);
            var musterisorgu = dbcontext.tMusteris.FirstOrDefault(x => x.musteriId == mus);
            if (borcOdeme.Text != null && musterisorgu != null )
            {
                musterisorgu.odenenMiktar += borcode;
                musterisorgu.kalanBorc = musterisorgu.musteriBorc - musterisorgu.odenenMiktar;
                MessageBox.Show("" + musterisorgu.musteriAdi + " Borcu Güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbcontext.SaveChanges();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz borç tutarını giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void musteriGosterim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
