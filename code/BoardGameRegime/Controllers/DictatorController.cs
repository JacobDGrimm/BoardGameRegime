using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BoardGameRegime.Models;

namespace BoardGameRegime.Controllers
{
    public class DictatorController : Controller
    {
        // GET: Dictator
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Picker picker)
        {
            // query the database for the a game to play
            return View();
        }

        public ActionResult Game()
        {
            return View();
        }
    }
}