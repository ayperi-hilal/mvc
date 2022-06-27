using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using site2.Models.Sınıflar;

namespace site2.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context C = new Context();
        public ActionResult Index()
        {
            var degerler = C.blogs.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }


        [HttpPost]
        public ActionResult YeniBlog(blog p )
        {
            C.blogs.Add(p);
            C.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult blogSil(int id)
        {
            var bb = C.blogs.Find(id);
            C.blogs.Remove(bb);
            C.SaveChanges();
            return RedirectToAction("Index");

        }



        public ActionResult blogGetir(int id)
        {
            var bl = C.blogs.Find(id);
            return View("blogGetir", bl);

        }

        public ActionResult BlogGuncelle(blog b)
        {
            var blg = C.blogs.Find(b.ID);
            blg.Aciklama = b.Aciklama;
            blg.baslik = b.baslik;
            blg.BlogImage = b.BlogImage;
            blg.Tarih = b.Tarih;
            C.SaveChanges();
            return RedirectToAction("Index");

        }



    }
}