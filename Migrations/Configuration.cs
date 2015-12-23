namespace EntityFramework6.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityFramework6.PlayersDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EntityFramework6.PlayersDbContext context)
        {
            context.Players.AddOrUpdate(p => p.Name, new Player() { Name = "LeBron" });
            context.SaveChanges();

        }
    }
}
