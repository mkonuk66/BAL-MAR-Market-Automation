using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using word = Microsoft.Office.Interop.Word;

namespace veritabaniProje
{
    public partial class MusteriBorcDurum : Form
    {
        System.Data.DataTable tablo = new System.Data.DataTable();
        public MusteriBorcDurum()
        {
            InitializeComponent();
        }

        private void MusteriBorcDurum_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DataSource = tablo;
        }

        private void veriSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Lüffen silinecek satırı seçin.");
            }
        }

        private void sutunEkle_Click(object sender, EventArgs e)
        {
            tablo.Columns.Add("Müşteri Adı Soyadı", typeof(string));
            tablo.Columns.Add("Toplam Satış", typeof(int));
            tablo.Columns.Add("Toplam Ödeme", typeof(int));
            tablo.Columns.Add("Toplam Kalan", typeof(int));
        }

        private void veriEkle_Click(object sender, EventArgs e)
        {
            tablo.Rows.Add(musteriBilgi.Text, toplamSat.Text, toplamOde.Text, toplamKala.Text);
            dataGridView1.DataSource = tablo;
        }

        private void wordAktar_Click(object sender, EventArgs e)
        {
            word.Application wordapp = new word.Application();
            word.Document WordDocument = wordapp.Documents.Add(Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            wordapp.Visible = true;
            WordDocument.PageSetup.PaperSize = word.WdPaperSize.wdPaperA4;
            //yazının sağa dayalı ve kalın olmasını belirttik..     
            wordapp.Selection.ParagraphFormat.Alignment = word.WdParagraphAlignment.wdAlignParagraphLeft;
            wordapp.Selection.Font.Bold = (int)word.WdConstants.wdFirst;

            //datagridview'deki verileri word e aktardık.
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                {
                    wordapp.Selection.TypeText(dataGridView1[j, i].Value.ToString() + " ");
                }
                wordapp.Selection.TypeParagraph();
            }
        }
    }
}
