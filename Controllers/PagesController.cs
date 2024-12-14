using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace e_Learning.Controllers
{
    public class PagesController : Controller
    {
        // GET: Pages
        public ActionResult OurTeam()
        {
            return View();
        }
        public ActionResult Testimonial()
        {
            return View();
        }
    }
}