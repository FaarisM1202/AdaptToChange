using AdaptToChanges.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;


namespace AdaptToChanges.Data
{
    public class AdaptToChangesDbContext : IdentityDbContext<Member>
    {
        public AdaptToChangesDbContext(DbContextOptions<AdaptToChangesDbContext> options)
            : base(options)
        {
        }

        public DbSet<ToDoList> ToDoLists { get; set; }
    }
}