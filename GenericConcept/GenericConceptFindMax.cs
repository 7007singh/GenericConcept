using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericConcept
{
    internal class GenericConceptFindMax<T> where T : IComparable
    {
        public T first, second, third;
        public GenericConceptFindMax(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
        public static void FindMaximumValue(T first, T second, T third)
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

        public void TestMax()
        {
            Console.WriteLine("Max value: ");
            FindMaximumValue(first, second, third);
        }
    }
}
