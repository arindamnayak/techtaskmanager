namespace ContactManager.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ContactManager.Models.ContactManagerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ContactManager.Models.ContactManagerContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Tasks.AddOrUpdate(
              p => p.TaskID,
              new ContactManager.Models.Task { Title = "Task 1 ", Description = "Task 1 Desc" },
             new ContactManager.Models.Task { Title = "Task 2 ", Description = "Task 2 Desc" },
             new ContactManager.Models.Task { Title = "Task 3 ", Description = "Task 3 Desc" }
            );
            //
        }
    }
}
