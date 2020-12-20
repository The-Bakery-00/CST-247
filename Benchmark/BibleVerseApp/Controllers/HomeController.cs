using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BibleVerseApp.Controllers
{
    //Controls home page links
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Bible Verse Application";

            return View();
        }
        
        public ActionResult AddVerse()
        {
            ViewBag.Message = "Fill out the form to add a new Bible Verse";

            return View();
        }

        public ActionResult Search()
        {
            ViewBag.Message = "Fill at least one field to search your saved Bible verses";

            return View();
        }
    }
}