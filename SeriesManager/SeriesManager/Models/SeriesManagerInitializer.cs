using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SeriesManager.Models
{
    public class SeriesManagerInitializer : DropCreateDatabaseIfModelChanges<SeriesManagerEntities>
    {
        protected override void Seed(SeriesManagerEntities context)
        {
            var shows = new List<Show>
            {
                new Show { Name = "Person of Interest" },
                new Show { Name = "Fringe" }
            };
            shows.ForEach(s => context.Shows.Add(s));
            context.SaveChanges();

            var seasons = new List<Season>
            {
                new Season { Number = 1, ShowID = 1 },
                new Season { Number = 1, ShowID = 2 },
                new Season { Number = 2, ShowID = 2 }
            };
            seasons.ForEach(s => context.Seasons.Add(s));
            context.SaveChanges();

            var episodes = new List<Episode>
            {
                new Episode { Number = 1, SeasonID = 1, AiringDate = new DateTime(2011, 9, 22) },
                new Episode { Number = 2, SeasonID = 1, AiringDate = new DateTime(2011, 9, 29) },
                new Episode { Number = 3, SeasonID = 1, AiringDate = new DateTime(2011, 10, 6) },
                new Episode { Number = 4, SeasonID = 1, AiringDate = new DateTime(2011, 10, 13) }
            };
            episodes.ForEach(e => context.Episodes.Add(e));
            context.SaveChanges();
        }
    }
}