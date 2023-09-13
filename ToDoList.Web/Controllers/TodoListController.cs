using Microsoft.AspNetCore.Mvc;
using ToDoList.Web.Models;
using System.Collections.Generic;
using System.Linq;
using static System.Reflection.Metadata.BlobBuilder;


namespace ToDoList.Web.Controllers
{
    public class TodoListController : Controller
    {
        private TodoDbContext _contex;
        //repository kullanmak istedik.
        private readonly ToDoListRepository _toDoListRepository;

        //constructor
        public TodoListController(TodoDbContext contex)
        {
            _toDoListRepository = new ToDoListRepository();
            _contex = contex;
        }

        public IActionResult Index()
        {
            var toDoList = _contex.Todo.ToList();

            return View(toDoList);
        }

        //Remove
        public IActionResult Remove(int id)
        {
            var toDoList =_contex.Todo.Find(id);
            _contex.Todo.Remove(toDoList);
            _contex.SaveChanges();

            return RedirectToAction("Index");
        }
        //ADD
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(TodoList newTodo) //Tip güvenlikli kullanıcıdan alınan verileri kaydetmek için oluşturduk.
        {

            _contex.Todo.Add(newTodo); // verileri git add metodunun içine kaydet.
            _contex.SaveChanges();
            return RedirectToAction("Index");
        }
        //Update
        [HttpGet]
    public IActionResult Update(int id)
        {
            var toDoList = _contex.Todo.Find(id);
            return View(toDoList);
        }
        [HttpPost]
        public IActionResult Update(TodoList updateTodoList)
        {
        _contex.Todo.Update(updateTodoList);
        _contex.SaveChanges();
        return RedirectToAction("Index");
        

        }

    }
}


