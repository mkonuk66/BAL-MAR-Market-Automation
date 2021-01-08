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
        public double totalPrice = 0.0;
        Entity.Context dbcontext = new Entity.Context();
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
            long newAddId = Convert.ToInt64(addID.Text); 
            var product = dbcontext.tUruns.SingleOrDefault(x => x.barkodNo == newAddId);
            if (product == null)
            {
                MessageBox.Show("Girilen barkod no'ya ait ürün bulunamadı.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                totalPrice += product.satisFiyat;
                listBox1.Items.Add(addID.Text);
                MessageBox.Show("Ürün sepete eklendi","Eklendi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                label3.Text = "Tutar toplamı : " + totalPrice;
            }
            
        }

        public void deleteProductButton_Click(object sender, EventArgs e)
        {
            bilgileriDogrula bgd = new bilgileriDogrula();
            Int64 select = Convert.ToInt64(listBox1.SelectedItem.ToString());
            var product = dbcontext.tUruns.SingleOrDefault(x => x.barkodNo == select);
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
            musteriArayuzu mstar= new musteriArayuzu();
            mstar.Show();
            var satisCari = new Entity.tSatis();
            //satisCari.satisNo = 0;
            satisCari.satisTuru = "Cari";
            satisCari.satisTutar = (float)totalPrice;
            dbcontext.tSatiss.Add(satisCari);
            dbcontext.SaveChanges();
            listBox1.Items.Clear();
            totalPrice = 0;
            listBox1.Items.Clear();
            listBox1.Items.Add("Sepet" );
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
            MessageBox.Show("Satış Tamamlandı","Tamamlandı",MessageBoxButtons.OK,MessageBoxIcon.Stop);

        }


        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
