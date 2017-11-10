using Rad2016SampleWepApp.Models.ClubModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace s00156269Week6.Models.ClubModels
{
    public class ClubsDbContext : DbContext
    {
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<ClubEvent> ClubEvents { get; set; }
        // Can distribute them over different databases using base("DefaultConnection")
        public ClubsDbContext() : base("DefaultConnection")
        {

        }
    }
}