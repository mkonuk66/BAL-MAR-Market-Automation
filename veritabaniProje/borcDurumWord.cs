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
    public partial class borcDurumWord : Form
    {
        Entity.Context dbcontext = new Entity.Context();
        SqlConnection bag = new SqlConnection(@"Server=(localdb)\mkonuk; Database =veritabaniProje; Trusted_Connection =True;");
        SqlDataAdapter adtr = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        DataTable dt1 = new DataTable();
        public borcDurumWord()
        {
            SqlDataAdapter musterisorgu = new SqlDataAdapter("select borcMiktar,odenenMiktar,musteriAdi,musteriSoyadi, From tMusteris Where musteriId =", bag);
            InitializeComponent();
        }

        private void borcDurumWord_Load(object sender, EventArgs e)
        {

        }
    }
}
