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
    public partial class bilgileriDogrula : Form
    {

        bool Dogrulama()
        {
            if (textBox1.Text == "Muhammet" && textBox2.Text == "123456")
            {
                return true;
                this.Close();
            }
            else
            {
                return false;
            }
        }
        public static int a;
            public bilgileriDogrula()
        {
            InitializeComponent();
        }

        /*public void Dogrulasana()
        {
            Dogrulama();
        }*/
        public void button1_Click(object sender, EventArgs e)
        {
           /* !!!!
            Dogrulama();
            this.Close();*/
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
         /*   if (textBox1.Text == "Muhammet" && textBox2.Text == "123456")
            {
                satisEkrani ste = new satisEkrani();
                ste.Show();
                this.Close(); Buraya bu kod yazılırsa giriş butonuna basılmadan giriş yapar
            }*/
        }

        private void secretPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (secretPassword.Checked)
            {
                textBox2.UseSystemPasswordChar = true;
            }

            else
            {
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void bilgileriDogrula_Load(object sender, EventArgs e)
        {
            
        }
    }
}
