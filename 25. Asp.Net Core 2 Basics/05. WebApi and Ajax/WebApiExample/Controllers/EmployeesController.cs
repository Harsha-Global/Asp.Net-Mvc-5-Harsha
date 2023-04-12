using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiExample.Models;

namespace WebApiExample.Controllers
{
    [Produces("application/json")]
    [Route("api/Employees")]
    public class EmployeesController : Controller
    {
        public List<Employee> Get(string searchStr)
        {
            CompanyDbContext db = new CompanyDbContext();
            List<Employee> emps = db.Employees.Where(temp => temp.EmpName.Contains(searchStr)).ToList();
            return emps;
        }
    }
}


