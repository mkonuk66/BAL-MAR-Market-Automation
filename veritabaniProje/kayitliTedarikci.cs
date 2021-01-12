using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veritabaniProje
{
    public partial class kayitliTedarikci : Form
    {
        Entity.Context dbcontext = new Entity.Context();
        public kayitliTedarikci()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kayitliTedarikci_Load(object sender, EventArgs e)
        {

        }

        public static string gonderilecekveri1;

        private void button1_Click(object sender, EventArgs e)
        {
            gonderilecekveri1 = tedarikciNo.Text;
            var musteri = new Entity.tTedarikci();
            int kontrol = Convert.ToInt32(tedarikciNo.Text);
            var product = dbcontext.tTedarikcis.FirstOrDefault(x => x.tedarikciId == kontrol);
            if (product == null)
            {
                MessageBox.Show("Böyle bir müşteri bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                tedarikciBorc f2 = new tedarikciBorc();
                f2.Show();
                this.Close();
            }
        }

        private void tedarikciNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
