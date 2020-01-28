using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using b2b_msk.Domain.Entities;
using b2b_msk.Domain.Abstract;

namespace b2b_msk.Domain.Concrete
{
    public  class EFGoodRepository : IGoodRepository
    {
        EFDbContext context = new EFDbContext();

        public IEnumerable<Good> Goods
        {
            get { return context.Goods; }
        }
    }
}
