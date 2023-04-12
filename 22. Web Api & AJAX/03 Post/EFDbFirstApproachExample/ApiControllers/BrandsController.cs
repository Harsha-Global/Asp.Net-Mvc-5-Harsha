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

        public Brand GetBrandByBrandID(long BrandID)
        {
            CompanyDbContext db = new CompanyDbContext();
            Brand existingBrand = db.Brands.Where(temp => temp.BrandID == BrandID).FirstOrDefault();
            return existingBrand;
        }

        public void PostBrand(Brand newBrand)
        {
            CompanyDbContext db = new CompanyDbContext();
            db.Brands.Add(newBrand);
            db.SaveChanges();
        }

        public void PutBrand(Brand brandData)
        {
            CompanyDbContext db = new CompanyDbContext();
            var existingBrand = db.Brands.Where(temp => temp.BrandID == brandData.BrandID).FirstOrDefault();
            existingBrand.BrandName = brandData.BrandName;
            db.SaveChanges();
        }
    }
}



