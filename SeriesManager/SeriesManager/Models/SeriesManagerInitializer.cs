using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SeriesManager.Helpers;

namespace SeriesManager.Models
{
    public class SeriesManagerInitializer : DropCreateDatabaseAlways<SeriesManagerEntities>
    {
        protected override void Seed(SeriesManagerEntities context)
        {
            var shows = new List<Show>
            {
                new Show { ShowID = 82066, Name = "Fringe" },
                new Show { ShowID = 73255, Name = "House" },
                new Show { ShowID = 248742, Name = "Person of Interest" }
            };
            shows.ForEach(s => context.Shows.Add(s));
            context.SaveChanges();

            var seasons = ParserHelper.GetSeasonsFromShow(82066);
            seasons.ForEach(s => context.Seasons.Add(s));
            context.SaveChanges();

            var episodes = ParserHelper.GetEpisodesFromShow(82066);
            episodes.ForEach(e => context.Episodes.Add(e));
            context.SaveChanges();

            seasons = ParserHelper.GetSeasonsFromShow(73255);
            seasons.ForEach(s => context.Seasons.Add(s));
            context.SaveChanges();

            episodes = ParserHelper.GetEpisodesFromShow(73255);
            episodes.ForEach(e => context.Episodes.Add(e));
            context.SaveChanges();

            seasons = ParserHelper.GetSeasonsFromShow(248742);
            seasons.ForEach(s => context.Seasons.Add(s));
            context.SaveChanges();

            episodes = ParserHelper.GetEpisodesFromShow(248742);
            episodes.ForEach(e => context.Episodes.Add(e));
            context.SaveChanges();
        }
    }
}