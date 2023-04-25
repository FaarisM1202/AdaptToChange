using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace AdaptToChanges.Models
{
    public class Member : IdentityUser
    {
        [Required]
        public string MemberName { get; set; }
    }


/*  public class AdaptToChangesDbContext : IdentityDbContext
    {

        public DbSet<Member> Member { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }*/
}
