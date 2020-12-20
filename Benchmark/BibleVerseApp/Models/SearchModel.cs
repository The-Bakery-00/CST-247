using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BibleVerseApp.Models
{
    [One(ErrorMessage = "You must enter at least one field to search")]
    public class SearchModel
    {        
        [Display(Name = "Testament")]        
        public string Testament { get; set; }
                
        [Display(Name = "Book")]        
        public string Book { get; set; }

        [Display(Name = "Chapter")]
        [Numeric(ErrorMessage = "Chapter Number must be numeric")]
        public int? Chapter { get; set; }

        [Display(Name = "Verse Number")]
        [Numeric(ErrorMessage = "Verse Number must be numeric")]
        public int? Number { get; set; }
                
        [Display(Name = "Verse Text")]        
        public string Text { get; set; }    
        
        public SearchModel()
        {

        }

        public SearchModel(string _testament, string _book, int _chapter, int _number, string _text)
        {
            Testament = _testament;
            Book = _book;
            Chapter = _chapter;
            Number = _number;
            Text = _text;
        }
    }
}