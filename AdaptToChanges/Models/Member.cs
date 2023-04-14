using System.ComponentModel.DataAnnotations;
namespace AdaptToChanges.Models
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }
        [Required]
        public string MemberName { get; set; }
       
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public string PhoneNumber { get; set; }
    }


}
