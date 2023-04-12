using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TagHelpersExample.Models;

namespace TagHelpersExample.Controllers
{
    public class EmployeesController : Controller
    {
        [Route("/Employees/Create")]
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [Route("/Employees/Create")]
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            Company2DbContext db = new Company2DbContext();
            db.Employees.Add(emp);
            db.SaveChanges();
            return Content("Inserted");
        }
    }
}


