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
    public class CFantasy : CBook
    {
        public bool HasMagicSystem { get; set; }
        public CFantasy(string title, string author, int publicationYear, bool hasMagicsystm) : base(title, author, publicationYear)
        {
            HasMagicSystem = hasMagicsystm;
            GenreClassification = "Fantasy / Speculative Fiction";
        }
        public override string DisplayBookDetails()
        {
            return $"Title:{Title}I\nAuthor:{Author}\nPublicationYear:{PublicationYear}\nGenreClassification:{GenreClassification}\nScareFactorLevel:{HasMagicSystem}";
        }
    }
}
