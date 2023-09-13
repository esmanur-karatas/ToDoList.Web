
namespace ToDoList.Web.Models
{
    public class ToDoListRepository
    {
        private static List<TodoList> _todoList = new List<TodoList>();
        public List<TodoList> GetAll() => _todoList;

        //Add
        public void Add(TodoList newTodo) => _todoList.Add(newTodo);

        //Remove 
        public void Remove(int id) // id ye göre sileceğiz 
        {
            var hasTodoList =_todoList.FirstOrDefault(x => x.Id == id); 
            if(hasTodoList != null)
            {
                throw new Exception("Bu numaraya sahip Görev Bulunmamaktadır.");
            }
            _todoList.Remove(hasTodoList);
        }

        // UPDATE
        public void Update(TodoList updateTodoList)
        {
            var hasTodoList = _todoList.FirstOrDefault(x => x.Id == updateTodoList.Id);
            if(hasTodoList != null)
            {
                throw new Exception("Bu Numaraya Sahip Görev Bulunamamaktadır.");
            }
            hasTodoList.Title= updateTodoList.Title;
            hasTodoList.IsDone= updateTodoList.IsDone;
            hasTodoList.TaskDate= updateTodoList.TaskDate;
            hasTodoList.Priority=updateTodoList.Priority;

            var index = _todoList.FindIndex(x => x.Id == updateTodoList.Id);
            _todoList[index] = hasTodoList;

        }


    }
}