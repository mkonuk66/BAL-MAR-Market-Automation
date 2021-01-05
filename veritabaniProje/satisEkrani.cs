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
            StreamWriter write = File.AppendText("M:\\save.txt");
            write.WriteLine(addID.Text);
            showIDText.Text = addID.Text;
            write.Close();
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            this.Close();
            bilgileriDogrula bgd = new bilgileriDogrula();
            bgd.Show();
        }

        private void satisEkrani_Load(object sender, EventArgs e)
        {

        }

        private void addID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
