using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public int borcMiktar { get; set; }
    }
}
