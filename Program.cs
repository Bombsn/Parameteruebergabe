using System;

namespace Parameteruebergabe
{
    class Program
    {
        static void Main(string[] args)
        {
            Module module = new Module("test", 6);

            Console.WriteLine(module.Grade.ToString() + " " + module.Name);
        }
    }
}
