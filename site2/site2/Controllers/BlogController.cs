using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using site2.Models.Sınıflar;


namespace site2.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();

        BlogYorum by = new BlogYorum();

        public ActionResult Index()
        {
            //var bloglari = c.blogs.ToList();
            //return View(bloglari);

            by.deger1 = c.blogs.ToList();
            by.deger3 = c.blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            //by.deger3 = c.blogs.Take(3).ToList();
            return View(by);
        }



        public ActionResult BlokDetay(int id)
        {

            by.deger1 = c.blogs.Where(x => x.ID == id).ToList();
            by.deger2 = c.yorumlars.Where(y => y.Blogid == id).ToList();
            by.deger3 = c.blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return View(by);
        }
    }
}