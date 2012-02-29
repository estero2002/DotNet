namespace PlayedSongs.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.ComponentModel.DataAnnotations;

    public class Song
    {
        public int SongID { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime Learned { get; set; }
        
        [Display(Name = "Tab From")]
        public string TabOrigin { get; set; }

        [Display(Name = "Tab Path")]
        public string TabPath { get; set; }
    }
}