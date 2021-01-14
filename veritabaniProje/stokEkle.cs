using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using veritabaniProje.Entity;
using System.Data.Sql;
using System.Data.SqlClient;

namespace veritabaniProje
{
    public partial class stokEkle : Form
    {
        Entity.Context dbcontext = new Entity.Context();
        public double karMiktari;
        public stokEkle()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            //OpenFileDialog acildiginda masaustu acılacak
            file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //filtre olarak .txt dosyalarını bulacak
            file.Filter = "Text Files|*.txt";
            file.ShowDialog();
            //Okunacak dosyanın yolu
            string path = file.FileName;
            //Dosyadan okuma işlemi satır satır gerçekleştiriliyor.
            string[] satir = System.IO.File.ReadAllLines(path, Encoding.GetEncoding("windows-1254"));
            //Dosya yolunu kontrol için ekrana bastırıyorum
            MessageBox.Show("Seçilen dosyanın yolu : \n" + file.FileName, "Dosya başarıyla seçildi.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            file.Reset();
            for (int i = 0; i < satir.Length; i += 7)
            {
                //irsaliye eklemesini yapıyoruz
                var irsaliye = new Entity.tIrsaliye();
                var urun = new Entity.tUrun();
                var tedarikci = new Entity.tTedarikci();
                irsaliye.irsaliyeID = Convert.ToInt32(satir[i]);
                irsaliye.girisTarih = Convert.ToDateTime(satir[i + 1]);
                irsaliye.urunId = Convert.ToInt32(satir[i + 2]);
                irsaliye.girdiFiyat = (float)Convert.ToDouble(satir[i + 3]);
                irsaliye.miktar = Convert.ToInt32(satir[i + 4]);
                irsaliye.tedarikciId = Convert.ToInt32(satir[i + 5]);
                irsaliye.urunAdi = Convert.ToString(satir[i + 6]);
                dbcontext.tIrsaliyes.Add(irsaliye);
                var product = dbcontext.tUruns.FirstOrDefault(x => x.urunAdi == irsaliye.urunAdi);
                if (product == null)
                {
                    //Ürün yoksa ürün eklemesini yapıyoruz
                    urun.urunId = irsaliye.urunId;
                    urun.barkodNo = Convert.ToInt64("855" + irsaliye.urunId + "555");
                    urun.urunAdi = irsaliye.urunAdi;
                    urun.miktar = irsaliye.miktar;
                    double cevrim = Convert.ToDouble(irsaliye.girdiFiyat + karMiktari);
                    cevrim = Math.Round(cevrim, 2);
                    urun.satisFiyat = cevrim;
                    dbcontext.tUruns.Add(urun);
                    if (i == satir.Length - 7)
                    {
                        MessageBox.Show("Ürün kayıt edildi.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    //Ürün varsa güncellemesini yapıyoruz
                    product.miktar += irsaliye.miktar;
                    product.satisFiyat = (float)Convert.ToDouble(irsaliye.girdiFiyat + karMiktari);
                    if (i == satir.Length - 7)
                    {
                        MessageBox.Show("Ürün güncellendi", "Stok Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                dbcontext.SaveChanges();
                //Tedarikci yoksa tedarikci ekliyoruz
                tedarikci.tedarikciId = irsaliye.tedarikciId;
                tedarikci.borcMiktar = (float)Convert.ToDouble(irsaliye.miktar * irsaliye.girdiFiyat);
                tedarikci.girisTarihi = DateTime.Now.ToShortDateString();
                dbcontext.tTedarikcis.Add(tedarikci);
                dbcontext.SaveChanges();
                var tedarikciodeme1 = new Entity.ttedarikciOdeme();
                var tedarikciodeme = dbcontext.ttedarikciOdemes.FirstOrDefault(x => x.tedarikciID == irsaliye.tedarikciId);
                if(tedarikciodeme == null)
                {
                    tedarikciodeme1.tedarikciID = irsaliye.tedarikciId;
                    tedarikciodeme1.toplamBorc = (float)Convert.ToDouble(irsaliye.miktar * irsaliye.girdiFiyat);
                    dbcontext.ttedarikciOdemes.Add(tedarikciodeme1);
                    dbcontext.SaveChanges();
                }
                else
                {
                    tedarikciodeme.toplamBorc += (float)Convert.ToDouble(irsaliye.miktar * irsaliye.girdiFiyat);
                    tedarikciodeme.kalanMiktar += (float)Convert.ToDouble(irsaliye.miktar * irsaliye.girdiFiyat);
                    dbcontext.SaveChanges();
                }
            }
        }
        private void stokEkle_Load(object sender, EventArgs e)
        {

        }

        private void stokEkle_Load_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stokDurum stkDurum1 = new stokDurum();
            stkDurum1.Show();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            stokDurum stkdurum1 = new stokDurum();
            stkdurum1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            karMiktari = Convert.ToDouble(karPayi.Text);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void stokEkle_Load_2(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'veritabaniProjeDataSet2.tIrsaliyes' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tIrsaliyesTableAdapter.Fill(this.veritabaniProjeDataSet2.tIrsaliyes);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}