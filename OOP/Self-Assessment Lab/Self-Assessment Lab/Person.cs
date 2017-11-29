using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Assessment_Lab
{
    abstract class Person
    {
        public string birthDate { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string school { get; set; }
        public string country { get; set; }

        public abstract void SaySomething();
        public abstract void CleanTheDesk();

    }
}
