using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcOne.Models;

namespace mvcOne.Controllers
{
    public class testController : Controller
    {
        //
        // GET: /test/
        dbPeople Peeps = new dbPeople();

        public ActionResult Index(string myName = "James")
        {
            ViewBag.FirstThing = "hello";

            return View();
        }

        public ActionResult hello()
        {
            var SomePeople = from p in Peeps.People
                             where p.Awesomeness > 0
                             select p;

            return View(SomePeople);
        }

    }
}
