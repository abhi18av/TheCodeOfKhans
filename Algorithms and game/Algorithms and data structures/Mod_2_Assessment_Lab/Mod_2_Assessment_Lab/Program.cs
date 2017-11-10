using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_2_Assessment_Lab
{
    public struct Student
    {
        public string name;
        public int math_mark;
        public void Study()
        {
            Console.WriteLine("Student is studying");
        }
    }
    public struct Teacher
    {
        public string name;
        public void Tech()
        {
            Console.WriteLine("Teacher is teaching");
        }
    }
    
    class Program

    {
        static void Main(string[] args)
        {
            Student[] studArray = new Student[5];

            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();
            Student student4 = new Student();
            Student student5 = new Student();

            studArray[0] = student1;
            studArray[1] = student2;
            studArray[2] = student3;
            studArray[3] = student4;
            studArray[4] = student5;

            student1.name = "Sunny";
            student2.name = "Jane";
            student3.name = "Deborah";
            student4.name = "Jack";
            student5.name = "Nick";

            for (int i = 0; i < studArray.Length ;i++)
            {

            }
            student4.math_mark = 83;

            for (int i = 0; i < studArray.Length; i++)
            {
                Console.WriteLine(studArray[i].name);
            }

            Console.WriteLine(student5.name);
            Console.WriteLine($"student 4 math mark is {student4.math_mark}");

            Teacher teacher = new Teacher();

            Console.ReadKey();
        }
    }
}
