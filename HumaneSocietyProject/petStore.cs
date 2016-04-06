using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyProject
{
    class petStore
    {
        public petStore()
        {
        }

        public void purchaseAnimal()
        {

            List<double> animalPrice = new List<double>() { 50.95, 155.95 };
            List<double> total = new List<double>() { 0, 0 };
            double quantity = 0;
            int userInputNum = 0;

            while (quantity != -1)
            {
                Console.WriteLine("Please enter the quantity purchased, and animal number: (1. cat, 2. dog); or enter -1 to quit");
                quantity = Convert.ToInt32(Console.ReadLine());
                if (quantity != -1)
                {
                    userInputNum = Convert.ToInt32(Console.ReadLine());

                    switch (userInputNum)
                    {
                        case 1:
                            total[0] += animalPrice.ElementAt(0) * quantity;
                            break;
                        case 2:
                            total[1] += animalPrice.ElementAt(1) * quantity;
                            break;
                        default:
                            Console.WriteLine("You entered an incorrect number.");
                            break;
                    }
                }
            }
            Console.WriteLine("The total amount taken in for dog(s) purchased: {0:N}\n", total.ElementAt(0));
            Console.WriteLine("The total amount taken in for cat(s) purchased: {0:N}\n", total.ElementAt(1));
            Console.ReadLine();
        }
        public void adoptAnimal()
        {

            List<double> animalPrice = new List<double>() { 50.95, 155.95 };
            List<double> total = new List<double>() { 0, 0 };
            double quantity = 0;
            int userInputNum = 0;

            while (quantity != -1)
            {
                Console.WriteLine("Enter the number of animal(s) you want to purchase, then enter animal number: (1. cat, 2. dog); or enter -1 to quit");
                quantity = Convert.ToInt32(Console.ReadLine());
                if (quantity != -1)
                {
                    userInputNum = Convert.ToInt32(Console.ReadLine());

                    switch (userInputNum)
                    {
                        case 1:
                            total[0] += animalPrice.ElementAt(0) * quantity;
                            break;
                        case 2:
                            total[1] += animalPrice.ElementAt(1) * quantity;
                            break;
                        default:
                            Console.WriteLine("You entered an incorrect number.");
                            break;
                    }
                }
            }
            Console.WriteLine("Your total cost for dog(s) will be: {0:N}\n", total.ElementAt(0));
            Console.WriteLine("Your total cost for cat(s) will be: {0:N}\n", total.ElementAt(1));
            Console.ReadLine();
        }
    }
}
