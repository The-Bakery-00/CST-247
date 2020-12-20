using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibleVerseApp.Models
{
    public class VerseList : IVerseList
    {        
        private List<VerseModel> verses = new List<VerseModel>();

        public void AddVerse(VerseModel verse)
        {
            verses.Add(verse);
        }

        public void DeleteVerse(VerseModel verse)
        {
            throw new NotImplementedException();
        }

        public void ClearList()
        {
            verses.Clear();
        }

        public List<VerseModel> GetAllVerses() 
        {
            return verses;
        }
    }
}