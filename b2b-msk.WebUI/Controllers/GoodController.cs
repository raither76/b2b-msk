using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using b2b_msk.Domain.Abstract;
using b2b_msk.Domain.Entities;
using b2b_msk.WebUI.Models;
namespace b2b_msk.WebUI.Controllers
{
    public class GoodController : Controller
    {
        // GET: Good
        private IGoodRepository repository;
        public int pageSize = 4;
        public GoodController(IGoodRepository repo)
        {
            repository = repo;
        }
        public ViewResult List(string category, string tnpa, int page = 1)
        {
            GoodsListViewModel model = new GoodsListViewModel
            {
                Goods = repository.Goods
                   .Where(p => category == null || p.Category == category)
                   .OrderBy(good => good.GoodId)
                   .Skip((page - 1) * pageSize)
                   .Take(pageSize),
                GoodPagingInfo = new GoodPagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalItems = category == null ? repository.Goods.Count() :
                repository.Goods.Where(good => good.Category == category).Count()
                },
                CurrentCategory = category
            };
            return View(model);
        }
    }
}