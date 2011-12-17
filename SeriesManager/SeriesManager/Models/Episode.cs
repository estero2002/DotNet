namespace SeriesManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class Episode
    {
        public int EpisodeID { get; set; }
        public int SeasonID { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public DateTime? AiringDate { get; set; }
        public DateTime? WatchedDate { get; set; }
        public virtual Season Season { get; set; }
        public virtual ICollection<Download> Downloads { get; set; }
    }
}