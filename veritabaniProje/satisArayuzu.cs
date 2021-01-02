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
    public partial class satisArayuzu : Form
    {
        public satisArayuzu()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //usernameText
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //passwordText
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //loginButton
            if (usernameText.Text == "Muhammet" || passwordText.Text == "123456")
            {
                satisEkrani ste = new satisEkrani();
                ste.Show();
                this.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //showPasswordBox
            if (showPasswordBox.Checked)
            {
                passwordText.UseSystemPasswordChar = true;
            }
            else
            {
                passwordText.UseSystemPasswordChar = false;
            }
        }
    }
}
