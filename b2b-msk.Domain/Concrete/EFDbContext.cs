using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using b2b_msk.Domain.Entities;
using System.Data.Entity;

namespace b2b_msk.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Good> Goods { get; set; }
    }
}
