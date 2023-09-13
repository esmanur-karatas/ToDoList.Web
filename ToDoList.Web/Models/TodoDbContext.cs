using Microsoft.EntityFrameworkCore;

namespace ToDoList.Web.Models
{
    public class TodoDbContext: DbContext
    {
        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options)
    {

    }
        public DbSet<TodoList> Todo { get; set; }

    }
}
