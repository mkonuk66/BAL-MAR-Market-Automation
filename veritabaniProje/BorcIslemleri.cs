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
    public partial class BorcIslemleri : UserControl
    {
        Entity.Context dbcontext = new Entity.Context();
        public BorcIslemleri()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            kayitliMusteri kym = new kayitliMusteri();
            kym.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            kayitliTedarikci kyt = new kayitliTedarikci();
            kyt.Show();
        }

        private void BorcIslemleri_Load(object sender, EventArgs e)
        {

        }

       
    }
}
