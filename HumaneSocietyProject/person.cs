using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyProject
{
    public class person
    {
        public string firstName;
        public string lastName;
        wallet Wallet;
        public person(string FirstName, string LastName)
        {
            firstName = FirstName;
            lastName = LastName;
            wallet Wallet = new wallet();
        }
    }
}
