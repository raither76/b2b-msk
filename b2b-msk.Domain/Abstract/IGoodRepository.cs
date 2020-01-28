using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using b2b_msk.Domain.Entities;

namespace b2b_msk.Domain.Abstract
{
    public interface IGoodRepository
    {
        IEnumerable<Good> Goods { get; }
    }
}
