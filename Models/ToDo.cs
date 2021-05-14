using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace ToDoList.Models
{
    public class ToDo
    {
        [Key]
        [BindProperty]
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

        private bool isCompleted;
        private string description;
        private int id;
    }
}
