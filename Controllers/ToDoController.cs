using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Models;
using ToDoList.Data;
using System.Dynamic;

namespace ToDoList.Controllers
{
    public class ToDoController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ToDoController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            ToDoViewModel toDosModels = new ToDoViewModel();
            toDosModels.ToDoCollection = _db.ToDos;
            toDosModels.ToDo = new ToDo();
            // ToDo toDoModel = new ToDo();
            // IEnumerable<ToDo> toDoCollection = _db.ToDos;
            return View(toDosModels);
        }

        // POST - Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ToDo obj)
        {
            _db.ToDos.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
