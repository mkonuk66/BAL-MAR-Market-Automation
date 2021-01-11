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
    public partial class BorcIslemleri : UserControl
    {
        Entity.Context dbcontext = new Entity.Context();
        public BorcIslemleri()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* string musteriId1 = Convert.ToString(textBox1.Text);
            var musteriId = dbcontext.tMusteris.FirstOrDefault(x => x.musteriId == musteriId1);
            if (musteriId != null)
            {
                satisEkrani ste = new satisEkrani();
                ste.Show();
            }
            else
            {
                label6.Text = "Lütfen geçerli bir kullanıcı adı veya parola giriniz";
            }
           */
        }

        private void button2_Click(object sender, EventArgs e)
        {
           /* string musteriId1 = Convert.ToString(textBox1.Text);
            var musteriId = dbcontext.tMusteris.FirstOrDefault(x => x.musteriId == musteriId1);
            if (musteriId != null)
            {
                satisEkrani ste = new satisEkrani();
                ste.Show();
            }
            else
            {
                label6.Text = "Lütfen geçerli bir kullanıcı adı veya parola giriniz";
            }
           */
        }

        private void BorcIslemleri_Load(object sender, EventArgs e)
        {

        }
    }
}
