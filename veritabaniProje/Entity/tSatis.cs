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
        public string satisTuru { get; set; }
        public double satisTutar { get; set; }
    }
}
