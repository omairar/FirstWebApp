using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult GetEmojiById(int? id)
        {
            var emoji = new[] {
                new {eid = 1, etxt= "🙈", ename = "sne" },
                new {eid = 2, etxt= "🙊", ename = "tne"},
                new {eid = 3, etxt= "🙉", ename = "hne"}
            };

            string emotName = "";

            if (id == null)
            {
                return Content("enter someting");
            }

            foreach(var emot in emoji){
                if(emot.eid == id)
                {
                    emotName = emot.etxt;
                }
                
            }
            return Content(emotName);

        }

        public ActionResult GetEmojiByName(string emtName)
        {
            var emoji = new[] {
                new {eid = 1, etxt= "🙈", ename = "sne" },
                new {eid = 2, etxt= "🙊", ename = "tne"},
                new {eid = 3, etxt= "🙉", ename = "hne"}
            };

            string emotName = "";

            if (emtName == null)
            {
                return Content("enter someting");
            }

            foreach (var emot in emoji)
            {
                if (emot.ename == emtName)
                {
                    emotName = emot.etxt;
                }

            }
            return Content(emotName);

        }

    }
}