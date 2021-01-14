using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veritabaniProje.Entity
{
    class Context : DbContext
    {
        public DbSet<tUrun> tUruns { get; set; }
        public DbSet<tMusteri> tMusteris { get; set; }
        public DbSet<tIrsaliye> tIrsaliyes { get; set; }
        public DbSet<tSatis> tSatiss { get; set; }
        public DbSet<tBorc> tBorcs { get; set; }
        public DbSet<tTedarikci> tTedarikcis { get; set; }
        public DbSet<tKasiyer> tKasiyers { get; set; }
        public DbSet<tYonetici> tYoneticis { get; set; }
        public DbSet<ttedarikciOdeme> ttedarikciOdemes { get; set; }
    }
}
