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
        private GameDbContext db = new GameDbContext();
        Random rnd = new Random();
        // GET: Dictator
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Picker picker)
        {
            // query the database for the a game to play
            var games = (from item in db.Games
                                  where (item.GameLength <= picker.Time) && (item.MinPlayer <= picker.Players) && (item.MaxPlayer >= picker.Players)
                                  select item).ToList();
            var randomGame = games.ElementAtOrDefault(rnd.Next(0, games.Count()));

            return View("Game", randomGame);
        }

        public ActionResult Game()
        {
            return View();
        }
    }
}