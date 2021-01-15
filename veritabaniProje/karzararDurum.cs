using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace veritabaniProje
{
    public partial class karzararDurum : Form
    {
        Entity.Context dbcontext = new Entity.Context();
        SqlConnection baglanti = new SqlConnection(@"Server=DESKTOP-HU112LL; Database =veritabaniProje; Trusted_Connection =True;");
        SqlDataAdapter sorgu = new SqlDataAdapter();
        int tedarikcitoplamborc;
        int toplamsatistutar;
        public karzararDurum()
        {
            InitializeComponent();
        }

        private void karzararDurum_Load(object sender, EventArgs e)
        {

            string tarih1 = TarihliKarZarar.karzararilk;
            string tarih2 = TarihliKarZarar.karzararson;
            DataTable tedarikcisorgudt = new DataTable();
            SqlDataAdapter tedarikcisorgu = new SqlDataAdapter("select tedarikciId,borcMiktar,girisTarihi from tTedarikcis where girisTarihi between '"+tarih1+"' and '"+tarih2+"'", baglanti);
            DataSet tedarikcids = new DataSet();
            baglanti.Open();
            tedarikcisorgu.Fill(tedarikcids,"tTedarikcis");
            tedarikcisorgudt = tedarikcids.Tables["tTedarikcis"];
            tedarikciKar.DataSource = tedarikcisorgudt;
            baglanti.Close();
            tedarikciKar.Columns[0].HeaderText = "Tedarikci Numarası";
            tedarikciKar.Columns[1].HeaderText = "Borç Miktarı";
            tedarikciKar.Columns[2].HeaderText = "Borç Tarihi";

            DataTable satissorgudt = new DataTable();
            SqlDataAdapter satissorgu = new SqlDataAdapter("select urunAdi,satisMiktar,satisTutar,satisTarih from tSatis where satisTarih between '" + tarih1 + "' and '" + tarih2 + "'", baglanti);
            DataSet satisds = new DataSet();
            baglanti.Open();
            satissorgu.Fill(satisds, "tSatis");
            satissorgudt = satisds.Tables["tSatis"];
            satisKar.DataSource = satissorgudt;
            baglanti.Close();
            satisKar.Columns[0].HeaderText = "Ürün Adı";
            satisKar.Columns[1].HeaderText = "Satış Miktarı";
            satisKar.Columns[2].HeaderText = "Satış Tutarı";
            satisKar.Columns[3].HeaderText = "Satış Tarihi";
        }

        private void hesaplama_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tedarikciKar.Rows.Count; ++i)
            {
                tedarikcitoplamborc += Convert.ToInt32(tedarikciKar.Rows[i].Cells[1].Value);
            }
            tedarikciBorc.Text = tedarikcitoplamborc.ToString() + " ₺";

            for (int i = 0; i < satisKar.Rows.Count; ++i)
            {
                toplamsatistutar += Convert.ToInt32(satisKar.Rows[i].Cells[2].Value);
            }
            toplamsatis.Text = toplamsatistutar.ToString() + " ₺ ";
            int netKar1 = toplamsatistutar - tedarikcitoplamborc;
            if (netKar1 < 0)
            {
                netKar.ForeColor = Color.Red;
                netKar.Text = netKar1.ToString() + " ₺ zarardasınız.";
            }
            else
            {
                netKar.ForeColor = Color.Green;
                netKar.Text = netKar1.ToString() + " ₺ kardasınız.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
