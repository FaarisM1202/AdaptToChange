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

        public DbSet<ToDoList> ToDoLists { get; set; }
        public DbSet<Member> Members { get; set; }
    }
}