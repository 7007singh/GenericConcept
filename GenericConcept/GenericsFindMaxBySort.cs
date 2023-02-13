using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericConcept
{
    internal class GenericsFindMaxBySort<T> where T : IComparable
    {
        public T input1, input2, input3, input4, input5;
        public GenericsFindMaxBySort(T input1, T input2, T input3, T input4, T input5)
        {
            this.input1 = input1;
            this.input2 = input2;
            this.input3 = input3;
            this.input4 = input4;
            this.input5 = input5;
        }
        public static void PrintMax(T input1, T input2, T input3, T input4, T input5)
        {
            T[] array = { input1, input2, input3, input4, input5 };

            Array.Sort(array);
            Console.WriteLine("max input: " + array[4]);
        }
        public void TestMax()
        {
            Console.WriteLine("Maximum Value: ");
            PrintMax(input1, input2, input3, input4, input5);
        }
    }
}
