using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Class9.Models
{
    public class MVCMusicStoreContext : DbContext
    {
        public virtual DbSet<Genre> Genres { get; set; }

        public virtual DbSet<Album> Albums { get; set; }

        public virtual DbSet<Song> Songs { get; set; }

    }
}