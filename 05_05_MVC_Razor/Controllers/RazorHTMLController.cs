using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _05_05_MVC_Razor.Controllers
{
    public class RazorHTMLController : Controller
    {
        // GET: RazorHTML
        public ActionResult Index()
        {
            return View();
        }
    }
}