using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyProject
{
    public class animal
    {
        //public string nameOfAnimal;
        public string age;
        public int animalWeight;
        List<animal> Animals = new List<animal>();

        public animal(string NameOfAnimal, string Age, int animalWeight,  string TypeOfAnimal )
        {
            //nameOfAnimal = NameOfAnimal;
            //age = Age;
            //typeOfAnimal = TypeOfAnimal;
        }

        public void nameOfAnimal()
        {

        }
        //public string getAnimalType()
        //{
        //    return typeOfAnimal;
        //}
        //public string animalAge()
        //{
        //    return age;
        //}

        //public string animalName()
        //{
        //    return nameOfAnimal;
        //}
        //public override string ToString()
        //{
        //    return String.Format("Animal Type: {0}\n" + "Animal age: {1}\n" + "Animal name: {2}\n", typeOfAnimal, age, nameOfAnimal);
        //}
       
    }
}
