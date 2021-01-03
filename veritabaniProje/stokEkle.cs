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

namespace veritabaniProje
{
    public partial class stokEkle : Form
    {
        Entity.Context dbcontext = new Entity.Context();
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
                MessageBox.Show("Seçilen dosyanın yolu : \n" + file.FileName  , "Dosya başarıyla seçildi.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                file.Reset();
                for (int i = 0; i < satir.Length; i += 6)
                {
                    var irsaliye = new Entity.tIrsaliye();
                    irsaliye.irsaliyeID = Convert.ToInt32(satir[i]);
                    irsaliye.girisTarih = Convert.ToDateTime(satir[i + 1]);
                    irsaliye.urunId = Convert.ToInt32(satir[i + 2]);
                    irsaliye.girdiFiyat = (float)Convert.ToDouble(satir[i + 3]);
                    irsaliye.miktar = Convert.ToInt32(satir[i + 4]);
                    irsaliye.tedarikciId = Convert.ToInt32(satir[i + 5]);
                    dbcontext.tIrsaliyes.Add(irsaliye);
                    dbcontext.SaveChanges();
                }
                MessageBox.Show("Ürün kayıt edildi.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //dataGridView1.DataSource = dbcontext.tIrsaliyes.ToList();
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
    }
}
