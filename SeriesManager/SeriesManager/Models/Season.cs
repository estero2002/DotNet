namespace SeriesManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.ComponentModel.DataAnnotations;

    public class Season
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SeasonID { get; set; }
        public int ShowID { get; set; }
        public int Number { get; set; }
        public virtual Show Show { get; set; }
        public virtual ICollection<Episode> Episodes { get; set; }
    }
}