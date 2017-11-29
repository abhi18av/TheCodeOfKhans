using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Assessment_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            /*creating 3 students objects*/
            var stud1 = new Student();
            var stud2 = new Student();
            var stud3 = new Student();

            /*one teacher object*/
            var teacher1 = new Teacher();

            /*Creating Course, Degree and UProgram objects*/
            var Programming_With_CSharp = new Course("Programming With CSharp");
            var Bachelor = new Degree("Bachelor");
            var IT = new UProgram("Information Technology");

            /*Adding students to the course*/
            Programming_With_CSharp.AddStud(stud1);
            Programming_With_CSharp.AddStud(stud2);
            Programming_With_CSharp.AddStud(stud3);

            /*Adding teacher to the same course as students*/
            Programming_With_CSharp.AddTeacher(teacher1);

            /*Adding Programming With CSharp to Bachelor degree*/
            Bachelor.AddCourse(Programming_With_CSharp);
            
            IT.AddDegree(Bachelor);
            
            Console.WriteLine($"The course name is { Programming_With_CSharp.courseName} \n{Bachelor.degreeName} degree");
            Console.WriteLine($"The program name is { IT.programName}");
            Console.WriteLine($"Number of students in Programming With CSharp course: {Programming_With_CSharp.StudCount()}");

            // Test code for module 2 Self Assessment Lab
            /*
            teacher1.CleanTheDesk();
            teacher1.firstName = "Maria";
            teacher1.lastName = "Romanovna";
            stud1.birthDate = "12 nov 1963";
            stud2.country = "Canada";
            stud3.school = "N 19";

            Person myperson = stud3;
            */
        }
    }
}
