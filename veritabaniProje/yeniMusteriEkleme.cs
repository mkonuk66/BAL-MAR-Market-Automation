using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data.Sql;

namespace veritabaniProje
{
    public partial class yeniMusteriEkleme : Form
    {
        Entity.Context dbcontext = new Entity.Context();
        public yeniMusteriEkleme()
        {
            InitializeComponent();
        }
        //static string musteriEkle = "Server=DESKTOP-HU112LL;Database=veritabaniProje;Trusted_Connection=True;";
        //SqlConnection musekleme = new SqlConnection(musteriEkle);
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string tarih = kayittarihi.Value.ToShortDateString();
            var musteri = new Entity.tMusteri();
            musteri.musteriId = 0;
            musteri.musteriAdi = musteriadi.Text;
            musteri.musteriSoyadi = musterisoyad.Text;
            musteri.musteriGSM = telno.Text;
            musteri.kayitTarihi = tarih;
            musteri.musteriBorc = 0;
            dbcontext.tMusteris.Add(musteri);
            dbcontext.SaveChanges();
            MessageBox.Show("Müşteri Eklendi. Numarası : "+musteri.musteriId+"", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char character = e.KeyChar;
            if (!Char.IsDigit(character))
            {
                e.Handled = true;
                MessageBox.Show("Sadece sayı giriniz");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void yeniMusteriEkleme_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
