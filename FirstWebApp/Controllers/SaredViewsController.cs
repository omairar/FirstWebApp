using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApp.Controllers
{
    public class SaredViewsController : Controller
    {
        // GET: SaredViews
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult spiralMonkey()
        {
            @ViewBag.Title = "Shared";
            return View();
        }
    }
}