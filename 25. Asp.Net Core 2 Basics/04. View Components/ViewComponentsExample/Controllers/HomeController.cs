using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ViewComponentsExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("/Home/Index")]
        public ActionResult Index()
        {
            return View();
        }
    }
}



