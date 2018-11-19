using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoardGameRegime.Controllers
{
    public class ListController : Controller
    {
        // GET: LIst
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Library()
        {
            return View();
        }
    }
}