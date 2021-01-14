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
    public partial class tedarikcininBorcDurumu : Form
    {

        Entity.Context dbcontext = new Entity.Context();
        SqlConnection bag = new SqlConnection(@"Server=DESKTOP-HU112LL; Database =veritabaniProje; Trusted_Connection =True;");
        SqlDataAdapter adtr = new SqlDataAdapter();
        DataSet ds = new DataSet();

        public tedarikcininBorcDurumu()
        {
            InitializeComponent();
        }

        private void tedarikcininBorcDurumu_Load(object sender, EventArgs e)
        {
            //tedarikci bilgilerini gösteriyor
            label2.Text = kayitliTedarikci.gonderilecekveri1;
            DataTable dt = new DataTable();
            SqlDataAdapter tedarikcisorgu = new SqlDataAdapter("select tedarikciID,toplamBorc,odenenMiktar,kalanMiktar from ttedarikciOdemes Where tedarikciID ='" + Convert.ToInt32(label2.Text) + "'", bag);
            ds = new DataSet();
            bag.Open();
            tedarikcisorgu.Fill(ds, "ttedarikciOdemes");
            dt = ds.Tables["ttedarikciOdemes"];
            tedarikciGosterim.DataSource = dt;
            bag.Close();
            tedarikciGosterim.Columns[0].HeaderText = "Tedarikci No";
            tedarikciGosterim.Columns[1].HeaderText = "Toplam Borç";
            tedarikciGosterim.Columns[2].HeaderText = "Odenen Miktar";
            tedarikciGosterim.Columns[3].HeaderText = "Kalan Borç Miktarı";
        }

        private void borcOdemeButonu_Click(object sender, EventArgs e)
        {
            int sorgulama = Convert.ToInt32(label2.Text);
            var tedarikcisorgu = dbcontext.ttedarikciOdemes.FirstOrDefault(x => x.tedarikciID == sorgulama);
            if (borcOdeme.Text != null)
            {
                tedarikcisorgu.odenenMiktar += Convert.ToInt32(borcOdeme.Text);
                tedarikcisorgu.kalanMiktar = tedarikcisorgu.toplamBorc - tedarikcisorgu.odenenMiktar;
                MessageBox.Show("" + tedarikcisorgu.tedarikciID + "Numaralı Tedarikçinin Borcu Güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void borcOdeme_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
