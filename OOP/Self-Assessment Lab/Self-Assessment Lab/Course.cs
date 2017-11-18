using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Self_Assessment_Lab
{
    class Course
    {
        const int ARRAY_SIZE = 3;
        private int i = 0; /**/
        private int j = 0;
        Student[] students = new Student[ARRAY_SIZE];
        Teacher[] teachers = new Teacher[ARRAY_SIZE];

        public string courseName { get; set; }

        public Course(string name)
        {
            this.courseName = name;
        }
        
        // Add a new student to students array
        public void AddStud(Student student)
        {
            students[i] = student;
            i++;
        }
        //count new students
        public int StudCount()
        {
            return i;
        }
        //Add a new teacher to teachers array
        public void AddTeacher(Teacher teacher)
        {
            teachers[j] = teacher;
            j++;
        }
        //counting teachers in teachers array
        public int TeachCount()
        {
            return j;
        }
    }
}
