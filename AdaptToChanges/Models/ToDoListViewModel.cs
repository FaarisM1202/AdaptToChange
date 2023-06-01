using Microsoft.Identity.Client;

namespace AdaptToChanges.Models
{
    public class ToDoListViewModel
    {
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
    }
}
