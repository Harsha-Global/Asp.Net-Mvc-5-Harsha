using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Company.DomainModels;
using Company.DataLayer;

namespace EFDbFirstApproachExample.ApiControllers
{
    public class BrandsController : ApiController
    {
        public List<Brand> GetBrands()
        {
            CompanyDbContext db = new CompanyDbContext();
            List<Brand> brands = db.Brands.ToList();
            return brands;
        }
    }
}



