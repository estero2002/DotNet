namespace PlayedSongs.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Data.Entity;

    public class PlayedSongsEntities : DbContext
    {
        public DbSet<Song> Songs { get; set; }
    }
}