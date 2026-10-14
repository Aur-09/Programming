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
    public class CHorror :CBook
    {
        private int ScareFactorLevel;

        private int iScareFactorLevel
        {
            get {  return ScareFactorLevel; }
            set
            {
                if (value <=0 && value<=11)
                {
                    throw new ArgumentException("The scale factor level should be 1 to 10");
                }
                else
                {
                    value = ScareFactorLevel;
                }
            }
        }
        public CHorror(string title, string author, int publicationYear, int _scareFactorLevel) : base(title, author, publicationYear)
        {
            ScareFactorLevel = _scareFactorLevel;
            GenreClassification = "Horror /Ficture";
        }

        public override string DisplayBookDetails()
        {
            return $"Title:{Title}I\nAuthor:{Author}\nPublicationYear:{PublicationYear}\nGenreClassification:{GenreClassification}\nScareFactorLevel:{ScareFactorLevel}";
        }
    }
}
