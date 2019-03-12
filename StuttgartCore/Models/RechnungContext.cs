using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StuttgartCore.Models
{
    public class RechnungContext:DbContext
    {
        public RechnungContext(
            DbContextOptions options):
            base(options)
        {
          
        }

        public virtual DbSet<Rechnungen> Rechnungens { get; set; }
        public virtual DbSet<Positionen> Positionens { get; set; }

     

    }

}
