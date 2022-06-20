using JourneyPlatform.Models;
using Microsoft.EntityFrameworkCore;

namespace JourneyPlatform.Data
{
    public class NewsContext : DbContext
    {
        public NewsContext(DbContextOptions<NewsContext> options) : base(options)
        {

        }
        public DbSet<News> Newses { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<News>(entity => { entity.HasIndex(e => e.NewsId).IsUnique(); });
        }
    }
}