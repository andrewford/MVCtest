using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcOne.Models
{
    public class ToDo
    {
        public int ToDoID { get; set; }
        public string Description { get; set; }
        public bool isDone { get; set; }

    }
}