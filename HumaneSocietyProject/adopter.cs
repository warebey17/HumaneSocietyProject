using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyProject
{
    class adopter : person
    {
        private string adoptFirstName;
        private string adoptLastName;

        public adopter(string FirstName, string LastName) : base(FirstName, FirstName)
        {
            adoptFirstName = FirstName;
            adoptLastName = LastName;
        }

        
        public new string firstName
        {
            get { return adoptFirstName; }
            set { adoptFirstName = value == "" ? "n/a" : value; }
        }

        public new string lastName
        {
            get { return adoptLastName; }
            set { adoptLastName = value == "" ? "n/a" : value; }
        }
    }
}


