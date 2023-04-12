using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace ViewComponentsExample.ViewComponents
{
    public class PhotoGalleryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int n)
        {
            List<string> AllImages = new List<string>() { "/img1.jpg", "/img2.jpg", "/img3.jpg", "/img4.jpg", "/img5.jpg", "/img6.jpg", "/img7.jpg", "/img8.jpg", "/img9.jpg", "/img10.jpg" };
            List<string> SelectedImages = AllImages.Take(n).ToList();
            ViewBag.myimages = SelectedImages;
            return View();
        }
    }
}


