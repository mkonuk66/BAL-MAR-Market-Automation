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
        public TarihliKarZarar()
        {
            InitializeComponent();
        }

        private void satisTrendButton_Click(object sender, EventArgs e)
        {
            satisTrendiGrafik trendGrafik = new satisTrendiGrafik();
            trendGrafik.Show();
        }

        private void karzararButton_Click(object sender, EventArgs e)
        {
            karzararDurum karzarar = new karzararDurum();
            karzarar.Show();
        }

        private void ürünListeButton_Click(object sender, EventArgs e)
        {
            satılanUrunListesi urunListe = new satılanUrunListesi();
            urunListe.Show();
        }
    }
}
