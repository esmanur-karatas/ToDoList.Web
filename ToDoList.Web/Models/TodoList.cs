using System.ComponentModel.DataAnnotations;

namespace ToDoList.Web.Models
{
    public class TodoList
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime TaskDate { get; set; }

        public bool IsDone { get; set; }
        public string Priority { get; set; }


    }
  
}
