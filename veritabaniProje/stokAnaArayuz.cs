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
    public partial class stokAnaArayuz : Form
    {
        public stokAnaArayuz()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stokDurum stkDurum = new stokDurum();
            stkDurum.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stokEkle stkEkle = new stokEkle();
            stkEkle.Show();
        }

        private void stokAnaArayuz_Load(object sender, EventArgs e)
        {
            label1.Text = "Stok Arayüzüne Hoşgeldiniz";
            
        }
    }
}
