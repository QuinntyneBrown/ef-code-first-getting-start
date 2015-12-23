using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework6
{
    public class PlayersDbContext: DbContext        
    {

        public PlayersDbContext()
            : base(nameOrConnectionString: "players")
        {

        }

        public DbSet<Player> Players { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<League> Leagues { get; set; }
    }
}
