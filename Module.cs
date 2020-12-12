using System;
using System.Collections.Generic;
using System.Text;

namespace Parameteruebergabe
{
    public class Module
    {
        public Module(string name, double grade)
        {
            Name = name;
            Grade = grade;
        }

        public string Name { get; set; }
        public double Grade { get; set; }



    }
}
