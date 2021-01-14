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
    public partial class TarihliKarZarar : Form
    {
        public static string trend1;
        public static string trend2;
        public TarihliKarZarar()
        {
            InitializeComponent();
        }

        private void satisTrendButton_Click(object sender, EventArgs e)
        {
            trend1 = trend.Value.ToShortDateString();
            trend2 = trend3.Value.ToShortDateString();
            satisTrendiGrafik trendGrafik = new satisTrendiGrafik();
            trendGrafik.Show();
        }

        public static string karzararilk;
        public static string karzararson;
        private void karzararButton_Click(object sender, EventArgs e)
        { 
            karzararilk = karzarar1.Value.ToShortDateString();
            karzararson = karzarar2.Value.ToShortDateString();
            karzararDurum karzarar = new karzararDurum();
            karzarar.Show();
        }

        private void ürünListeButton_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TarihliKarZarar_Load(object sender, EventArgs e)
        {

        }
    }
}
