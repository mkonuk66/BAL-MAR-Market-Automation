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
    public partial class RaporAlim : UserControl
    {
        public RaporAlim()
        {
            InitializeComponent();
        }

        private void musteriSatis_Click(object sender, EventArgs e)
        {
            satisRapor satisRaporu = new satisRapor();
            satisRaporu.Show();
        }

        private void musteriRaporu_Click(object sender, EventArgs e)
        {
            topluMusteriBorcDurum tpl = new topluMusteriBorcDurum();
            tpl.Show();
        }

        private void karzararDurum_Click(object sender, EventArgs e)
        {
            TarihliKarZarar karzarar = new TarihliKarZarar();
            karzarar.Show();
        }
    }
}
