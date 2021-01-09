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
using System.Data.SqlClient;
using System.Data.Sql;

namespace veritabaniProje
{
    public partial class MusteriMenu : UserControl
    {
        Entity.Context dbcontext = new Entity.Context();
        public MusteriMenu()
        {
            InitializeComponent();
        }
        //static string musteriEkle = "Server=DESKTOP-HU112LL;Database=veritabaniProje;Trusted_Connection=True;";
        //SqlConnection musekleme = new SqlConnection(musteriEkle);
       

        private void button1_Click(object sender, EventArgs e)
        {
           /* var musteri = new Entity.tMusteri();
            musteri.musteriId = 0;
            musteri.musteriAdi = musteriadi.Text;
            musteri.musteriSoyadi = musterisoyad.Text;
            musteri.musteriGSM = Convert.ToInt64(telno.Text);
            musteri.kayitTarihi = kayittarihi.Value;
            musteri.musteriBorc = 0;
            dbcontext.tMusteris.Add(musteri);
            dbcontext.SaveChanges();
            MessageBox.Show("Müşteri Eklendi. Numarası : " + musteri.musteriId + "", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
           */
        }

        

        private void MusteriMenu_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            panel5.BackColor = SystemColors.Control;
            panel6.BackColor = SystemColors.Control;
            textBox2.BackColor = SystemColors.Control;
            textBox3.BackColor = SystemColors.Control;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
            panel3.BackColor = SystemColors.Control;
            panel4.BackColor = Color.White;
            panel5.BackColor = SystemColors.Control;
            panel6.BackColor = SystemColors.Control;
            textBox1.BackColor = SystemColors.Control;
            textBox3.BackColor = SystemColors.Control;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.White;
            panel3.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
            panel5.BackColor = Color.White;
            panel6.BackColor = SystemColors.Control;
            textBox1.BackColor = SystemColors.Control;
            textBox2.BackColor = SystemColors.Control;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
