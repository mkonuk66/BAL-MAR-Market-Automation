using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Word = Microsoft.Office.Interop.Word;


namespace veritabaniProje
{
    public partial class topluMusteriBorcDurum : Form
    {
        Entity.Context dbcontext = new Entity.Context();
        SqlConnection baglanti = new SqlConnection(@"Server=DESKTOP-HU112LL; Database =veritabaniProje; Trusted_Connection =True;");
        SqlDataAdapter adborcsorgu = new SqlDataAdapter();
        DataSet borcsorguds = new DataSet();
        public topluMusteriBorcDurum()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void topluMusteriBorcDurum_Load(object sender, EventArgs e)
        {
            DataTable borcsorgudt = new DataTable();
            SqlDataAdapter borcsorgu = new SqlDataAdapter("select musteriAdi, musteriSoyadi,kalanBorc,musteriBorc,odenenMiktar from tMusteris", baglanti);
            baglanti.Open();
            borcsorgu.Fill(borcsorguds, "tMusteris,tBorcs");
            borcsorgudt = borcsorguds.Tables["tMusteris,tBorcs"];
            topluBorcDurum.DataSource = borcsorgudt;
            baglanti.Close();
            topluBorcDurum.Columns[0].HeaderText = "Müşteri Adı";
            topluBorcDurum.Columns[1].HeaderText = "Müşteri Soyadı";
            topluBorcDurum.Columns[2].HeaderText = "Kalan Borç Miktarı";
            topluBorcDurum.Columns[3].HeaderText = "Toplam Borç";
            topluBorcDurum.Columns[4].HeaderText = "Ödenen Borç";

        }

        private void wordAktar_Click(object sender, EventArgs e)
        {
            int satir = topluBorcDurum.Rows.Count, sutun = topluBorcDurum.Columns.Count;

            Object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc";

            Word.Application wordApp = new Word.Application();
            Word.Document wordDoc = wordApp.Documents.Add(ref oMissing, ref oMissing, ref oMissing, ref oMissing);
            wordApp.Visible = true;

            object oRng = wordDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oRng = wordDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;

            Word.Paragraph paragraf;
            paragraf = wordDoc.Content.Paragraphs.Add(ref oRng);
            paragraf.Range.Text = "TOPLU MÜŞTERİ BORÇ DURUM RAPORU";
            paragraf.Range.Font.Shadow = 0;
            paragraf.Range.Font.Size = 16;
            paragraf.Range.Paragraphs.LeftIndent = 50;
            paragraf.Format.SpaceAfter = 10;
            paragraf.Range.InsertParagraphAfter();

            Word.Range wrdRng = wordDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            Word.Table tablo = wordDoc.Tables.Add(wrdRng, satir, sutun, ref oMissing, ref oMissing);
            tablo.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            tablo.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;

            tablo.Rows[1].Cells[1].Range.Text = "Müşteri Adı";
            tablo.Rows[1].Range.Font.Bold = 1;
            tablo.Rows[1].Range.Font.Italic = 1;
            tablo.Rows[1].Range.Font.Size = 12;
            tablo.Rows[1].Range.Font.ColorIndex = Word.WdColorIndex.wdDarkRed;

            tablo.Rows[1].Cells[2].Range.Text = "Müşteri Soyadı";
            tablo.Rows[1].Range.Font.Bold = 1;
            tablo.Rows[1].Range.Font.Italic = 1;
            tablo.Rows[1].Range.Font.Size = 12;
            tablo.Rows[1].Range.Font.ColorIndex = Word.WdColorIndex.wdDarkRed;

            tablo.Rows[1].Cells[3].Range.Text = "Alınan Ürün Miktarı";
            tablo.Rows[1].Range.Font.Bold = 1;
            tablo.Rows[1].Range.Font.Italic = 1;
            tablo.Rows[1].Range.Font.Size = 12;
            tablo.Rows[1].Range.Font.ColorIndex = Word.WdColorIndex.wdDarkRed;

            tablo.Rows[1].Cells[4].Range.Text = "Toplam Borç";
            tablo.Rows[1].Range.Font.Bold = 1;
            tablo.Rows[1].Range.Font.Italic = 1;
            tablo.Rows[1].Range.Font.Size = 12;
            tablo.Rows[1].Range.Font.ColorIndex = Word.WdColorIndex.wdDarkRed;

            tablo.Rows[1].Cells[5].Range.Text = "Toplam Ödenen Borç";
            tablo.Rows[1].Range.Font.Bold = 1;
            tablo.Rows[1].Range.Font.Italic = 1;
            tablo.Rows[1].Range.Font.Size = 12;
            tablo.Rows[1].Range.Font.ColorIndex = Word.WdColorIndex.wdDarkRed;


            tablo.Range.ParagraphFormat.SpaceAfter = 10;
            for(int i = 0; i < satir - 1; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    tablo.Rows[i + 2].Cells[j + 1].Range.Text = topluBorcDurum.Rows[i].Cells[j].Value.ToString();
                }
            } 
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
