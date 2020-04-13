namespace GuildBlog.UI.Migrations
{
    using GuildBlog.MVC.Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GuildBlog.MVC.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GuildBlog.MVC.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Roles.AddOrUpdate(
    r => r.Name,
    new IdentityRole { Name = "Owner" },
    new IdentityRole { Name = "Admin" }
    );

            context.Users.AddOrUpdate(
                new ApplicationUser
                {
                    Email = "JohnDoe@swg.com",
                    EmailConfirmed = true,
                    PhoneNumber = "5555555555",
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 100,
                    UserName = "JohnDoe",
                });

            context.Postings.AddOrUpdate(
                new Posting
                {
                    PostingID = 1,
                    PostingTitle = "First Post!",
                    PostingAuthor = "John Doe",
                    PostingBody = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    PostingDate = DateTime.Today
                }
                );
        }
    }
}
