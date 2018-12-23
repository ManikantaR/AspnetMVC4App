using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace AspnetMVC4App.Models
{

  
    public class MVC4AppDb : DbContext
    {
        public MVC4AppDb() : base("DefaultConnection")
        {

        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantReview> RestaurantReviews { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }


    }
}