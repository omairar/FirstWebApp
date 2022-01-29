using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApp.Controllers
{
    public class ActionssController : Controller
    {
        // GET: Actionss
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetContentResult()
        {
            //return new ContentResult() { Content = "content result Achieved", ContentType = "text/plain" }
            return Content("content result Achieved", "text/plain");
        }

        public ActionResult GetFileResult(int picId)
        {
            string fileName = "~/Content/img" + picId + ".png";
            
            return File(fileName, "image/png");
        }

        public ActionResult GetRedirectResult()
        {
            

            return Redirect("https://www.google.com/");
        }

        public ActionResult GetRedirecttoRouteResult(int routeId)
        {

            if(routeId == 1)
            {
                // redirect to action in different Controller
                return RedirectToAction("index", "home");
            }
            else if (routeId == 2)
            {
                // redirect to action in within same Controller
                return RedirectToAction("GetContentResult");
            }
            return Redirect("https://www.google.com/");
        }
    }
}