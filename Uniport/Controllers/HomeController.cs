using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Uniport.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ilanlar()
        {
            return View();
        }
        public ActionResult ilanver()
        {
            return View();
        }
        public ActionResult satistakiler()
        {
            return View();
        }
        public ActionResult hakkimizda()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

       
    }
}