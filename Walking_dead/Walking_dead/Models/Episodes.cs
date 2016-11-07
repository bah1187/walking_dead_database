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
            Database.SetInitializer<EpisodeContext>(new WalkingDeadDbInitializer());
        }
    }

    public class WalkingDeadDbInitializer : DropCreateDatabaseAlways<EpisodeContext>
    {
        protected override void Seed(EpisodeContext context)
        {
            base.Seed(context);
            context.Episodes.Add(new Models.Episode()
            {
                Complete = false,
                Date_Aired = "10/31/2009",
                Episodes = 1,
                Plot = "Bunch of people DIE",
                Review = "Popcorn was necessary",
                Season = 1,
                Title = "DEATH VISITS YOU NOW"
            });
            context.SaveChanges();
        }
    }


}
