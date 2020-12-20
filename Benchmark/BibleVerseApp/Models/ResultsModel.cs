using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibleVerseApp.Models
{
    public class ResultsModel
    {
        public List<VerseModel> results { get; set; }

        public ResultsModel(List<VerseModel> _results)
        {
            results = _results;
        }        
    }
}