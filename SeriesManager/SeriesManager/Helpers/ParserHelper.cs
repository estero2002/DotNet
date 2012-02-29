using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SeriesManager.Models;
using System.Xml.Linq;

namespace SeriesManager.Helpers
{
    public class ParserHelper
    {
        public static List<Season> GetSeasonsFromShow(int showId)
        {
            var fileDb = string.Empty;
            var seasons = new List<Season>();

            switch (showId)
            {
                case 82066:
                    fileDb = System.Web.HttpContext.Current.Request.MapPath("~/App_Data/Fringe.xml");
                    break;
                case 73255:
                    fileDb = System.Web.HttpContext.Current.Request.MapPath("~/App_Data/House.xml");;
                    break;
                case 248742:
                    fileDb = System.Web.HttpContext.Current.Request.MapPath("~/App_Data/PersonOfInterest.xml");;
                    break;
            }

            if (fileDb == string.Empty)
                return seasons;

            var data = XElement.Load(fileDb);
            var episodes = data.Elements("Episode").GroupBy(e => e.Element("seasonid").Value);

            foreach (var season in episodes)
            {
                seasons.Add(new Season { SeasonID = Convert.ToInt32(season.First().Element("seasonid").Value), ShowID = showId, Number = Convert.ToInt32(season.First().Element("Combined_season").Value) });
            }

            return seasons;
        }

        public static List<Episode> GetEpisodesFromShow(int showId)
        {
            var fileDb = string.Empty;
            var seasonEpisodes = new List<Episode>();

            switch (showId)
            {
                case 82066:
                    fileDb = System.Web.HttpContext.Current.Request.MapPath("~/App_Data/Fringe.xml");
                    break;
                case 73255:
                    fileDb = System.Web.HttpContext.Current.Request.MapPath("~/App_Data/House.xml"); ;
                    break;
                case 248742:
                    fileDb = System.Web.HttpContext.Current.Request.MapPath("~/App_Data/PersonOfInterest.xml"); ;
                    break;
            }

            if (fileDb == string.Empty)
                return seasonEpisodes;

            var data = XElement.Load(fileDb);
            var episodes = data.Elements("Episode");//.Where(e => e.Element("Combined_season").Value == seasonId.ToString());

            foreach (var episode in episodes)
            {
                var modelEpisode = new Episode
                { 
                    EpisodeID = Convert.ToInt32(episode.Element("id").Value),
                    SeasonID = Convert.ToInt32(episode.Element("seasonid").Value),
                    Number = Convert.ToInt32(episode.Element("EpisodeNumber").Value),
                    Name = episode.Element("EpisodeName").Value,
                    Watched = false
                };

                if(episode.Element("FirstAired").Value != string.Empty)
                {
                    modelEpisode.AiringDate = DateTime.Parse(episode.Element("FirstAired").Value);
                }

                seasonEpisodes.Add(modelEpisode);
            }

            return seasonEpisodes;
        }
    }
}