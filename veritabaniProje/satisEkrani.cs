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


namespace veritabaniProje
{
    public partial class satisEkrani : Form
    {
        public float totalPrice = 0;
        Entity.Context dbcontext = new Entity.Context();
        public int stsmusteriID;
        public satisEkrani()
        {
            InitializeComponent();
        }
        private void addID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char character = e.KeyChar;
            if (!Char.IsDigit(character))
            {
                e.Handled = true;
                MessageBox.Show("Sadece sayı giriniz!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void showIDText_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void addProductButton_Click(object sender, EventArgs e)
        {
            try
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
                    string gecis = urunAdi + " x " + newAddmiktar;
                    totalPrice += product.satisFiyat;
                    listBox1.Items.Add(gecis);
                    MessageBox.Show("Ürün sepete eklendi", "Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label3.Text = "Tutar toplamı : " + totalPrice;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ürün miktarı giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        public void deleteProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                string itemSelected = listBox1.SelectedItem.ToString();
                string[] selected = itemSelected.Split(' ');
                string selected1 = selected[0];
                var product = dbcontext.tUruns.SingleOrDefault(x => x.urunAdi == selected1);
                var password = dbcontext.tYoneticis.SingleOrDefault(x => x.ySifre == sifreText.Text);
                if (password == null)
                {
                    MessageBox.Show("Hatalı şifre girdiniz. Ürün silinemedi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    totalPrice -= product.satisFiyat;
                    label3.Text = "Tutar toplamı : " + totalPrice;
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Ürün seçilemedi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void satisEkrani_Load(object sender, EventArgs e)
        {

        }

        private void addID_TextChanged(object sender, EventArgs e)
        {

        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void debtButton_Click(object sender, EventArgs e)
        {
            //TODO: Formların hepsi aynı anda çalışıyor. Birisi kapandığında diğerinin açılması gerekiyor.
            var urunMiktar = new Entity.tUrun();
            satisMusteri stsmst = new satisMusteri();
            stsmst.Show();
            stsmusteriID = Convert.ToInt32(satisMusteri.musteriIdText);
            var musterii = dbcontext.tBorcs.FirstOrDefault(x => x.musteriId == stsmusteriID);
            if (musterii == null)
            {
                //TODO: Formların hepsi aynı anda çalışıyor. Birisi kapandığında diğerinin açılması gerekiyor.
                MusteriMenu ynmusteri = new MusteriMenu();
                ynmusteri.Show();
                satisMusteri stsmst1 = new satisMusteri();
                stsmst1.Show();
                //TODO: Formların hepsi aynı anda çalışıyor. Birisi kapandığında diğerinin açılması gerekiyor.
                dbcontext.SaveChanges();
                stsmusteriID = Convert.ToInt32(satisMusteri.musteriIdText);
                var musteriii = dbcontext.tBorcs.FirstOrDefault(x => x.musteriId == stsmusteriID);
                var borc = new Entity.tBorc();
                borc.musteriId = musteriii.musteriId;
                borc.borcMiktar = totalPrice;
                borc.borcTarihi = DateTime.Now;
                urunMiktar.miktar -= Convert.ToInt32(urunMiktar1.Text);
                borc.odenenMiktar = 0;
                dbcontext.tBorcs.Add(borc);
                dbcontext.SaveChanges();
            }
            else
            {
                var borc = new Entity.tBorc();
                borc.musteriId = musterii.musteriId;
                borc.borcMiktar += totalPrice;
                borc.borcTarihi = DateTime.Now;
                borc.urunMiktar += Convert.ToInt32(urunMiktar1.Text);
                urunMiktar.miktar -= Convert.ToInt32(urunMiktar1.Text);
                // borc.odenenMiktar = 0; - odenen miktarı 0 a çekiyorsun
                dbcontext.tBorcs.Add(borc);
                dbcontext.SaveChanges();

            }
            //TODO: Formların hepsi aynı anda çalışıyor. Birisi kapandığında diğerinin açılması gerekiyor.
            var satisCari = new Entity.tSatis();
            //satisCari.satisNo = 0;
            //satisCari.satisTuru = "Cari";
            satisCari.satisTutar = (float)totalPrice;
            dbcontext.tSatiss.Add(satisCari);
            dbcontext.SaveChanges();
            listBox1.Items.Clear();
            totalPrice = 0;
            listBox1.Items.Clear();
            listBox1.Items.Add("Sepet");
            listBox1.Items.Add("----------");
            label3.Text = "Tutar toplamı : " + totalPrice;
            MessageBox.Show("Satış Tamamlandı", "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void cashButton_Click(object sender, EventArgs e)
        {
            var urunKontrol = new Entity.tUrun();
            var satisPesin = new Entity.tSatis();
            long newAddId = Convert.ToInt64(addID.Text);
            var product = dbcontext.tUruns.SingleOrDefault(x => x.barkodNo == newAddId);
            var urunKontrol1 = dbcontext.tSatiss.FirstOrDefault(x => x.urunAdi == product.urunAdi);
            if (urunKontrol1 == null)
            {
                //satisPesin.satisNo = 0;
                //satisPesin.satisTuru = "Pesin";
                string urunAdi1 = product.urunAdi;
                satisPesin.urunAdi = urunAdi1;
                satisPesin.satisTutar = (float)totalPrice;
                satisPesin.satisMiktar = Convert.ToInt32(urunMiktar1.Text);
                dbcontext.tSatiss.Add(satisPesin);
                dbcontext.SaveChanges();
                totalPrice = 0;
                listBox1.Items.Clear();
                listBox1.Items.Add("Sepet");
                listBox1.Items.Add("----------");
                label3.Text = "Tutar toplamı : " + totalPrice;
                MessageBox.Show("Satış Tamamlandı", "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                satisPesin.satisTutar += (float)totalPrice;
                satisPesin.satisMiktar += Convert.ToInt32(urunMiktar1.Text);
                dbcontext.tSatiss.Add(satisPesin);
                dbcontext.SaveChanges();
                totalPrice = 0;
                listBox1.Items.Clear();
                listBox1.Items.Add("Sepet");
                listBox1.Items.Add("----------");
                label3.Text = "Tutar toplamı : " + totalPrice;
                MessageBox.Show("Satış Tamamlandı", "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }


        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
