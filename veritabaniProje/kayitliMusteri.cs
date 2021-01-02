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
    public partial class kayitliMusteri : Form
    {
        public kayitliMusteri()
        {
            InitializeComponent();
        }

        public static string gonderilecekveri;
        private void button1_Click(object sender, EventArgs e)
        {
            gonderilecekveri = textBox1.Text;
            birMusterininBorcDurumu f2 = new birMusterininBorcDurumu ();
            f2.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
