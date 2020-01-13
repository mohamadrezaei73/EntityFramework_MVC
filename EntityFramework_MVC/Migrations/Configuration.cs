using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace EntityFramework_MVC.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Models.DataBaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EntityFramework_MVC.Models.DataBaseContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
