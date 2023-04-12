using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreMvcApp.Models;

namespace CoreMvcApp.Controllers
{
    public class HomeController : Controller
    {
        [Route("employees/list")]
        public ActionResult Index()
        {
            CompanyDbContext db = new CompanyDbContext();
            List<Employee> emps = db.Employees.ToList();
            return View(emps);
        }
    }
}


