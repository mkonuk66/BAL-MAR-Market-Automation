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
            //try catch ile path değişkeni null döndüğünde hata vermesini engelledik
            try
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
                        urun.urunId = irsaliye.urunId;
                        urun.barkodNo = Convert.ToInt64("8" + "55" + irsaliye.urunId + "55" + irsaliye.urunId + "55");
                        urun.urunAdi = irsaliye.urunAdi;
                        urun.miktar = irsaliye.miktar;
                        urun.satisFiyat = (float)Convert.ToDouble(irsaliye.girdiFiyat + karMiktari);                       
                        dbcontext.tUruns.Add(urun);
                        if (i == satir.Length - 7)
                        {
                            MessageBox.Show("Ürün kayıt edildi.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        
                    }
                    else
                    {
                        product.miktar += irsaliye.miktar;
                        product.satisFiyat = (float)Convert.ToDouble(irsaliye.girdiFiyat + karMiktari);
                        if (i == satir.Length - 7)
                        {
                            MessageBox.Show("Ürün güncellendi", "Stok Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        
                    }
                    dbcontext.SaveChanges();

                    var product1 = dbcontext.tTedarikcis.FirstOrDefault(x => x.tedarikciId == irsaliye.tedarikciId);
                    if (product1 == null)
                    {
                        tedarikci.tedarikciId = irsaliye.tedarikciId;
                        tedarikci.urunAdi = irsaliye.urunAdi;
                        tedarikci.urunId = irsaliye.urunId;
                        tedarikci.urunMiktar = irsaliye.miktar;
                        tedarikci.borcMiktar = (float)Convert.ToDouble(irsaliye.miktar * irsaliye.girdiFiyat);
                    }
                    else
                    {
                        tedarikci.urunMiktar += irsaliye.miktar;
                        tedarikci.borcMiktar += (float)Convert.ToDouble(irsaliye.miktar * irsaliye.girdiFiyat);
                    }
                }


            }
            catch (Exception) // Hatayı yakaladık
            {
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
            // TODO: Bu kod satırı 'veritabaniProjeDataSetIrsaliye2.tIrsaliyes' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tIrsaliyesTableAdapter1.Fill(this.veritabaniProjeDataSetIrsaliye2.tIrsaliyes);
            //// TODO: Bu kod satırı 'veritabaniProjeDataSetIrsaliye.tIrsaliyes' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.tIrsaliyesTableAdapter.Fill(this.veritabaniProjeDataSetIrsaliye.tIrsaliyes);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}