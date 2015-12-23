using EntityFramework6.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework6.Data
{
    public class PlayersDbContext: DbContext        
    {

        public PlayersDbContext()
            : base(nameOrConnectionString: "entityframework6")
        {

        }

        public DbSet<Player> Players { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<League> Leagues { get; set; }
    }
}
