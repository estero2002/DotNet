namespace SeriesManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.ComponentModel.DataAnnotations;

    public class Episode
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EpisodeID { get; set; }
        
        public int SeasonID { get; set; }

        [Required(ErrorMessage = "Episode number is required")]
        public int Number { get; set; }
        
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? AiringDate { get; set; }

        public bool Watched { get; set; }

        public virtual Season Season { get; set; }
        public virtual ICollection<Download> Downloads { get; set; }
    }
}