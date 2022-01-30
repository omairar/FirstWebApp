using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApp.Controllers
{
    public class HttpObjectsController : Controller
    {
        // GET: HttpObjects
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult getRequestObjects()
        {
            ViewBag.reqURL = Request.Url;
            ViewBag.reqPAP = Request.PhysicalApplicationPath;
            ViewBag.reqP = Request.Path;
            ViewBag.reqBT = Request.Browser.Type;
            ViewBag.reqQS = Request.QueryString["n"];
            ViewBag.reqH = Request.Headers["Accept"];
            ViewBag.reqHTM = Request.HttpMethod;
            return View();
        }

        public ActionResult setResponseObjects()
        {
            Response.Write("Hello world");
            Response.ContentType = "text/html";
            Response.Headers["Server"] = "My server";
            Response.StatusCode = 500;
            
            return View();
        }
    }
}