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
        Entity.Context dbcontext = new Entity.Context();
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
                passwordText.PasswordChar = '\0';
            }

            else
            {
                passwordText.PasswordChar = '*';
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string cashierId1 = Convert.ToString(username.Text);
            string cashierPassword1 = Convert.ToString(passwordText.Text);
            var cashierId = dbcontext.tKasiyers.FirstOrDefault(x => x.kullaniciAdi == cashierId1);
            var cashierPassword = dbcontext.tKasiyers.FirstOrDefault(x => x.kullaniciSifre == cashierPassword1);
            if (cashierId != null && cashierPassword != null )
            {
                satisEkrani stk = new satisEkrani();
                stk.Show();
                this.Close();
            }
            else
            {
                label2.Text = "Lütfen geçerli bir kullanıcı adı veya parola giriniz";
            }
        }

        private void satisArayuzu_Load(object sender, EventArgs e)
        {
            passwordText.PasswordChar = '*';
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
