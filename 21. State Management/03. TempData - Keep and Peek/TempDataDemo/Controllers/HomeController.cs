using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TempDataDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TempData["Message"] = "Hello";
            return RedirectToAction("Index2");
        }

        public ActionResult Index2()
        {
            /*string s = Convert.ToString(TempData["Message"]);
            TempData.Keep("Message");*/
            string s = Convert.ToString(TempData.Peek("Message"));
            return RedirectToAction("Index3");
        }

        public ActionResult Index3()
        {
            string s = Convert.ToString(TempData["Message"]);
            ViewBag.s = s;
            return View();
        }
    }
}


