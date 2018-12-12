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

        private struct ThemeViewModel
        {
            public int ThemeId {get; set;}
            public string Theme {get; set;}
        }

        // This is a hacky way of providing an ID for all themes
        // It assumes the themes table isn't changed between loading the Picker page and submitting same
        // Blame ETR if this doesn't work
        //
        // The proper fix for this is to create a Theme table and reference it from Game with a foreign key
        private IEnumerable<ThemeViewModel> MakeThemeList()
        {
            var query = new List<String>() { "I Don't Care" };

            query.AddRange((from item in db.Games
                                where item.Theme != null
                                orderby item.Theme
                                select item.Theme).Distinct().ToList());

            return query.Zip(Enumerable.Range(0, query.Count()),
                             (x, i) =>
                                 new ThemeViewModel
                                 {
                                     ThemeId = i,
                                     Theme = x
                                 });
        }


        // GET: Dictator
        public ActionResult Index()
        {
            ViewBag.Theme = MakeThemeList();

            return View();
        }

        [HttpPost]
        public ActionResult Index([Bind(Include = "Time,Players,Complexity,ThemeId")]Picker picker)
        {
            var themes = MakeThemeList();
            ViewBag.Theme = themes;

            // query the database for the a game to play
            if (ModelState.IsValid)
            {
                var selectedThemeName = picker.ThemeId == 0 ? null
                                                            : themes.Where(x => x.ThemeId == picker.ThemeId).Select(x => x.Theme).Single();

                var games = (from item in db.Games
                             where (item.GameLength <= picker.Time) && (item.MinPlayer <= picker.Players) && (item.MaxPlayer >= picker.Players) &&
                                   (selectedThemeName == null ? true : item.Theme == selectedThemeName)
                             select item).ToList();

                if (picker.Complexity != 0)
                {
                    games = (from item in games
                             where (item.Complexity <= picker.Complexity)
                             select item).ToList();
                }

                var recPlayer = (from item in games
                                 where (item.RecPlayer == picker.Players)
                                 select item).ToList();

                if (recPlayer.Count() != 0)
                {
                    var randomRecPlayer = recPlayer.ElementAtOrDefault(rnd.Next(0, recPlayer.Count()));

                    return View("Game", randomRecPlayer);
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