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

        private void cashButton_Click(object sender, EventArgs e)
        {
            Form3satis frt = new Form3satis();
            frt.Show();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(addID.Text);
            StreamWriter write = File.AppendText("M:\\save.txt");
            write.WriteLine(addID.Text);
            
            write.Close();
        }

        public void deleteProductButton_Click(object sender, EventArgs e)
        {

            bilgileriDogrula bgd = new bilgileriDogrula();
            // bgd.Show();
            listBox1.Items.Remove(listBox1.SelectedItem);
            /*if ()
            {
                bekle(3);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else if (bilgileriDogrula.a.Equals(false))
            {
                bekle(3);
                MessageBox.Show("lUTFEN BİLGİLERİNİZİ DOĞRU GİRİNİZ");
            }*/
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
    }
}
