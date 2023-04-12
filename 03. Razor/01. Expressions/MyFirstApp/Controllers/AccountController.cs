using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MyFirstApp.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login(string Username, string Password)
        {
            if (Username == "admin" && Password == "manager")
                return RedirectToAction("Dashboard", "Admin");
            else
                return RedirectToAction("InvalidLogin");
        }

        public ActionResult InvalidLogin()
        {
            return View();
        }
    }
}


