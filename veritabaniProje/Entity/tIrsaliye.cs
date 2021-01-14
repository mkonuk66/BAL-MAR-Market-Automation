using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veritabaniProje.Entity
{
    class tIrsaliye {

        [Key]
        public int satirNo { get; set; }
        public int irsaliyeID { get; set; }
        public int urunId { get; set; }
        public DateTime girisTarih { get; set; }      
        public float girdiFiyat { get; set; }
        public int miktar { get; set; }
        public int tedarikciId { get; set; }
        public string urunAdi { get; set; }

    }
}
