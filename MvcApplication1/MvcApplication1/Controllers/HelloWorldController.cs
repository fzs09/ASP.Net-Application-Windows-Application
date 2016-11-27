using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /Home/

        public ActionResult DisplayValue()
        {
            ViewData["CurrentTime"] = DateTime.Now.ToString();
            return View();
        }

    }
}
