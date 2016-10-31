using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Walking_dead.Models
{
    public class Episode
    {
        public int EpisodeID { get; set; }
        public int Season { get; set; }
        public int Episodes { get; set; }
        public string Title { get; set; }
        public string Date_Aired { get; set; }
        public string Plot { get; set; }
        public string Review { get; set; }
        public bool Complete {get; set;}
    }
    public class EpisodeContext : DbContext
    {
         public DbSet<Episode> Episodes { get; set; }

        public EpisodeContext()
        {
            Database.SetInitializer<EpisodeContext>(new DropCreateDatabaseIfModelChanges<EpisodeContext>());
        }
    }
}
