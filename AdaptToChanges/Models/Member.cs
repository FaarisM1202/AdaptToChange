using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace AdaptToChanges.Models
{
    /// <summary>
    /// This members class implements the identity user
    /// which we can use to find users and have them as members.
    /// </summary>
    public class Member : IdentityUser
    {

    }
}
