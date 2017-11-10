using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingStructs
{
    struct Car
    {
        public string Make;
        public string Model;
        public string Color;
        public int Price;
        public int Wheels;

        public void Accelerate()
        {
            Console.WriteLine("Vroom!");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Ford";
            myCar.Model = "Mustang";
            myCar.Color = "Grey";
            myCar.Price = 25000;
            myCar.Wheels = 4;
            Console.WriteLine($"My car is a {myCar.Make} {myCar.Model} that is {myCar.Color} in color.");
            Console.WriteLine();
            myCar.Accelerate();
            Console.ReadKey();
        }
    }
}
