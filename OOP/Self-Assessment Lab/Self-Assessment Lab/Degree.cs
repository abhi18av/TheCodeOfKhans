using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Assessment_Lab
{
    class Degree
    {
        public const int ARRAY_SIZE = 10;
        Course[] courses = new Course[ARRAY_SIZE];
        int i = 0; /*array index*/
        public string degreeName { get; set; }/*to get or set a degree name*/
        public Degree(string name)
        {
            this.degreeName = name;
        }

        public void AddCourse(Course course)
        {
            courses[i] = course;
        }
        }
    }