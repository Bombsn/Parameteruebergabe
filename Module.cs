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

        private string name;

        private double grade;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Grade
        {
            get { return grade; }
            set { grade = value; }
        }



    }
}
