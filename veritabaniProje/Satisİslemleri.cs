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
    public partial class Satisİslemleri : UserControl
    {
        Entity.Context dbcontext = new Entity.Context();
        public Satisİslemleri()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            panel1.BackColor = Color.White;
            panel2.BackColor = SystemColors.Control;
            textBox2.BackColor = SystemColors.Control;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel1.BackColor = SystemColors.Control;
            textBox1.BackColor = SystemColors.Control;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = true;
            }

            else
            {
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* string cashierId1 = Convert.ToString(textBox1.Text);
            string cashierPassword1 = Convert.ToString(textBox2.Text);
            var cashierId = dbcontext.tKasiyers.FirstOrDefault(x => x.kullaniciAdi == cashierId1);
            var cashierPassword = dbcontext.tKasiyers.FirstOrDefault(x => x.kullaniciSifre == cashierPassword1);
            if (cashierId != null && cashierPassword != null)
            {
                satisEkrani ste = new satisEkrani();
                ste.Show();
            }
            else
            {
                label2.Text = "Lütfen geçerli bir kullanıcı adı veya parola giriniz";
            }
            */
            
        }

        private void Satisİslemleri_Load(object sender, EventArgs e)
        {
            //textBox2.PasswordChar = '*';
            //var kasiyer = new Entity.tKasiyer();
            //kasiyer.kasiyerId = 1;
            //kasiyer.kullaniciAdi = "mehmetEmin";
            //kasiyer.kullaniciSifre = "1234";
            //dbcontext.tKasiyers.Add(kasiyer);
            //dbcontext.SaveChanges();
            //var kasiyer2 = new Entity.tKasiyer();
            //kasiyer2.kasiyerId = 2;
            //kasiyer2.kullaniciAdi = "muhammetMustafa";
            //kasiyer2.kullaniciSifre = "1234";
            //dbcontext.tKasiyers.Add(kasiyer2);
            //dbcontext.SaveChanges();
            //var kasiyer3 = new Entity.tKasiyer();
            //kasiyer3.kasiyerId = 3;
            //kasiyer3.kullaniciAdi = "ibrahim";
            //kasiyer3.kullaniciSifre = "1234";
            //dbcontext.tKasiyers.Add(kasiyer3);
            //dbcontext.SaveChanges();
            //var kasiyer4 = new Entity.tKasiyer();
            //kasiyer4.kasiyerId = 4;
            //kasiyer4.kullaniciAdi = "oguzcan";
            //kasiyer4.kullaniciSifre = "1234";
            //dbcontext.tKasiyers.Add(kasiyer4);
            //dbcontext.SaveChanges();
        }
    }
}
