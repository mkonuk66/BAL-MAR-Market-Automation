using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veritabaniProje.Entity
{
    class tMusteri
    {
        [Key]
        public int musteriId { get; set; }
        public string musteriAdi { get; set; }
        public string musteriSoyadi { get; set; }
        public string musteriGSM { get; set; }
        public string kayitTarihi { get; set; }
        public float musteriBorc { get; set; }
        public float odenenMiktar { get; set; }
        public float kalanBorc { get; set; }
    }
}
