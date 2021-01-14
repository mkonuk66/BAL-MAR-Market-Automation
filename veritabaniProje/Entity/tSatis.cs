using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veritabaniProje.Entity
{
    class tSatis
    {
        [Key]
        public int satisNo { get; set; }
        public float satisTutar { get; set; }
        public string urunAdi { get; set; }
        public int satisMiktar { get; set; }
        public string satisTarih { get; set; }
    }
}
