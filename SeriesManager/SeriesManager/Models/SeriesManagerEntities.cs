namespace SeriesManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Data.Entity;

    public class SeriesManagerEntities : DbContext
    {
        public DbSet<Show> Shows { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<Download> Downloads { get; set; }
        public DbSet<Quality> Qualities { get; set; }
    }
}