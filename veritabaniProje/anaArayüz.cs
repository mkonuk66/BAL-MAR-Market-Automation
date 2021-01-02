using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using veritabaniProje.Entity;

namespace veritabaniProje
{
    public partial class anaArayüz : Form
    {
        public anaArayüz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            satisArayuzu sta = new satisArayuzu();
            sta.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            musteriArayuzu mta = new musteriArayuzu();
            mta.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stokEkle stk = new stokEkle();
            stk.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            raporlamaArayuzu raporA = new raporlamaArayuzu();
            raporA.Show();
        }

        private void anaArayüz_Load(object sender, EventArgs e)
        {
            Context c = new Context();
            //c.Database.Create();
        }
    }
}
