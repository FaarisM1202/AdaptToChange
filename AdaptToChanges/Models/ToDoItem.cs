namespace AdaptToChange.Models
{
    public class ToDoItem
    {
        public string Task { get; set; }
        public string Assignee { get; set; }

        public ToDoItem(string task, string assignee = null) 
        {
            Task = task;
            Assignee = assignee;
        }
    }

    public class ToDoList
    {
        private List<ToDoItem> items;

        public ToDoList()
        {
            items = new List<ToDoItem>();
        }

        public void AddItem(string task, string assignee = null)
        {
            ToDoItem item = new ToDoItem(task, assignee);
            items.Add(item);
        }

        public List<ToDoItem> GetItems()
        {
            return items;
        }
    }
}
