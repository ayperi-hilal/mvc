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
        [Authorize]
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
        public ActionResult YeniBlog(blog p)
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

        [Authorize]
        public ActionResult yorumListesi()
        {
            var yorumlar = C.yorumlars.ToList();

            return View(yorumlar);
        }

        public ActionResult yorumSil(int id)
        {
            var bb = C.yorumlars.Find(id);
            C.yorumlars.Remove(bb);
            C.SaveChanges();
            return RedirectToAction("yorumListesi");
        }

        public ActionResult yorumGetir(int id)
        {
            var yr = C.yorumlars.Find(id);
            return View("yorumGetir", yr);

        }

        public ActionResult yorumGuncelle(yorumlar b)
        {
            var blg = C.yorumlars.Find(b.ID);
            blg.Yorum = b.Yorum;
            blg.KullanciAdi = b.KullanciAdi;
            blg.Mail = b.Mail;
            C.SaveChanges();
            return RedirectToAction("yorumListesi");

        }

    }
}