namespace SeriesManager.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using SeriesManager.Models;

    public class EpisodeGroup
    {
        public string Show { get; set; }
        public int AiredEpisodesCount { get; set; }
        public int WatchedEpisodesCount { get; set; }
    }
}