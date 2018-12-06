using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoardGameRegime.Controllers
{
    public class DictatorController : Controller
    {
        // GET: Dictator
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Game()
        {
            return View();
        }
    }
}