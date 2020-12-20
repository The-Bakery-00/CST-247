using BibleVerseApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BibleVerseApp.Controllers
{
    //Controls the search funtion on the search page
    public class SearchController : Controller
    {
        private VersesDB versesDB = new VersesDB();        
        private VerseList verseList = new VerseList();
        
        // GET: Search
        public ActionResult Index()
        {
            return View();
        }

        //takes in the search criteria from the search form, and returns matches
        [HttpPost]
        public ActionResult Search([Bind(Include = "Testament,Book,Chapter,Number,Text")] Models.SearchModel verse)
        {
            List<Table> tables = versesDB.Tables.ToList();
            List<VerseModel> temp = new List<VerseModel>();

            foreach (Table t in tables)
            {
                verseList.AddVerse(t.toVerse());
            }

            //if statements check if the fields were empty or not, and if not narrows the list down to the matches
            if (verse.Testament != null)
            {
                var testtest = from VerseModel in verseList.GetAllVerses()
                               where VerseModel.Testament.ToLower().Contains(verse.Testament.ToLower())
                               select VerseModel;

                temp.Clear();
                foreach (var v in testtest)
                {
                    temp.Add(v);
                }

                verseList.ClearList();
                foreach (var v in temp)
                {
                    verseList.AddVerse(v);
                }
            }
            if (verse.Book != null)
            {
                var testtest = from VerseModel in verseList.GetAllVerses()
                               where VerseModel.Book.ToLower().Contains(verse.Book.ToLower())
                               select VerseModel;

                temp.Clear();
                foreach (var v in testtest)
                {
                    temp.Add(v);
                }

                verseList.ClearList();
                foreach (var v in temp)
                {
                    verseList.AddVerse(v);
                }
            }
            if (verse.Chapter > 0)
            {
                var testtest = from VerseModel in verseList.GetAllVerses()
                               where VerseModel.Chapter.Equals(verse.Chapter)
                               select VerseModel;

                temp.Clear();
                foreach (var v in testtest)
                {
                    temp.Add(v);
                }

                verseList.ClearList();
                foreach (var v in temp)
                {
                    verseList.AddVerse(v);
                }
            }
            if (verse.Number > 0)
            {
                var testtest = from VerseModel in verseList.GetAllVerses()
                               where VerseModel.Number.Equals(verse.Number)
                               select VerseModel;

                temp.Clear();
                foreach (var v in testtest)
                {
                    temp.Add(v);
                }

                verseList.ClearList();
                foreach (var v in temp)
                {
                    verseList.AddVerse(v);
                }
            }
   
          //If the list ended up empty at the end, a "Not Found" page is displayed
            if (verseList.GetAllVerses().Count <= 0)
            {
                return View("NotFound");
            }
            //Sends the search results to a ResultsModel and shows the Results view with the newly created model
            else
            {
                //TODO make "Results"
                ResultsModel results = new ResultsModel(verseList.GetAllVerses());
                return View("Results", results);
            }
        }
    }
}