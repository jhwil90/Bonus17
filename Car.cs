using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus17
{
    class Car
    {
        //Methods
        public void Cars()
        {
            Console.WriteLine("Please enter the cars make.");
            Make = Console.ReadLine();

            Console.WriteLine("Please enter the car's model.");
            Model = Console.ReadLine();

            Console.WriteLine("Please enter the year of the car.");
            Year = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the car's price.");
            Price = double.Parse(Console.ReadLine()); }


        //Members
        private string make;
        private string model;
        private int year;
        private double price;

        // property
        public string Make
        {
            set { make = value; }
            get { return make; }

        }

        public string Model
        {
            set { model = value; }
            get { return model; }
        }

        public int Year
        {
            set { year = value; }
            get { return year; }
        }

        public double Price
        {
            set { price = value; }
            get { return price; }
        }

        //Constructors
        public Car() 
        {
            make = "";
            model = "";
            year = 0;
            price = 0;

            //Constructors

            public void Cars(string CarMake, string CarModel, int CarYear, double CarPrice);
            {
                model = "CarModel";
                make = "CarMake";
                price = Int32.Parse(("CarPrice"));
                year = double.(("CarPrice"));

            }

        }
    }
