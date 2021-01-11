using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veritabaniProje.Entity
{
    class tYonetici
    {
        [Key]
        public int yoneticiID { get; set; }
        public string yKullaniciAdi { get; set; }
        public string ySifre { get; set; }

    }
}
