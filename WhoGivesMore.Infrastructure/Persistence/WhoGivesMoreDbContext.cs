using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WhoGivesMore.Core.Entities;

namespace WhoGivesMore.Infrastructure.Persistence
{
    public class WhoGivesMoreDbContext : DbContext
    {
        public WhoGivesMoreDbContext(DbContextOptions<WhoGivesMoreDbContext> options) : base(options)
        {

        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Bid> Bids { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
