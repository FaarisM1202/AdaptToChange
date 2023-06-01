using Microsoft.Identity.Client;

namespace AdaptToChanges.Models
{
    public class ToDoListViewModel
    {
        public ToDoListViewModel(List<ToDoList> toDoLists)
        {
            ToDoLists = toDoLists;
        }

        public List<ToDoList> ToDoLists { get; private set; }

        public int ToDoListId { get; private set; }

        public string ToDoListName { get; set; }
        public string ToDoListDescription { get; set; }

        public string ToDoListItems { get; set; }
    }
}
