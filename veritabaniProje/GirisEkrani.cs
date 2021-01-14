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
            //Şifre gizleme gösterme durumunda neler olacağı kontrolü
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
            
           //Klasik bir giriş ekranı. Girilen değerlerin daha önce veritabanımıza kayıt edilmesini kontrol ediyoruz.
             string managerId1 = Convert.ToString(textBox1.Text);
             string managerPassword1 = Convert.ToString(textBox2.Text);
             var managerId = dbcontext.tYoneticis.FirstOrDefault(x => x.yKullaniciAdi == managerId1);
             var managerPassword = dbcontext.tYoneticis.FirstOrDefault(x => x.ySifre == managerPassword1);
             if (managerId != null && managerPassword != null)
             {
                 this.Hide();
                 AnaMenüGorunum ana1 = new AnaMenüGorunum();
                 ana1.Show();
             }
             else
             {
                 label4.Text = "Lütfen geçerli bir kullanıcı adı veya parola giriniz";
             }
         
        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {
            //Şifre görünümünü düzenliyor.
            textBox2.PasswordChar = '*';

            //Yöneticinin bir kere oluşturulması için eklenmiştir.
            /*var yonetici1 = new Entity.tYonetici();
            yonetici1.yoneticiID = 1;
            yonetici1.yKullaniciAdi = "yonetici";
            yonetici1.ySifre = "1234";
            dbcontext.tYoneticis.Add(yonetici1);
            dbcontext.SaveChanges(); */
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
