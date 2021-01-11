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
          

            string managerId1 = Convert.ToString(textBox1.Text);
            string managerPassword1 = Convert.ToString(textBox2.Text);
            var managerId = dbcontext.tYoneticis.FirstOrDefault(x => x.yKullaniciAdi == managerId1);
            var managerPassword = dbcontext.tYoneticis.FirstOrDefault(x => x.ySifre == managerPassword1);
            if (managerId != null && managerPassword != null)
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

        private void GirisEkrani_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
           /*
            var yonetici1 = new Entity.tYonetici();
            //Yoneticilerin bir kez eklenmesi için oluşturuldu.
                yonetici1.yoneticiID = 1;
                yonetici1.yKullaniciAdi = "yMehmetEmin";
                yonetici1.ySifre = "1234";
                dbcontext.tYoneticis.Add(yonetici1);
                dbcontext.SaveChanges();
                var yonetici2 = new Entity.tYonetici();
                yonetici2.yoneticiID = 2;
                yonetici2.yKullaniciAdi = "yIbrahim";
                yonetici2.ySifre = "1234";
                dbcontext.tYoneticis.Add(yonetici2);
                dbcontext.SaveChanges();
                var yonetici3 = new Entity.tYonetici();
                yonetici3.yoneticiID = 3;
                yonetici3.yKullaniciAdi = "yMuhammetMustafa";
                yonetici3.ySifre = "1234";
                dbcontext.tYoneticis.Add(yonetici3);
                dbcontext.SaveChanges();
                var yonetici4 = new Entity.tYonetici();
                yonetici4.yoneticiID = 4;
                yonetici4.yKullaniciAdi = "yOguzcan";
                yonetici4.ySifre = "1234";
                dbcontext.tYoneticis.Add(yonetici4);
                dbcontext.SaveChanges();
            //Yoneticilerin bir kez eklenmesi için oluşturuldu. */
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
