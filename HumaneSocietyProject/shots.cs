using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyProject
{
    class shots
    {
        bool animalShots = true;
        private bool yes;

        public shots(bool animalShots)
        {
            
        }
          public void getShots()
        {
            if (animalShots == yes)
            {
                Console.WriteLine("Animal is Ok to process!");
            }
            else
            {
                Console.WriteLine("Animal needs shots before processing");
            }
           
        }

    }
}
