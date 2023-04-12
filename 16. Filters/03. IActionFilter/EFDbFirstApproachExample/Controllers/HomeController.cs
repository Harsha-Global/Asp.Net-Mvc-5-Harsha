using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFDbFirstApproachExample.Filters;

namespace EFDbFirstApproachExample.Controllers
{
    public class HomeController : Controller
    {
        [MyActionFilter]
        public ActionResult Index()
        {
            return View();
        }
    }
}



