namespace EntityFramework6.Migrations
{
    using EntityFramework6.Data;
    using EntityFramework6.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PlayersDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(PlayersDbContext context)
        {
            context.Players.AddOrUpdate(p => p.Name, new Player() { Name = "LeBron" });
            context.SaveChanges();

        }
    }
}
