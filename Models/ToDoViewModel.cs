using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class ToDoViewModel
    {
        public ToDo ToDo { get; set; }
        public IEnumerable<ToDo> ToDoCollection { get; set; }
    }
}
