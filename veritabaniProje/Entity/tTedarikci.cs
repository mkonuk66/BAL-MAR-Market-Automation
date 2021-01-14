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
        public int girisNo { get; set; }
        public int tedarikciId { get; set; }
        public float borcMiktar { get; set; }
        public string girisTarihi { get; set; }

    }
}