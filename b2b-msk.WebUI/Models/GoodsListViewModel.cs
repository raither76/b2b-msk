using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using b2b_msk.Domain.Entities;
namespace b2b_msk.WebUI.Models
{
    public class GoodsListViewModel
    {
        public IEnumerable<Good> Goods { get; set; }
        public GoodPagingInfo GoodPagingInfo { get; set; }
        public string CurrentCategory { get; set; }
        public string CurrentTNPA { get; set; }
    }
}