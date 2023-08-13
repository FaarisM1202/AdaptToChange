using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

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
        /// The items in the to-do list.
        /// </summary>
        public string ToDoListItems { get; set; }

        /// <summary>
        /// The user assigned to the List.
        /// </summary>
        public string Assignee { get; set; }
    }

    public class ListSummaryViewModel
    {

        public int ToDoListId { get; set; }
        public string ToDoListName { get; set; }

        public string ToDoListItems { get; set; }

        public string Assignee { get; set; }
    }

}
