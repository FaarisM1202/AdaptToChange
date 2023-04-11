using AdaptToChanges.Models;
using Microsoft.EntityFrameworkCore;

namespace AdaptToChanges.Data
{
    public class AdaptToChangesDbContext : DbContext
    {
        public AdaptToChangesDbContext(DbContextOptions<AdaptToChangesDbContext> options)
            : base(options)
        {
        }

        public DbSet<Member> Members { get; set; }
    }
}