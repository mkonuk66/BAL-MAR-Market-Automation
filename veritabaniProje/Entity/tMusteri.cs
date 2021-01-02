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
        public int musteriGSM { get; set; }
    }
}
