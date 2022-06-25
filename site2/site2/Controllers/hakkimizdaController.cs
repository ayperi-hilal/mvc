using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using site2.Models.Sınıflar;
using System.Web.Configuration;
using System.Data.SqlClient;



namespace site2.Controllers
{
    public class hakkimizdaController : Controller
    {
        // GET: hakkimizda

        Context c = new Context();

        public ActionResult Index()
        {
            var degerler = c.hakkimizdas.ToList();

            return View(degerler);
        }
    }
}