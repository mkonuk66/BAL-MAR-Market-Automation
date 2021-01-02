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

        private void usernameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordText_TextChanged(object sender, EventArgs e)
        {

        }

        private void showPasswordBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordBox.Checked)
            {
                passwordText.UseSystemPasswordChar = true;
            }

            else
            {
                passwordText.UseSystemPasswordChar = false;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(usernameText.Text == "Muhammet" && passwordText.Text == "123456")
            {
                satisEkrani stk = new satisEkrani();
                stk.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli parola veya kullanıcı adını giriniz");
            }
        }
    }
}
