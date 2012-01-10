namespace SeriesManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.ComponentModel.DataAnnotations;

    public class Episode
    {
        public int EpisodeID { get; set; }
        public int SeasonID { get; set; }

        [Required(ErrorMessage = "Episode number is required")]
        public int Number { get; set; }
        
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime? AiringDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime? WatchedDate { get; set; }

        public virtual Season Season { get; set; }
        public virtual ICollection<Download> Downloads { get; set; }
    }
}