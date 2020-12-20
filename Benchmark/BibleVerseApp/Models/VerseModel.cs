using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BibleVerseApp.Models
{
    [Table("Table")]
    public class VerseModel
    {
        [Required]
        [Display(Name = "Testament")]
        [StringLength(50, MinimumLength = 3)]
        public string Testament { get; set; }

        [Required]
        [Display(Name = "Book")]
        [StringLength(50, MinimumLength = 3)]
        public string Book { get; set; }

        [Required]
        [Display(Name = "Chapter")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Chapter must be Numeric")]
        public int Chapter { get; set; }

        [Required]
        [Display(Name = "Verse Number")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Verse Number must be Numeric")]
        public int Number { get; set; }

        [Required]
        [Display(Name = "Verse Text")]
        [StringLength(1000, MinimumLength = 10)]
        public string Text { get; set; }

        public VerseModel()
        {

        }

        public VerseModel(string _testament, string _book, int _chapter, int _number, string _text)
        {
            Testament = _testament;
            Book = _book;
            Chapter = _chapter;
            Number = _number;
            Text = _text;
        }
    }
}