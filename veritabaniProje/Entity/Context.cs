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
    }
}
