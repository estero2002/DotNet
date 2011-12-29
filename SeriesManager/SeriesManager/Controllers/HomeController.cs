namespace SeriesManager.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using SeriesManager.Models;
    using SeriesManager.ViewModels;

    public class HomeController : Controller
    {
        private SeriesManagerEntities db = new SeriesManagerEntities();

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            var counter = new List<EpisodeGroup>();

            foreach (var show in db.Shows)
            {
                var aired = 0;
                var watched = 0;

                foreach (var season in db.Seasons.Where(s => s.ShowID == show.ShowID))
                {
                    aired += db.Episodes.Where(e => e.SeasonID == season.SeasonID && e.AiringDate <= DateTime.Now).Count();
                    watched += db.Episodes.Where(e => e.SeasonID == season.SeasonID && e.WatchedDate <= DateTime.Now).Count();
                }

                counter.Add(new EpisodeGroup { Show = show.Name, AiredEpisodesCount = aired, WatchedEpisodesCount = watched });
            }

            return View(counter);
        }
    }
}
