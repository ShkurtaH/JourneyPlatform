global using Microsoft.EntityFrameworkCore;
using JourneyPlatform.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


using JourneyPlatform.Models.AccomodationModels;

namespace JourneyPlatform.Data
{
    public class DataContext: IdentityDbContext<IdentityUser>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Roles> Roles { get; set; } 
        public DbSet<User> Users { set; get; }
        public DbSet<News> News { set; get; } 
        public DbSet<Navigation> Navigations { set; get; }

       /* public DbSet<AccomodationCategory> AccomodationCategories { get;set;}
        public DbSet<Airbnb> AirbnbAccomodations { get;set;}
        public DbSet<Hostel> HostelAccomodations { get; set;}
        public DbSet<Hotel> HotelAccomodations { get; set;}
        public DbSet<Villa> VillaAccomodations { get; set;}*/
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity => { entity.HasIndex(e => e.Email).IsUnique(); });
        }*/ 

    }
}