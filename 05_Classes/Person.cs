using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Person
    {

      public Person() { }

        public Person(string firstName, string lastName, DateTime dob, string socialSec, int credit)
      {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dob;
            SocialSecurity = socialSec;
            CreditScore = credit;
        }
        public string FirstName { get; set; }
        private string _LastName;
        public string LastName 
        { get { return _LastName[0].ToString(); } // it hides the full last name but will show the first letter.
          set { _LastName = value; } 
        
        }
        public string FullName  {
         
         get
            {
                return $"{FirstName} {LastName}";
            }
        
        }
        public DateTime DateOfBirth { get; set; }
        private string _socialSecurity;
        public string SocialSecurity 
        //Split make the string in to array, splitting at that character
        { get { return _socialSecurity.Split('-')[2]; } // it will display the last four digit.
            
         set { _socialSecurity = value; }
        
        }
        public int CreditScore { get; set; }
        public Vehicle Tranport { get; set; }


    }
}
