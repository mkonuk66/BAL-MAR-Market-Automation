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
    public partial class stokEkle : Form
    {
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
            MessageBox.Show("Açılan dosyanın yolu : \n" + file.FileName);
            file.Reset();
        }
    }
}
