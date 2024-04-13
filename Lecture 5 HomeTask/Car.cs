using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_5_HomeTask
{
    internal class Car
    {
        public const string abracadabra = "Abracadabra";

        public string name;
        public string model; 
        public int carWeight;
        public int cost;
        
        public int CarWeight
        {
            get { return carWeight; }
            set
            {
                carWeight = value;
                if (value < 2000)
                {
                    Console.WriteLine(name + " " + model + " " + "- the car is passenger car");
                }
                else if (value >= 2000 && value <=3000)
                {
                    Console.WriteLine(name + " " + model + " " + "- the car is Minivan");
                }
                else
                {
                    Console.WriteLine(name + " " + model + " " + "- the car type isn't identified");
                }
            }
        }
        public int Cost
        {
            get { return cost; }
            set
            {
                if (value <= 20000)
                {
                    Console.WriteLine(name + " " + model + " " + "the car is casual");
                }
                else if (value > 20000 && value <=50000)
                {
                    Console.WriteLine(name + " " + model + " " + "medium class");
                }
                else if (value > 50000)
                {
                    Console.WriteLine(name + " " + model + " " + "business class");
                }
            }
        }

        public Car (string name, string model)
        {
            this.name = name;
            this.model = model;
        }

        public void GetWeight ()
        {
            Console.WriteLine("Enter weight");
            carWeight = int.Parse(Console.ReadLine());
        }

        public void GetCost ()
        {
            Console.WriteLine("Enter a cost");
            cost = int.Parse(Console.ReadLine());
        }

        public void ShowDetails()
        {
            Console.WriteLine("Your car details: {0} {1}", Cost, CarWeight); 
        }

       
    }
}
