using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Assessment_Lab
{
    class UProgram
    {
        const int ARRAY_SIZE = 10;
        int i = 0;
        Degree[] degrees = new Degree[ARRAY_SIZE];
        public string programName { get; set; }

        public UProgram(string name)
        {
            this.programName = name;
        }

        public void AddDegree(Degree degree)
        {
            degrees[i] = degree;
            i++;
        }

        public void WhatDegree()
        {
            for (int j = 0; j < degrees.Length; j++)
            {
                Console.WriteLine(degrees[j].ToString());
            }
        }
    }
}
