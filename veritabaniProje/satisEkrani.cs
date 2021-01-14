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
using System.Text.RegularExpressions;


namespace veritabaniProje
{
    public partial class satisEkrani : Form
    {
        public double totalPrice = 0;
        Entity.Context dbcontext = new Entity.Context();
        public int stsmusteriID;
        public satisEkrani()
        {
            InitializeComponent();
        }
        private void addID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Regex.IsMatch(addID.Text, "[^0-9\b]+");
            if (e.Handled == true)
            {
                MessageBox.Show("Sadece sayı giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void showIDText_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void addProductButton_Click(object sender, EventArgs e)
        {
            //Ürün miktarı ve girilen barkod numarasına göre ürünümüzü sepete ekleyip ,ürün tutarını toplam tutarımıza ekliyoruz.
            if (urunMiktar1.Text != null)
            {
                long newAddmiktar = Convert.ToInt64(urunMiktar1.Text);
                long newAddId = Convert.ToInt64(addID.Text);
                var product = dbcontext.tUruns.SingleOrDefault(x => x.barkodNo == newAddId);
                if (product == null)
                {
                    MessageBox.Show("Girilen barkod no'ya ait ürün bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string urunAdi = product.urunAdi;
                    string gecis = urunAdi + " x " + urunMiktar1.Text;
                    totalPrice += product.satisFiyat * Convert.ToDouble(urunMiktar1.Text);
                    listBox1.Items.Add(gecis);
                    MessageBox.Show("Ürün sepete eklendi", "Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label3.Text = "Tutar toplamı : " + totalPrice + "";
                }
            }
            else
            {
                MessageBox.Show("Ürün miktarı giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            urunMiktar1.Clear();
            addID.Clear();
        }
        public void deleteProductButton_Click(object sender, EventArgs e)
        {
            //Ürün silmeyi yönetici şifremiz ile yapıyoruz. Ve toplam tutardan silinen ürünün değerini çıkarıyoruz.
            string itemSelected = listBox1.SelectedItem.ToString();
            string[] selected = itemSelected.Split(' ');
            string selected1 = selected[0];
            int selected2 = Convert.ToInt32(selected[2]);
            var product = dbcontext.tUruns.SingleOrDefault(x => x.urunAdi == selected1);
            var password = dbcontext.tYoneticis.SingleOrDefault(x => x.ySifre == sifreText.Text);
            if (password == null)
            {
                MessageBox.Show("Hatalı şifre girdiniz. Ürün silinemedi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double al = Convert.ToDouble(product.satisFiyat);
                totalPrice -=  Convert.ToSingle(al * selected2);
                label3.Text = "Tutar toplamı : " + totalPrice + "";
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void satisEkrani_Load(object sender, EventArgs e)
        {
            sifreText.PasswordChar = '*';
        }

        private void addID_TextChanged(object sender, EventArgs e)
        {

        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void debtButton_Click(object sender, EventArgs e)
        {
            //Cari satış ,satış veritabanına ekleniyor.
            //Müşteri mevcut değilse yeni müşteri oluşturuluyor. Ardından borç ekleniyor.
            //Mevcut bir müşteri ise borcuna ekleme yapılıyor.
            stsmusteriID = Convert.ToInt32(musArama.Text);
            var satis = new Entity.tSatis();
            var musterii = dbcontext.tMusteris.FirstOrDefault(x => x.musteriId == stsmusteriID);
            if (musterii == null)
            {
                MessageBox.Show("Lütfen yeni müşteri oluşturunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 2; i < listBox1.Items.Count; i++)
                {
                    string itemSelected = listBox1.Items[i].ToString();
                    string[] selected = itemSelected.Split(' ');
                    string selected1 = selected[0];
                    int selected2 = Convert.ToInt32(selected[2]);
                    var urunMiktari12 = dbcontext.tUruns.FirstOrDefault(x => x.urunAdi == selected1);
                    if (urunMiktari12 != null)
                    {
                        urunMiktari12.miktar -= selected2;
                        satis.satisTutar = Convert.ToSingle(urunMiktari12.satisFiyat * selected2);
                        satis.urunAdi = urunMiktari12.urunAdi;
                        satis.satisMiktar = selected2;
                        satis.satisTarih = DateTime.Now.ToShortDateString();
                        dbcontext.tSatiss.Add(satis);
                        dbcontext.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Hata");
                    }
                }
                var borc = new Entity.tBorc();
                borc.musteriId = musterii.musteriId;
                borc.borcMiktar = Convert.ToSingle(totalPrice);
                borc.borcTarihi = DateTime.Now.ToShortDateString();
                musterii.musteriBorc += Convert.ToSingle(totalPrice);  // - odenen miktarı 0 a çekiyorsun
                musterii.kalanBorc += Convert.ToSingle(totalPrice);
                dbcontext.tBorcs.Add(borc);
                dbcontext.SaveChanges();
                listBox1.Items.Clear();
                totalPrice = 0;
                listBox1.Items.Clear();
                listBox1.Items.Add("Sepet");
                listBox1.Items.Add("----------");
                totalPrice = 0;
                label3.Text = "Tutar toplamı : " + totalPrice;
                MessageBox.Show("Satış Tamamlandı", "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                musArama.Clear();
            }
        }

        private void cashButton_Click(object sender, EventArgs e)
        {
            //Peşin satış veritabanına ekleniyor.
            var satis = new Entity.tSatis();
            for (int i = 2; i < listBox1.Items.Count; i++)
            {
                string itemSelected = listBox1.Items[i].ToString();
                string[] selected = itemSelected.Split(' ');
                string selected1 = selected[0];
                int selected2 = Convert.ToInt32(selected[2]);
                var urunMiktari12 = dbcontext.tUruns.FirstOrDefault(x => x.urunAdi == selected1);
                if (urunMiktari12 != null)
                {
                    urunMiktari12.miktar -= selected2;
                    satis.satisTutar = Convert.ToSingle(urunMiktari12.satisFiyat * selected2);
                    satis.urunAdi = urunMiktari12.urunAdi;
                    satis.satisMiktar = selected2;
                    satis.satisTarih = DateTime.Now.ToShortDateString();
                    dbcontext.tSatiss.Add(satis);
                    dbcontext.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Hata");
                }
            }
            dbcontext.SaveChanges();
            listBox1.Items.Clear();
            listBox1.Items.Add("Sepet");
            listBox1.Items.Add("----------");
            totalPrice = 0;
            label3.Text = "Tutar toplamı : " + totalPrice;
            MessageBox.Show("Satış Tamamlandı", "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }


        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yeniMusteriEkleme yme = new yeniMusteriEkleme();
            yme.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void sifreText_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                sifreText.PasswordChar = '\0';
            }
            else
            {
                sifreText.PasswordChar = '*';
            }
        }
    }
}
