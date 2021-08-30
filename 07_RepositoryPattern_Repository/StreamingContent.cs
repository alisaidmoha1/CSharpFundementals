using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public class StreamingContent
    {
        //backing field it backs up the title property
        private string _title;
        public string Title { get { return _title; }
            set
            {
                _title = value.ToUpper();
                // string[] words = value.Split(' ');
                // foreach (string words in value) {
                //
            }
                }
        public string Description { get; set; }
        public double StarRating { get; set; }
        public MaturityRating MaturityRating { get; set; }
        public bool IsFamilyFriendly { get
            { 
                switch (MaturityRating)
                {
                    case MaturityRating.G:
                    case MaturityRating.TVG:
                    case MaturityRating.PG:
                        return true;
                   // case MaturityRating.PG13:
                   // case MaturityRating.R:
                   // case MaturityRating.NC17:
                     //   return false;
                    default:
                        return false;
                }
            }
            }

        public GenreType GenreType { get; set; }

        public bool IsMature { get; set; }

        public StreamingContent() { }

        public StreamingContent(string title, string description, MaturityRating maturityRating, double stars, GenreType genre )
        {
           /*  if (string.IsNullOrWhiteSpace(title))
            {
                throw. new Exception("Content Needs tile")
            } */
            Title = title;
            Description = description;
            MaturityRating = maturityRating;
            StarRating = stars;
            //IsFamilyFriendly = familyFriendly; we dont need this line becaue we get rid of the setter we just need the getter
            GenreType = genre;

        }

        // Refactor the class so that IsFamilyFriendly always give the right answer
     

    }
}
public enum MaturityRating { G =1, PG, PG13,  R, NC17, TVMA, TVG, TVY }
public enum GenreType { SciFi=1, Comedy, Horror, RomCom, Documentry, Western, Action}
