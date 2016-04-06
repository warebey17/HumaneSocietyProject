using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyProject
{
    class humaneSociety
    {
        List<string> cage = new List<string>();
        shots Shots;
        List<string> employee = new List<string>();
        List<string> adopter = new List<string>();
        petStore Store = new petStore();
        public int workerOrAdopter;
        public int counter;
        private bool animalShots;

        public humaneSociety()
        {
            cage Cage = new cage();
            
            
            //employee Employee = new employee();
            // Animals = new animal[100];
            counter = 0;
        }
        public void greet()
        {
            Console.WriteLine("***Welcome to the Humane Society***\n");
            
            Console.WriteLine("Please enter your FIRST NAME: ");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Please enter your LAST NAME: ");
            string LastName = Console.ReadLine();

            Console.WriteLine("Are you an Employee or are you Adopting today? (Enter 1 for Employee or 2 for Adopter)");

            workerOrAdopter = Convert.ToInt32(Console.ReadLine());


            if (workerOrAdopter == 1)
            {
                employee Employee = new employee(FirstName, LastName);
                Console.WriteLine("{0} are we adding a cat or a dog to the system today?", Employee.firstName);
                string catOrDog = Console.ReadLine();
                                                          
                Console.WriteLine("Enter animal name:");
                string nameOfAnimal = Console.ReadLine();

                Console.WriteLine("Enter which cage the animal is in:");
                string animalCage = Console.ReadLine();

                Console.WriteLine("Does this animal have his/her shots: (Type Yes or No)");
                string getShots = Console.ReadLine();
               
                Console.WriteLine("Enter the weight of the animal");
                string animalWeight = Console.ReadLine();

                //Console.WriteLine("Employee: {0} {1}", Employee.firstName, Employee.lastName);
                //catOrDog CatOrDog = new catOrDog(); Console.WriteLine("Adding animal: " + );
                //shots Shots = new shots(animalShots); Console.WriteLine();
                Store.purchaseAnimal();
                    

                


            }
            else
            {
                adopter Adopter = new adopter(FirstName, LastName);
                Console.WriteLine("Nice. Adopting an animal from the Humane Society really helps. (press enter/return to continue)");
                Console.ReadLine();
                Console.WriteLine("I have some basic questions to ask you. (press enter/return to continue)");
                Console.ReadLine();
                Console.WriteLine("{0} please enter your job:", Adopter.firstName);
                string employee = Console.ReadLine();
                Console.WriteLine("{0}, are you adopting a cat, dog or both today? (enter: dog, cat or both", Adopter.firstName);
                string catOrDog = Console.ReadLine();

                //Console.WriteLine("Here is a list of our dogs in our system");
                //string getDogList = Console.ReadLine();
                //Console.WriteLine("Here is a List of the Cats in our system");
                //string getCatList = Console.ReadLine();

                Store.adoptAnimal();


                Console.WriteLine("Enter the weight of the cat/dog that you adopted today:");
                string animalWeight = Console.ReadLine();






            }
            Console.ReadLine(); 
        }

        //1. Must be able to add an animal to the system
        //public void addAnimal(animal newAnimal)
        //{

        //    Animals[counter] = newAnimal;
        //    counter++;


        //}

        //public void trackAnimals()
        //{

        //    int animalTot = 0;
        //    for (int i = 0; i < counter; i++)
            //{
            //    animalTot += Animals[i].
            //        }
        

    }
        
    }


    

