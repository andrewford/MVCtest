using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcOne.Controllers
{
    public class testController : Controller
    {
        //
        // GET: /test/

        public ActionResult Index(string myName = "James")
        {
            ViewBag.FirstThing = "hi there " + myName + " from Andrew";

            return View();
        }

    }
}
