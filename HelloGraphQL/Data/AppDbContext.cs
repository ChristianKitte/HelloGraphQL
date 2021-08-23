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
    }
}