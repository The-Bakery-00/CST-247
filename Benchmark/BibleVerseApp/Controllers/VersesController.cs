using BibleVerseApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BibleVerseApp.Controllers
{
    //Controller for creating verses and adding them to the database
    public class VersesController : Controller
    {             
        private VersesDB versesDB1 = new VersesDB();

        // GET: Verses
        public ActionResult Index()
        {
            return View();
        }
        
        // POST: Verses/Create
        [HttpPost]
        public ActionResult Create([Bind(Include ="Testament,Book,Chapter,Number,Text")] Models.Table verse)
        {
            try
            {                
                versesDB1.Tables.Add(verse);
                versesDB1.SaveChanges();
                
                return View("Success");
            }
            catch
            {
                return View("Failure");
            }
        }
    }
}
