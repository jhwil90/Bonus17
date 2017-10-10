using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus17
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ContinueProgram = true;
            while (ContinueProgram == true)
            {
                int NumOfCars;
                Car CarDescription = new Car();
                Console.WriteLine("Welcome to the Grand Circus Motors admin console!");
                Console.WriteLine("How many cars are you entering?");
                NumOfCars = int.Parse(Console.ReadLine());
                Car[] Inventory = new Car[NumOfCars];

               
                for (int i = 0; i < Inventory.Length; i++)
                {

                    Console.WriteLine("Please enter the Make of the car:");
                    Inventory[i].Make = Console.ReadLine();

                    Console.WriteLine("Please enter the Model of the car:");
                    Inventory[i].Model = Console.ReadLine();

                    Console.WriteLine("Please enter the Year of the car:");
                    Inventory[i].Year = int.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter the Price of the car:");
                    Inventory[i].Price = double.Parse(Console.ReadLine());
                }

                Console.WriteLine("Current Inventory:");
                Console.WriteLine("Make \ tModel \ tYear \ t Price");
                foreach (Car UserSelection in Inventory)
                {
                    Console.WriteLine($"{UserSelection.Make} \t{UserSelection.Model} \t{UserSelection.Year} \t{UserSelection.Price}");
                }

                string UserChoice; 
                Console.WriteLine("Continue? (y/n)");
                UserChoice = Console.ReadLine();

                if (UserChoice == "N" || UserChoice == "No" || UserChoice == "no" || UserChoice == "n" && UserChoice != "yes" || UserChoice != "y")
                {
                    ContinueProgram = false;
                    Console.WriteLine("Goodbye.");
                }
                Console.ReadKey();

            }







        }
    }
}