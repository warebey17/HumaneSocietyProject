using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyProject
{
    class employee : person
    {
        private string empFirstName;
        private string empLastName;

        public employee(string FirstName, string LastName) : base(FirstName, LastName)
        {
            empFirstName = FirstName;
            empLastName = LastName;
        }
             public new string firstName
        { 
            get { return empFirstName; }
            set { empFirstName = value == "" ? "n/a" : value; }
        }

        public new string lastName
        {
            get { return empLastName; }
            set { empLastName = value == "" ? "n/a" : value; }
          
        }

        public void getJobStatus()
        {

        }
      }
    }
  
