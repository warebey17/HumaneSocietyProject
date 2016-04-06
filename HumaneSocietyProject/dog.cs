using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyProject
{
    class dog //: animal       
    {
        public string dogName;
        List<dog> Dogs = new List<dog>();

        public dog(string NameOfAnimal, string Age, int animalWeight) //: base(NameOfAnimal, Age, animalWeight)
        {
            NameOfAnimal = dogName;
            
        }
        public new string nameOfAnimal
        {
            get { return dogName; }
            set { dogName = value == "" ? "n/a" : value; }
        

       


            //}
            //public double weightOfDog()
            //{
            //    Random random = new Random();
            //    animalWeight = random.Next(5, 101);
            //    return animalWeight;
            //}
            //public void getDogFood()
            //{
            //    if (animalWeight < 5)
            //    {
            //        Console.WriteLine("Choose a dog between weights 5 lbs and 100 lbs please....");
            //        getDogFood();
            //    }
            //    else if (animalWeight >= 5 && animalWeight < 10)
            //    {
            //        Console.WriteLine("Feed your dog 1/2 cup(50g) - 5/8 cup (65g) of food per day");
            //    }
            //    else if (animalWeight >= 10 && animalWeight < 20)
            //    {
            //        Console.WriteLine("Feed your dog 3/4 cup(75g) - 1 cup (100g) of food per day");
            //    }
            //    else if (animalWeight >= 20 && animalWeight < 40)
            //    {
            //        Console.WriteLine("Feed your dog 1 1/4 cup(130g) - 1 3/4 cup(180g) of food per day");
            //    }
            //    else if (animalWeight >= 40 && animalWeight < 60)
            //    {
            //        Console.WriteLine("Feed your dog 2 1/4 cup(230g) - 3 cup(305g) of food per day");
            //    }
            //    else if (animalWeight >= 60 && animalWeight < 80)
            //    {
            //        Console.WriteLine("Feed your dog 3 cup(305g) - 4 cup(410g) of food per day");
            //    }
            //    else if (animalWeight >= 80 && animalWeight < 100)
            //    {
            //        Console.WriteLine("Feed your dog 3 2/3 cup(375g) - 5 cup(510g) of food per day");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Feed your dog 4 1/4 cup(435g) - 6 cup(610g) of food per day");
            //    }
        }
    }
   }

