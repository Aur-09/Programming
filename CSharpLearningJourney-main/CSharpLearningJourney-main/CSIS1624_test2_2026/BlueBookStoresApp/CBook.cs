/*Noluthando Buda
 * 2028419741
 * CSIS1624 Semester Test 2 
 * 08 October 2026
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBookStoresApp
{
    public abstract class CBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get;}
        protected string GenreClassification { get; set; }

        //constructor that accepts three properties as parameters and assigns them
        public CBook(string title, string author, int publicationYear)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
            GenreClassification = "General Fiction";
        }
        //abstract method that contains no body
        public abstract string DisplayBookDetails();
    }
}
