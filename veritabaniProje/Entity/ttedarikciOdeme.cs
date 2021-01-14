using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace veritabaniProje.Entity
{
    class ttedarikciOdeme
    {
        [Key]
        public int odemeNo { get; set; }
        public int tedarikciID { get; set; }
        public float toplamBorc { get; set; }
        public float odenenMiktar { get; set; }
        public float kalanMiktar { get; set; }
    }
}
