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
    public partial class satisRapor : Form
    {
        System.Data.DataTable rapor = new System.Data.DataTable();

        public satisRapor()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            satisListe.DataSource = rapor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] musteriId = { 18, 20, 21, 22 };
            int musterinum = Convert.ToInt32(musteriNumber.Text);
            for (int i = 0; i < musteriId.Length; i++)
            {
                if (musteriId[i] == musterinum)
                {
                    MessageBox.Show("Müşteri bulundu. Listeleniyor...");
                    return;
                }
                else
                {
                    MessageBox.Show("Müşteri bulunamadı. Lütfen Tekrar Deneyin.");
                    return;
                }
            }
        }

        private void sutunEkle_Click(object sender, EventArgs e)
        {
            rapor.Columns.Add("Müşteri ID", typeof(int));
            rapor.Columns.Add("Ürün Adı", typeof(string));
            rapor.Columns.Add("Toplam Satış Miktarı", typeof(int));
            rapor.Columns.Add("Toplam Tutar", typeof(int));
        }

        private void veriEkle_Click(object sender, EventArgs e)
        {
            rapor.Rows.Add(musteriNumber.Text, urunAdi.Text, satisMiktari.Text, toplamTutar.Text);
            satisListe.DataSource = rapor;
        }

        private void veriSil_Click(object sender, EventArgs e)
        {
            if (satisListe.SelectedRows.Count > 0)
            {
                satisListe.Rows.RemoveAt(satisListe.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Lüffen silinecek satırı seçin.");
            }
        }

        private void musteriNumber_Click(object sender, EventArgs e)
        {
            musteriNumber.BackColor = Color.White;
            urunAdi.BackColor = SystemColors.Control;
            satisMiktari.BackColor = SystemColors.Control;
            toplamTutar.BackColor = SystemColors.Control;
        }

        private void urunAdi_Click(object sender, EventArgs e)
        {
            urunAdi.BackColor = Color.White;
            musteriNumber.BackColor = SystemColors.Control;
            satisMiktari.BackColor = SystemColors.Control;
            toplamTutar.BackColor = SystemColors.Control;
        }

        private void satisMiktari_Click(object sender, EventArgs e)
        {
            satisMiktari.BackColor = Color.White;
            urunAdi.BackColor = SystemColors.Control;
            musteriNumber.BackColor = SystemColors.Control;
            toplamTutar.BackColor = SystemColors.Control;
        }

        private void toplamTutar_Click(object sender, EventArgs e)
        {
            toplamTutar.BackColor = Color.White;
            urunAdi.BackColor = SystemColors.Control;
            satisMiktari.BackColor = SystemColors.Control;
            musteriNumber.BackColor = SystemColors.Control;
        }
    }
}
