using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        public ActionResult Bio()
        {
            return View();
        }

        public ActionResult Education()
        {
            return View();
        }

        public ActionResult PersonalInfo()
        {
            return View();
        }

        public ActionResult Project()
        {
            return View();
        }

        public ActionResult Refference()
        {
            return View();
        }
    }
}