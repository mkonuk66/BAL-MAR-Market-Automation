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
    public partial class AnaMenüGorunum : Form
    {
        public AnaMenüGorunum()
        {
            InitializeComponent();
            sidepanel.Height = anamenubuton.Height;
            sidepanel.Top = anamenubuton.Top;
            anaMenu1.BringToFront();
        }

        private void AnaMenü_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            tarih_saat_bilgi.Text = DateTime.Now.ToString();
        }

        private void stokbuton_Click(object sender, EventArgs e)
        {
            sidepanel.Height = stokbuton.Height;
            sidepanel.Top = stokbuton.Top;
            stokIslemleri1.BringToFront();
        }

        private void raporbuton_Click(object sender, EventArgs e)
        {
            sidepanel.Height = raporbuton.Height;
            sidepanel.Top = raporbuton.Top;
            raporAlim1.BringToFront();
        }

        private void borcButon_Click(object sender, EventArgs e)
        {
            sidepanel.Height = borcButon.Height;
            sidepanel.Top = borcButon.Top;
            borcIslemleri1.BringToFront();
        }

        private void satisButon_Click(object sender, EventArgs e)
        {
            sidepanel.Height = satisButon.Height;
            sidepanel.Top = satisButon.Top;
            satisİslemleri1.BringToFront();
        }

        private void borcIslemleri1_Load(object sender, EventArgs e)
        {

        }

        private void borcIslemleri1_Load_1(object sender, EventArgs e)
        {

        }

        private void musteriMenu1_Load(object sender, EventArgs e)
        {

        }
    }
}
