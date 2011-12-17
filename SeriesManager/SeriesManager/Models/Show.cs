namespace SeriesManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class Show
    {
        public int ShowID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Season> Seasons { get; set; }
    }
}