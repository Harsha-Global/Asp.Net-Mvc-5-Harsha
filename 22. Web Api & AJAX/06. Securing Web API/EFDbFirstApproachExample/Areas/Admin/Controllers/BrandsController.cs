using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Company.DomainModels;
using EFDbFirstApproachExample.Filters;
using Company.DataLayer;

namespace EFDbFirstApproachExample.Areas.Admin.Controllers
{
    //[AdminAuthorization]
    public class BrandsController : Controller
    {
        // GET: Brands/Index
        public ActionResult Index()
        {
            return View();
        }
    }
}


