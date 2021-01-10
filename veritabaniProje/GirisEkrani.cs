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
    public partial class GirisEkrani : Form
    {
        Entity.Context dbcontext = new Entity.Context();
        public GirisEkrani()
        {
            InitializeComponent();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }

            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            textBox2.BackColor = SystemColors.Control;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel3.BackColor = SystemColors.Control;
            textBox1.BackColor = SystemColors.Control;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cashierId1 = Convert.ToString(textBox1.Text);
            string cashierPassword1 = Convert.ToString(textBox2.Text);
            var cashierId = dbcontext.tKasiyers.FirstOrDefault(x => x.kullaniciAdi == cashierId1);
            var cashierPassword = dbcontext.tKasiyers.FirstOrDefault(x => x.kullaniciSifre == cashierPassword1);
            if (cashierId != null && cashierPassword != null)
            {
                this.Hide();
                AnaMenü ana1 = new AnaMenü();
                ana1.Show();
            }
            else
            {
                label4.Text = "Lütfen geçerli bir kullanıcı adı veya parola giriniz";
            }
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}
