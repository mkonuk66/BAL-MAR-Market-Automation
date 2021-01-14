using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veritabaniProje.Entity
{
    class tUrun
    {
        [Key]
        public int urunId { get; set; }
        public Int64 barkodNo { get; set; }
        public string urunAdi { get; set; }
        public int miktar { get; set; }
        public double satisFiyat { get; set; }

    }
}
