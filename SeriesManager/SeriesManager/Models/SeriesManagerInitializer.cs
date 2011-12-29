using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SeriesManager.Models
{
    public class SeriesManagerInitializer : DropCreateDatabaseAlways<SeriesManagerEntities>
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
                new Season { Number = 2, ShowID = 2 },
                new Season { Number = 3, ShowID = 2 },
                new Season { Number = 4, ShowID = 2 },
            };
            seasons.ForEach(s => context.Seasons.Add(s));
            context.SaveChanges();

            var episodes = new List<Episode>
            {
                new Episode { Number = 1, SeasonID = 1, AiringDate = new DateTime(2011, 9, 22) },
                new Episode { Number = 2, SeasonID = 1, AiringDate = new DateTime(2011, 9, 29) },
                new Episode { Number = 3, SeasonID = 1, AiringDate = new DateTime(2011, 10, 6) },
                new Episode { Number = 4, SeasonID = 1, AiringDate = new DateTime(2011, 10, 13) },
                new Episode { Number = 5, SeasonID = 1, AiringDate = new DateTime(2011, 10, 20) },
                new Episode { Number = 6, SeasonID = 1, AiringDate = new DateTime(2011, 10, 27) },
                new Episode { Number = 7, SeasonID = 1, AiringDate = new DateTime(2011, 11, 3) },
                new Episode { Number = 8, SeasonID = 1, AiringDate = new DateTime(2011, 11, 17) },
                new Episode { Number = 9, SeasonID = 1, AiringDate = new DateTime(2011, 12, 8) },
                new Episode { Number = 10, SeasonID = 1, AiringDate = new DateTime(2011, 12, 15) },
                new Episode { Number = 1, Name = "Neither Here Nor There", SeasonID = 5, AiringDate = new DateTime(2011, 9, 23) },
                new Episode { Number = 2, Name = "One Night in October", SeasonID = 5, AiringDate = new DateTime(2011, 9, 30) },
                new Episode { Number = 3, Name = "Alone in the World", SeasonID = 5, AiringDate = new DateTime(2011, 10, 7) },
                new Episode { Number = 4, Name = "Subject 9", SeasonID = 5, AiringDate = new DateTime(2011, 10, 14) },
                new Episode { Number = 5, Name = "Novation", SeasonID = 5, AiringDate = new DateTime(2011, 11, 4) },
                new Episode { Number = 6, Name = "And Those We've Left Behind", SeasonID = 5, AiringDate = new DateTime(2011, 11, 11) },
                new Episode { Number = 7, Name = "Wallflower", SeasonID = 5, AiringDate = new DateTime(2011, 11, 18) },
                new Episode { Number = 8, Name = "Back to Where You've Never Been", SeasonID = 5, AiringDate = new DateTime(2012, 1, 13) },
            };
            episodes.ForEach(e => context.Episodes.Add(e));
            context.SaveChanges();
        }
    }
}