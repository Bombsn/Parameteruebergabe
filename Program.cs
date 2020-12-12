using System;
using System.Collections.Generic;
using System.Linq;

namespace Parameteruebergabe
{
    class Program
    {
        static void Main(string[] args)
        {
            var moduleList = new List<Module>();
            var bestModuleList = new List<Module>();
            var worstModuleList = new List<Module>();
            double average = 0;

            do
            {
                var module = new Module(string.Empty, 0);
                FillModule(module);
                moduleList.Add(module);

                Console.WriteLine("\nWollen Sie ein weiteres Fach eingeben? (j/n)");
            } while (Console.ReadKey(true).Key != ConsoleKey.N);

            FindBestWorstAndAverage(ref moduleList, ref bestModuleList, ref worstModuleList, ref average);
            Ausgabe(bestModuleList, worstModuleList, average);

        }


        static void FillModule(Module module)
        {
            Console.WriteLine("Geben Sie den Name des Fachs ein:");
            module.Name = Console.ReadLine();

            Console.WriteLine("Geben Sie die Note ein:");
            module.Grade = double.Parse(Console.ReadLine());
        }

        static void FindBestWorstAndAverage(ref List<Module> allModules, ref List<Module> bestModules, ref List<Module> worstModules, ref double average)
        {
            average = allModules.Select(s => s.Grade).Average();
            
            var max = allModules.Select(s => s.Grade).Max();
            bestModules = allModules.Where(s => s.Grade == max).ToList();

            var worst = allModules.Select(s => s.Grade).Min();
            worstModules = allModules.Where(s => s.Grade == worst).ToList();
        }

        static void Ausgabe(List<Module> bestModules, List<Module> worstModules, double average)
        {
            Console.WriteLine("\n\n" + new string('-', 30));

            if (bestModules.Count > 1) 
                Console.WriteLine("Die besten Fächer sind:\n");
            else
                Console.WriteLine("Das beste Fach ist:\n");

            foreach (var mod in bestModules)
            {
                Console.WriteLine(mod.Name + ", " + mod.Grade);
            }

            if (worstModules.Count > 1)
                Console.WriteLine("\n\nDie schlechtesten Fächer sind:\n");
            else
                Console.WriteLine("\n\nDas schlechteste Fach ist:\n");

            foreach (var mod in worstModules)
            {
                Console.WriteLine(mod.Name + ", " + mod.Grade);
            }

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Der Durchschnitt liegt bei: " + average);
            Console.WriteLine(new string('-', 30));
        }
    }
}
