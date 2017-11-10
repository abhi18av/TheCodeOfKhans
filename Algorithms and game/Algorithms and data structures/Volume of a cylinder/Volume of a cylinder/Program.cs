using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volume_of_a_cylinder
{
    class Program
    {
        static void Main(string[] args)
        {
            /*check the Volume method*/
            Console.WriteLine(Volume(3, 5));
            Console.ReadKey();
        }

        /* r - radius, h - height */
        public static double Volume(int r, int h)
        {
            double pi = 3.1415;
            double v = pi * r * r * h;
            return v;
        }
    }
}
