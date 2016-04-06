using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyProject
{
    class cats //: animal
    {
        public string catName; 
        List<cats> Cats = new List<cats>();
        public cats(string NameOfAnimal, string Age, int animalWeight) //: base(NameOfAnimal, Age, animalWeight)
        {

        }
        public string nameOfAnimal
        {
            get { return catName; }
            set { catName = value == "" ? "n/a" : value; }
            //}
            //public double weightOfCat()
            //{
            //    Random random = new Random();
            //    animalWeight = random.Next(5, 101);
            //    return animalWeight;
            //}

            //public void getCatFood()
            //{
            //    if (animalWeight < 5)
            //    {
            //        Console.WriteLine("Choose a cat weight of 5 lbs, 10 lbs or 15 lbs please....");
            //        getCatFood();
            //    }
            //    else if (animalWeight >= 5 && animalWeight < 10)
            //    {
            //        Console.WriteLine("Feed your cat 1/4 cup(30g) - 1/3 cup(40g) of food per day");
            //    }
            //    else if (animalWeight >= 10 && animalWeight < 15)
            //    {
            //        Console.WriteLine("Feed your cat 3/8 cup(45g) - 1/2 cup(65g) of food per day");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Feed your cat 1/2 cup(65g) - 3/4 cup(95g) of food per day");
            //    }
        }
    }
}
