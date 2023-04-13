namespace AdaptToChanges.Models
{
    public class ToDoListViewModel
    {
        public ToDoListViewModel(List<ToDoList> toDoLists) 
        {
            ToDoLists = toDoLists;
        }

        public List<ToDoList> ToDoLists { get; private set; }
    }
}
