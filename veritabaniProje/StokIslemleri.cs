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
    public partial class StokIslemleri : UserControl
    {
        public StokIslemleri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                stokDurum stkDurum = new stokDurum();
                stkDurum.Show();
            }
            catch (Exception)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                stokEkle stkEkle1 = new stokEkle();
                stkEkle1.Show();
            }
            catch (Exception)
            {

            }

        }

        private void StokIslemleri_Load(object sender, EventArgs e)
        {

        }
    }
}
