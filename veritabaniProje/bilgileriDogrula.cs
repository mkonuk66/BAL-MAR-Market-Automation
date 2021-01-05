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
        public bilgileriDogrula()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Muhammet" || textBox2.Text == "123456")
            {
                satisEkrani ste = new satisEkrani();
                ste.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen parola veya kullanıcı adını doğru giriniz");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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
