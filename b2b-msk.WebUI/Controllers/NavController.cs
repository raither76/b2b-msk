using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using b2b_msk.Domain.Abstract;

namespace b2b_msk.WebUI.Controllers
{
    public class NavController : Controller
    {
        private IGoodRepository repository;

        public NavController(IGoodRepository repo)
        {
            repository = repo;
        }
        // GET: Nav
        public PartialViewResult  Menu(string category = null)
        {

            ViewBag.SelectedCategory = category;
            IEnumerable<string> categories = repository.Goods
                .Select(good => good.Category)
                .Distinct()
                .OrderBy(x => x);
            return PartialView(categories);
        }
    }
}