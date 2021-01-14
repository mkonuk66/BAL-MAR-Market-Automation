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
    public partial class stokDurum : Form
    {
        Entity.Context dbcontext = new Entity.Context();
        public stokDurum()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            stokEkle stkEkle1 = new stokEkle();
            stkEkle1.Show();
        }

        private void stokDurum_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'veritabaniProjeDataSetUrun.tUruns' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tUrunsTableAdapter.Fill(this.veritabaniProjeDataSetUrun.tUruns);
            dataGridView1.DataSource = dbcontext.tUruns.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
