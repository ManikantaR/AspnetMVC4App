namespace OdeToCodeApp.Migrations
{
    using AspnetMVC4App.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AspnetMVC4App.Models.MVC4AppDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AspnetMVC4App.Models.MVC4AppDb context)
        {
            context.Restaurants.AddOrUpdate(r => r.Name,
              new Restaurant { Name = "Costco", City = "Manchestor", Country = "Usa" },
              new Restaurant { Name = "Bjs", City = "Manchestor", Country = "Usa" },
              new Restaurant { Name = "Walmart", City = "Manchestor", Country = "Usa" },
              new Restaurant
              {
                  Name = "Natiya",
                  City = "Manchestor",
                  Country = "Usa",
                  Reviews = new List<RestaurantReview> {
                    new RestaurantReview{Rating=9,Body="Super",ReviewerName="mani" } }
              }

          );
        }
    }
}
