using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcOne.Models
{
    public class Person
    {
        public int PersonID { get; set; }
        public string PersonName { get; set; }
        public int Awesomeness { get; set; }
        public DateTime Birthday { get; set; }

        public virtual ICollection<ToDo> ToDos { get; set; }

    }
}