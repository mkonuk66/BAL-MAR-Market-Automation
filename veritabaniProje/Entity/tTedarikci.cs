using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace veritabaniProje.Entity
{
    class tTedarikci
    {
        [Key]
        public int tedarikciId { get; set; }
        public string urunAdi { get; set; }
        public int urunId { get; set; }
        public float borcMiktar { get; set; }
        public int urunMiktar { get; set; }

        public virtual ICollection<tIrsaliye> tIrsaliyes { get; set; }

    }
}