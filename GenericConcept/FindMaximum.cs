using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericConcept
{
    internal class FindMaximum
    {
        public static void FindMaximumValue(int first, int second, int third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine($"Maximum value is {first}");
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine($"Maximum value is {second}");
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                Console.WriteLine($"Maximum value is {third}");
            }
            else
            {
                Console.WriteLine("Two or three numbers are same");
            }
        }

        public static void FindMaximumValue(float first, float second, float third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine($"Maximum value is {first}");
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine($"Maximum value is {second}");
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                Console.WriteLine($"Maximum value is {third}");
            }
            else
            {
                Console.WriteLine("Two or three numbers are same");
            }
        }
    }
}
