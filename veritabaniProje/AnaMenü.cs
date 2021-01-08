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
    public partial class AnaMenü : Form
    {
        public AnaMenü()
        {
            InitializeComponent();
            sidepanel.Height = anamenubuton.Height;
            sidepanel.Top = anamenubuton.Top;
            anaMenu1.BringToFront();
        }

        private void AnaMenü_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void anamenubuton_Click(object sender, EventArgs e)
        {
            sidepanel.Height = anamenubuton.Height;
            sidepanel.Top = anamenubuton.Top;
            anaMenu1.BringToFront();
        }

        private void musteributon_Click(object sender, EventArgs e)
        {
            sidepanel.Height = musteributon.Height;
            sidepanel.Top = musteributon.Top;
            musteriMenu1.BringToFront();
        }

        private void kapatmabutonu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
