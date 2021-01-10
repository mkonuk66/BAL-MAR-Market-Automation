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
        void bekle(int saniye)
        {
            saniye = ((saniye + Convert.ToInt32(DateTime.Now.Second)) % 60);
            for (; ; )
            {
                if (saniye == DateTime.Now.Second) break;
            }
        }

        public satisEkrani()
        {
            //güncelleme

            InitializeComponent();
        }

        private void addID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char character = e.KeyChar;
            if (!Char.IsDigit(character))
            {
                e.Handled = true;
                MessageBox.Show("Sadece sayı giriniz");
            }
        }

        private void showIDText_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void addProductButton_Click(object sender, EventArgs e)
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
                totalPrice += product.satisFiyat;
                listBox1.Items.Add(gecis);
                MessageBox.Show("Ürün sepete eklendi", "Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label3.Text = "Tutar toplamı : " + totalPrice;
            }

        }

        public void deleteProductButton_Click(object sender, EventArgs e)
        {
            bilgileriDogrula bgd = new bilgileriDogrula();
            Int64 select = Convert.ToInt64(listBox1.SelectedItem.ToString());
            var product = dbcontext.tUruns.FirstOrDefault(x => x.barkodNo == select);
            totalPrice -= product.satisFiyat;
            label3.Text = "Tutar toplamı : " + totalPrice;
            listBox1.Items.Remove(listBox1.SelectedItem);
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
            var musterii = dbcontext.tBorcs.FirstOrDefault(x => x.musteriId == stsmusteriID);
            if (musterii == null)
            {
                yeniMusteriEkleme ynmusteri = new yeniMusteriEkleme();
                ynmusteri.Show();
                satisMusteri stsmst1 = new satisMusteri();
                stsmst1.Show();
                dbcontext.SaveChanges();
                stsmusteriID = Convert.ToInt32(satisMusteri.musteriIdText);
                var musteriii = dbcontext.tBorcs.FirstOrDefault(x => x.musteriId == stsmusteriID);
                var borc = new Entity.tBorc();
                borc.musteriId = musteriii.musteriId;
                borc.borcMiktar = totalPrice;
                borc.borcTarihi = DateTime.Now;
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
                // borc.odenenMiktar = 0; - odenen miktarı 0 a çekiyorsun
                dbcontext.tBorcs.Add(borc);
                dbcontext.SaveChanges();

            }
            //TODO: Formların hepsi aynı anda çalışıyor. Birisi kapandığında diğerinin açılması gerekiyor.
            var satisCari = new Entity.tSatis();
            //satisCari.satisNo = 0;
            satisCari.satisTuru = "Cari";
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
            var satisPesin = new Entity.tSatis();
            //satisPesin.satisNo = 0;
            satisPesin.satisTuru = "Pesin";
            satisPesin.satisTutar = (float)totalPrice;
            dbcontext.tSatiss.Add(satisPesin);
            dbcontext.SaveChanges();
            totalPrice = 0;
            listBox1.Items.Clear();
            listBox1.Items.Add("Sepet");
            listBox1.Items.Add("----------");
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
