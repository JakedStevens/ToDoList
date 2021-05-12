using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class ToDo
    {
        [Key]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public bool IsCompleted
        {
            get { return isCompleted; }
            set { isCompleted = value; }
        }


        public void Toggle()
        {
            this.IsCompleted = !this.IsCompleted;
        }

        public void Delete()
        {

        }

        private bool isCompleted;
        private string description;
        private int id;
    }
}
