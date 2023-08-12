using Microsoft.Identity.Client;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AdaptToChanges.Models
{
    public class ToDoListViewModel
    {
        public ToDoListViewModel()
        {
        }

        /// <summary>
        /// This is a ViewModel of a to-do list taking in a parameter
        /// of an object lists of to-do list.
        /// </summary>
        /// <param name="toDoLists"></param>
        public ToDoListViewModel(List<ToDoList> toDoLists) 
        { 
            ToDoLists = toDoLists;
        }

        /// <summary>
        /// This is type of list objects that is accessed by a single
        /// to-do list.
        /// </summary>
        public List<ToDoList> ToDoLists { get; private set; }

        /// <summary>
        /// This is the id of the specific to-do list
        /// </summary>
        public int ToDoListId { get; private set; }

        /// <summary>
        /// This is the name of the to-do list
        /// </summary>
        public string ToDoListName { get; set; }

        /// <summary>
        /// This is going to be the description of the to-do list
        /// </summary>
        public string ToDoListDescription { get; set; }

        /// <summary>
        /// The items of the to-do list
        /// </summary>
        public string ToDoListItems { get; set; }

        public string Assignee { get; set; }
    }
}
