using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace mvcOne.Models
{
    public class dbPeople : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<ToDo> ToDos { get; set; }

    }


    public class dbPeopleInitializer : DropCreateDatabaseIfModelChanges<dbPeople>
    {
        protected override void Seed(dbPeople context)
        {
            var people = new List<Person>
            {
                new Person { 
                    PersonID=1,
                    Awesomeness = 67,
                    Birthday = new DateTime(1979,11,5),
                    PersonName = "Andrew Ford"
                },

                new Person { 
                    PersonID=2,
                    Awesomeness = 65,
                    Birthday = new DateTime(1985,6,7),
                    PersonName = "James Ford"
                }


            };
            people.ForEach(p => context.People.Add(p));

            context.SaveChanges();
        }
    }

}