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
            SqlDataAdapter tedarikcisorgu = new SqlDataAdapter("select tedarikciId,borcMiktar,urunMiktar From tTedarikcis Where tedarikciId ='" + Convert.ToInt32(label2.Text) + "'", bag);
            ds = new DataSet();
            bag.Open();
            tedarikcisorgu.Fill(ds, "tTedarikcis");
            dt = ds.Tables["tTedarikcis"];
            tedarikciGosterim.DataSource = dt;
            bag.Close();
            tedarikciGosterim.Columns[0].HeaderText = "Tedarikci No";
            tedarikciGosterim.Columns[1].HeaderText = "Toplam Borç";
            tedarikciGosterim.Columns[2].HeaderText = "Alınan Ürün Miktarı";
        }

        private void borcOdemeButonu_Click(object sender, EventArgs e)
        {
            var borc = new Entity.tTedarikci();
            if (borcOdeme.Text != null)
            {
                borc.borcMiktar -= Convert.ToInt32(borcOdeme.Text);
                MessageBox.Show("" + borc.tedarikciId + "Numaralı Tedarikçinin Borcu Güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
