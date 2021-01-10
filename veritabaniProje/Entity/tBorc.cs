using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veritabaniProje.Entity
{
    class tBorc
    {
        [Key]
        public int musteriId { get; set; }
        public DateTime borcTarihi { get; set; }
        public float borcMiktar { get; set; }
        public float odenenMiktar { get; set; }
        public int urunMiktar { get; set; }
    }
}
