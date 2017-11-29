using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    abstract class Employee
    {
        private string employeeName;
        private double employeeBaseSalary;
        private int employeeId;
        private static int employeeCount = 1;/*variable to count employees*/
        //properties
        public string Name
        {
            get
            {
                return employeeName;
            }
            set
            {
                employeeName = value;
            }
        }
        public double BaseSalary
        {
            get
            {
                return employeeBaseSalary;
            }
            set
            {
                employeeBaseSalary = value;
            }
        }
        public int ID
        {
            get
            {
                return employeeId;
            }
            set
            {
                employeeId = value;
            }
        }
        //constructor to create and count employees
        public Employee(string name, double baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.ID = employeeCount++;
        }
        //getters
        public double getBaseSalary()
        {
            return this.BaseSalary;
        } /*get base salary*/
        public string getName()
        {
            return employeeName;
        }/*get name of employee*/
        public int getEmployeeId()
        {
            return employeeId;
        }/*get employee ID*/

        public string toString()
        {
            return this.ID + " " + this.Name;
        }
        public abstract string employeeStatus();
    }
}
