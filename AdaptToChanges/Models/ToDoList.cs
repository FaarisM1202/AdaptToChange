using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.DataAnnotations;

namespace AdaptToChanges.Models
{
    /// <summary>
    /// Represents a single to-do list.
    /// </summary>
    public class ToDoList
    {
        /// <summary>
        /// The unique identifier for the to-do list.
        /// </summary>
        [Key]
        public int ToDoListId { get; set; }

        /// <summary>
        /// The name of the to-do list.
        /// </summary>
        [Required]
        public string ToDoListName { get; set; }

        /// <summary>
        /// The description of the to-do list.
        /// </summary>
        [Required]
        public string ToDoListDescription { get; set; }

        /// <summary>
        /// The unique identifier for the member who owns the to-do list.
        /// </summary>
        ///         public string MemberId { get; set; }
/*        public string MemberName { get; set; }
        public string MemberId { get; set; }*/
    }

    public class ListViewModel
    {
        public int ToDoListId { get; set; }
        public string ToDoListName { get; set; }
        public string ToDoListDescription { get; set; }
        public string MemberName { get; set; }
        public string MemberId { get; set; }
    }
}
