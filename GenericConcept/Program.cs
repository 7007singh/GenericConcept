using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first integer number");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter first integer number");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter first integer number");
            int third = Convert.ToInt32(Console.ReadLine());

            FindMaximum.FindMaximumValue(first,second,third);
            Console.ReadLine();
        }
    }
}
