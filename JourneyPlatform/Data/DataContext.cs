using JourneyPlatform.Models;
using Microsoft.EntityFrameworkCore;

namespace JourneyPlatform.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<User> Users { set; get; }
        public DbSet<News> News { set; get; }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity => { entity.HasIndex(e => e.Email).IsUnique(); });
        }*/
    }
}