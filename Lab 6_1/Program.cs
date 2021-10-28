using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string startString = Console.ReadLine();
            string[] stringArray = startString.Split();
            string max = " ";
            foreach (string l in stringArray)
            {
                if (l.Length > stringArray.Length)
                    max = l;
            }
            Console.WriteLine("Самое длинное слово: {0}",max);
            Console.ReadKey();
        }
    }
}
