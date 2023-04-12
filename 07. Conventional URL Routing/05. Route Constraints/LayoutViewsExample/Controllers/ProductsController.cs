using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutViewsExample.Controllers
{
    public class ProductsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int? id)
        {
            var products = new[] {
                new { ProductId = 1, ProductName = "iPhone", Cost = 80000  },
                new { ProductId = 2, ProductName = "Printer", Cost = 7500  },
                new { ProductId = 3, ProductName = "Camera", Cost = 14000 }
            };
            if (id == null)
            {
                return Content("Please pass any product id");
            }
            else
            {
                string prodName = "";
                foreach (var pro in products)
                {
                    if (pro.ProductId == id)
                    {
                        prodName = pro.ProductName;
                    }
                }
                return Content(prodName);
            }
        }

        public ActionResult GetProductID(string productName)
        {
            var products = new[] {
                new { ProductId = 1, ProductName = "iPhone", Cost = 80000  },
                new { ProductId = 2, ProductName = "Printer", Cost = 7500  },
                new { ProductId = 3, ProductName = "Camera", Cost = 14000 }
            };
            if (productName == null)
            {
                return Content("Please pass any product name");
            }
            else
            {
                int prodId = 0;
                foreach (var pro in products)
                {
                    if (pro.ProductName == productName)
                    {
                        prodId = pro.ProductId;
                    }
                }
                return Content(prodId.ToString());
            }
        }
    }
}


