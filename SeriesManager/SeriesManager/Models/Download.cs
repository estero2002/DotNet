namespace SeriesManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class Download
    {
        public int DownloadID { get; set; }
        public int EpisodeID { get; set; }
        public int QualityID { get; set; }
        public DateTime? DownloadDate { get; set; }
        public virtual Episode Episode { get; set; }
        public virtual Quality Quality { get; set; }
    }
}