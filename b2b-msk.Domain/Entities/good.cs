using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b2b_msk.Domain.Entities
{
    public class Good
    {
     
            public int GoodId { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Category { get; set; }
            public string TNPA { get; set; }
            public decimal minPrice { get; set; }
            public decimal maxPrice { get; set; }
            public decimal curPrice { get; set; }

    }
}
