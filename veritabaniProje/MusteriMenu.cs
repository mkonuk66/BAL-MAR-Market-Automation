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
using System.Text.RegularExpressions;

namespace veritabaniProje
{
    public partial class MusteriMenu : UserControl
    {
        Entity.Context dbcontext = new Entity.Context();
        public MusteriMenu()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == ""  || textBox3.Text == "")
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var musteri = new Entity.tMusteri();
                //musteri.musteriId = 0;
                musteri.musteriAdi = textBox1.Text;
                musteri.musteriSoyadi = textBox2.Text;
                musteri.musteriGSM = textBox3.Text;
                musteri.kayitTarihi = dateTimePicker1.Value.ToShortDateString();
                musteri.musteriBorc = 0;
                dbcontext.tMusteris.Add(musteri);
                dbcontext.SaveChanges();
                MessageBox.Show("Müşteri başarıyla eklendi", "Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                dateTimePicker1.Value = DateTime.Now;
            }
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Regex.IsMatch(textBox3.Text, "[^0-9\b]+");
            if (e.Handled == true)
            {
                MessageBox.Show("Sadece sayı giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
