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

namespace veritabaniProje
{
    public partial class kayitliMusteri : Form
    {
        Entity.Context dbcontext = new Entity.Context();
        public kayitliMusteri()
        {
            InitializeComponent();
        }

        public static string gonderilecekveri;
        private void button1_Click(object sender, EventArgs e)
        {
            gonderilecekveri = textBox1.Text;
            var musteri = new Entity.tMusteri();
            int kontrol = Convert.ToInt32(textBox1.Text);
            var product = dbcontext.tMusteris.FirstOrDefault(x => x.musteriId == kontrol);
            if(product == null)
            {
                MessageBox.Show("Böyle bir müşteri bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                birMusterininBorcDurumu f2 = new birMusterininBorcDurumu();
                f2.Show();
                this.Close();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char character = e.KeyChar;
            if (!Char.IsDigit(character))
            {
                e.Handled = true;
                MessageBox.Show("Sadece sayı giriniz");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kayitliMusteri_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
