using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleVerseApp.Models
{
    interface IVerseList
    {
        List<VerseModel> GetAllVerses();
        void AddVerse(VerseModel verse);
        void DeleteVerse(VerseModel verse); 
    }
}
