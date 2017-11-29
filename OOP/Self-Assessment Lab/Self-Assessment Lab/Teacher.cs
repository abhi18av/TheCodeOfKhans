using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Assessment_Lab
{
    class Teacher : Person
    {
        public override void CleanTheDesk()
        {
            Console.WriteLine("Clean the desk - done!");
        }
        public override void SaySomething()
        {
            Console.WriteLine("No homework for today!");
        }
        public void GradeTest()
        {
            Console.WriteLine("We have a test today!");
        }
    }
}
