using System.Collections.Generic;
using System.Web.Mvc;

namespace FirstWebApp.Controllers
{
    public class RazorExpressionsController : Controller
    {
        // GET: RazorExpressions
        public ActionResult Index()
        {
            ViewBag.studName = "omair";
            ViewBag.studRoll = 001;
            ViewBag.studMk = 31;
            ViewBag.emotList = new List<string>() { "🙈", "🙉", "🙊", "🐒", "🐵" };
            return View();
        }
    }
}