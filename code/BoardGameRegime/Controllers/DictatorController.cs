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
        public ActionResult Index([Bind(Include = "Time,Players,Complexity")]Picker picker)
        {
            // query the database for the a game to play
            if (ModelState.IsValid)
            {
                var games = (from item in db.Games
                             where (item.GameLength <= picker.Time) && (item.MinPlayer <= picker.Players) && (item.MaxPlayer >= picker.Players)
                             select item).ToList();

                if (picker.Complexity != 0)
                {
                    games = (from item in games
                             where (item.Complexity <= picker.Complexity)
                             select item).ToList();
                }

                if (games.Count() == 0)
                {
                    return View("NoGame");
                }

                else
                {
                    var randomGame = games.ElementAtOrDefault(rnd.Next(0, games.Count()));

                    return View("Game", randomGame);
                }
            }
            return View(picker);
        }

        public ActionResult Game()
        {
            return View();
        }

        public ActionResult NoGame()
        {
            return View();
        }
    }
}