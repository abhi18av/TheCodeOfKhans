using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Assessment_Lab
{
    class Student : Person
    {
        public override void CleanTheDesk()
        {
            Console.WriteLine("Desk is clean!");
        }
        public override void SaySomething()
        {
            Console.WriteLine("I love homeworks!");
        }
        public void TakeTest()
        {
            Console.WriteLine("Taking a new test!");
        }
    }
}
