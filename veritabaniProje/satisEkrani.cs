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
        public int toplammiktar = 0;
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
            if(urunMiktar1.Text != null) {
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
                    totalPrice += product.satisFiyat;
                    listBox1.Items.Add(gecis);
                    MessageBox.Show("Ürün sepete eklendi", "Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label3.Text = "Tutar toplamı : " + totalPrice;
                }
            }
            else
            {
                MessageBox.Show("Ürün miktarı giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void deleteProductButton_Click(object sender, EventArgs e)
        {
            //try
            //{
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
            //}
            //catch(Exception)
            //{
            //    MessageBox.Show("Ürün seçilemedi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

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
            satisMusteri stsmst = new satisMusteri();
            stsmst.Show();
            stsmusteriID = Convert.ToInt32(satisMusteri.musteriIdText);
            var satis = new Entity.tSatis();
            var musterii = dbcontext.tMusteris.FirstOrDefault(x => x.musteriId == stsmusteriID);
            if (musterii == null)
            {
                //TODO: Formların hepsi aynı anda çalışıyor. Birisi kapandığında diğerinin açılması gerekiyor.
                MessageBox.Show("Lütfen yeni müşteri oluşturunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MusteriMenu ynmusteri = new MusteriMenu();
                ynmusteri.Show();
            }
            else
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    string itemSelected = listBox1.Items[i].ToString();
                    string[] selected = itemSelected.Split(' ');
                    string selected1 = selected[0];
                    int selected2 = Convert.ToInt32(selected[2]);
                    var urunMiktari1 = new Entity.tUrun();
                    var urunMiktari12 = dbcontext.tUruns.FirstOrDefault(x => x.urunAdi == selected1);
                    var satissorgu = dbcontext.tSatiss.FirstOrDefault(x => x.urunAdi == selected1);
                    if (urunMiktari12 != null)
                    {
                        urunMiktari12.miktar -= selected2;
                        toplammiktar += selected2;
                        if(satissorgu == null)
                        {
                            satis.satisTutar = Convert.ToSingle(urunMiktari12.satisFiyat * selected2);
                            satis.urunAdi = urunMiktari12.urunAdi;
                            satis.satisMiktar = selected2;
                            dbcontext.tSatiss.Add(satis);
                            dbcontext.SaveChanges();
                        }
                        else
                        {
                            urunMiktari12.miktar -= selected2;
                            satissorgu.satisTutar += Convert.ToSingle(urunMiktari12.satisFiyat * selected2);
                            satissorgu.satisMiktar += selected2;
                            dbcontext.SaveChanges();
                        }
                        dbcontext.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Hata");
                    }
                }
                var borc = new Entity.tBorc();
                var borc1 = new Entity.tMusteri();
                var satisCari = new Entity.tSatis();
                borc.musteriId = musterii.musteriId;
                borc.borcMiktar = totalPrice;
                borc.borcTarihi = DateTime.Now;
                borc.urunMiktar = toplammiktar;
                borc1.musteriBorc += totalPrice; // - odenen miktarı 0 a çekiyorsun
                dbcontext.tBorcs.Add(borc);
                dbcontext.SaveChanges();
            }
            //TODO: Formların hepsi aynı anda çalışıyor. Birisi kapandığında diğerinin açılması gerekiyor.
            //satisCari.satisNo = 0;
            //satisCari.satisTuru = "Cari";
            listBox1.Items.Clear();
            totalPrice = 0;
            listBox1.Items.Clear();
            //listBox1.Items.Add("Sepet");
            //listBox1.Items.Add("----------");
            label3.Text = "Tutar toplamı : " + totalPrice;
            MessageBox.Show("Satış Tamamlandı", "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

        private void cashButton_Click(object sender, EventArgs e)
        {

            var satis = new Entity.tSatis();
            for (int i=0; i < listBox1.Items.Count; i++)
            {
                string itemSelected = listBox1.Items[i].ToString();
                string[] selected = itemSelected.Split(' ');
                string selected1 = selected[0];
                int selected2 = Convert.ToInt32(selected[2]);
                var urunMiktari1 = new Entity.tUrun();
                var urunMiktari12 = dbcontext.tUruns.FirstOrDefault(x => x.urunAdi == selected1);
                var satissorgu1 = dbcontext.tSatiss.FirstOrDefault(x => x.urunAdi == selected1);
                if (urunMiktari12 != null)
                {
                    urunMiktari12.miktar -= selected2;
                    toplammiktar += selected2;
                    if (satissorgu1 == null)
                    {
                        satis.satisTutar = urunMiktari12.satisFiyat * Convert.ToSingle(selected2);
                        satis.urunAdi = urunMiktari12.urunAdi;
                        satis.satisMiktar = selected2;
                        dbcontext.tSatiss.Add(satis);
                        dbcontext.SaveChanges();
                    }
                    else
                    {
                        satissorgu1.satisTutar += Convert.ToSingle(urunMiktari12.satisFiyat * selected2);
                        satissorgu1.satisMiktar += selected2;
                        dbcontext.SaveChanges();
                    }
                    dbcontext.SaveChanges();
                    listBox1.Items.Clear();
                    //listBox1.Items.Add("Sepet");
                    //listBox1.Items.Add("----------");
                    label3.Text = "Tutar toplamı : " + totalPrice;
                    MessageBox.Show("Satış Tamamlandı", "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    MessageBox.Show("Hata");
                }
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
