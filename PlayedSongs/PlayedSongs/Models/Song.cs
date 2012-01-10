namespace PlayedSongs.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class Song
    {
        public int SongID { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public DateTime Learned { get; set; }
        public string TabOrigin { get; set; }
        public string TabPath { get; set; }
    }
}