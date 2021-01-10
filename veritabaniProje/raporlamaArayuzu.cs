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
    public partial class raporlamaArayuzu : Form
    {
        public raporlamaArayuzu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void musteriRaporu_Click(object sender, EventArgs e)
        {
            topluMusteriBorcDurum topluMusteri = new topluMusteriBorcDurum();
            topluMusteri.Show();
        }

        private void musteriSatis_Click(object sender, EventArgs e)
        {
            satisRapor satisRaporu = new satisRapor();
            satisRaporu.Show();
        }

        private void karzararDurum_Click(object sender, EventArgs e)
        {
            TarihliKarZarar karzarar = new TarihliKarZarar();
            karzarar.Show();
        }
    }
}
