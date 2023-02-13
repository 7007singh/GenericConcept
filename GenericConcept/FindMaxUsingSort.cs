using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericConcept
{
    internal class FindMaxUsingSort
    {
        public static void FindMaxInteger()
        {
            Console.WriteLine("Enter any five integer number ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());
            int num5 = Convert.ToInt32(Console.ReadLine());
            int[] array = { num1, num2, num3, num4, num5 };

            Array.Sort(array);
            Console.WriteLine("maximum number: " + array[4]);
        }
        public static void FindMaxfloat()
        {
            Console.WriteLine("Enter any five float number ");
            float float1 = Convert.ToInt64(Console.ReadLine());
            float float2 = Convert.ToInt64(Console.ReadLine());
            float float3 = Convert.ToInt64(Console.ReadLine());
            float float4 = Convert.ToInt64(Console.ReadLine());
            float float5 = Convert.ToInt64(Console.ReadLine());
            float[] array = { float1, float2, float3, float4, float5 };

            Array.Sort(array);
            Console.WriteLine("maximum number: " + array[4]);
        }
        public static void FindMaxString()
        {
            Console.WriteLine("Enter any five string");
            String str1 = Console.ReadLine();
            String str2 = Console.ReadLine();
            String str3 = Console.ReadLine();
            String str4 = Console.ReadLine();
            String str5 = Console.ReadLine();
            string[] array = { str1, str2, str3, str4, str5 };

            Array.Sort(array);
            Console.WriteLine("Greater string: " + array[4]);
        }
    }
}
