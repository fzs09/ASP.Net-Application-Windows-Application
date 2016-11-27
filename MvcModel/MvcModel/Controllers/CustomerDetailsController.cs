using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcModel.Models;

namespace MvcModel.Controllers
{
    public class CustomerDetailsController : Controller
    {
        //
        // GET: /CustomerDetails/

        public ActionResult Index()
        {
            Customer objcust =new Customer();
            objcust.Id = 101;
            objcust.CustCode = "C001";
            objcust.Amount = 9876.50;
            return View(objcust);
        }

    }
}
