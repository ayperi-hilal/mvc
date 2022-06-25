using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using site2.Models.Sınıflar;

namespace site2.Controllers
{
    public class DefaultController : Controller
    {
        Context c = new Context();

        // GET: Default
        public ActionResult Index()
        {
            var degerler = c.blogs.Take(5).ToList();

            return View(degerler);
        }
        public ActionResult hakkimizda()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            var degerler = c.blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial2()
        {
            var deger = c.blogs.Take(10).ToList();
            return PartialView(deger);
            /*
             lbl_ayinPersoneli.Text = db.tbl_personeller.Where(x => x.id == d1).Select(y => y.ad+" "+y.soyad).FirstOrDefault().ToString();
             */

            //var cokYorum = c.yorumlars.OrderBy(x => x.Blogid).Take(10).ToList();
            //return PartialView (cokYorum);
            /*
             <div class="padding1">
    <h4>Tavsiye Ettiğim Yerler</h4>
    <div class="box-left">
        @foreach (var x in Model)
        {
            if (x.ID <= 4)
            {
                <div class="bot-img">
                    <img src="@x.BLOGIMAGE" alt="" style="width:120px; height:80px;" />
                </div>
                <div class="bot-desc">
                    <p>@x.ACIKLAMA.Substring(0, 80) </p>
                </div>
                <div class="clear"></div>
            }

        }
    </div>
    @foreach (var y in Model)
    {
        if (y.ID >= 5 && y.ID <= 7)
        {
            <div class="box1-left">
                <div class="bot-img">
                    <img src="@y.BLOGIMAGE" alt="" style="width:120px; height:80px;" />
                </div>
                <div class="bot-desc1">
                    <p>@y.ACIKLAMA.Substring(0, 80) </p>
                </div>
                <div class="clear"></div>
            </div>
        }

    }
</div>
             */
        }

        public PartialViewResult Partial3()
        {
            var Bloklar = c.blogs.Take(3).ToList();

            return PartialView(Bloklar);
        }
    }
}