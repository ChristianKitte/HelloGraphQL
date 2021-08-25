using HelloGraphQL.Models;
using Microsoft.EntityFrameworkCore;

namespace HelloGraphQL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<LinkGroup> LinkGroups { get; set; }
        public DbSet<Link> Links { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<LinkGroup>()
                .HasMany(p => p.LinkGroup_Links)
                .WithOne(p => p.LinkGroup)
                .HasForeignKey(p => p.LinkGroup_ID);

            modelBuilder
                .Entity<Link>()
                .HasOne(p => p.LinkGroup);
        }
    }
}