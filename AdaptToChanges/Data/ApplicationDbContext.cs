using AdaptToChanges.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace AdaptToChanges.Data
{
    public class AdaptToChangesDbContext : IdentityDbContext
    {
        public AdaptToChangesDbContext(DbContextOptions<AdaptToChangesDbContext> options)
            : base(options)
        {
        }
    }
}