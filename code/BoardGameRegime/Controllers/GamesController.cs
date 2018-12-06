using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BoardGameRegime.Abstract;
using BoardGameRegime.Entities;

namespace BoardGameRegime.Controllers
{
    public class GamesController : Controller
    {
        // GET: Games
        private IGameRepository repository;

        public GamesController (IGameRepository gameRepository)
        {
            this.repository = gameRepository;
        }
    }
}