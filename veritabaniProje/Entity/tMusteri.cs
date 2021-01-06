using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public Int64 musteriGSM { get; set; }
        public DateTime kayitTarihi { get; set; }
        public int musteriBorc { get; set; }
    }
}
