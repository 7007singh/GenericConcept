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
            Console.WriteLine("Please choose program to execute");
            Console.WriteLine("1:Find max integer\n2:Find max float");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter first integer number");
                    int first = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter first integer number");
                    int second = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter first integer number");
                    int third = Convert.ToInt32(Console.ReadLine());

                    FindMaximum.FindMaximumValue(first, second, third);
                    break;
                case 2:
                    Console.WriteLine("Enter first float number");
                    float firstFloat = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Enter second float number");
                    float secondFloat = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Enter third float number");
                    float thirdFloat = Convert.ToInt64(Console.ReadLine());

                    FindMaximum.FindMaximumValue(firstFloat, secondFloat, thirdFloat);
                    break;
            }
            Console.ReadLine();
        }
    }
}
