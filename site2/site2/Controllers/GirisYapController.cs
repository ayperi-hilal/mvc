using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using site2.Models.Sınıflar;

namespace site2.Controllers
{
    public class GirisYapController : Controller
    {
        // GET: GirisYap
        Context C = new Context();

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Admin ad)
        {
            var bilgiler = C.Admins.FirstOrDefault(x => x.kullanici == ad.kullanici && x.sifre == ad.sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.kullanici, false);
                Session["kullanici"] = bilgiler.kullanici.ToString();
                return RedirectToAction("Index", "Admin");

            }
            else
            {/*View bag ile mesaj döndürülebilir*/
                return View();
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "GirisYap");
        }






    }
}