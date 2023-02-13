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
            Console.WriteLine("1:Find max integer\n2:Find max float\n3:Find greater string\n4:Find max using generic concept\n5:Find Max using sorting\n6:Find Max using sorting with generics");
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
                case 3:
                    Console.WriteLine("Enter first string");
                    string firstString = Console.ReadLine();
                    Console.WriteLine("Enter second secomd string");
                    string secondString = Console.ReadLine();
                    Console.WriteLine("Enter third third string");
                    string thirdString = Console.ReadLine();

                    FindMaximum.FindMaximumValue(firstString, secondString, thirdString);
                    break;
                case 4:
                    Console.WriteLine("Enter first integer number");
                    int first1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter first integer number");
                    int second1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter first integer number");
                    int third1 = Convert.ToInt32(Console.ReadLine());
                    GenericConceptFindMax<int> intObj = new GenericConceptFindMax<int> (first1,second1, third1);
                    intObj.TestMax();

                    Console.WriteLine("Enter first float number");
                    float firstFloat1 = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Enter second float number");
                    float secondFloat1 = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Enter third float number");
                    float thirdFloat1 = Convert.ToInt64(Console.ReadLine());
                    GenericConceptFindMax<float> floatObj = new GenericConceptFindMax<float>(firstFloat1, secondFloat1, thirdFloat1);
                    floatObj.TestMax();

                    Console.WriteLine("Enter first string");
                    string firstString1 = Console.ReadLine();
                    Console.WriteLine("Enter second secomd string");
                    string secondString1 = Console.ReadLine();
                    Console.WriteLine("Enter third third string");
                    string thirdString1 = Console.ReadLine();
                    GenericConceptFindMax<string> stringObj = new GenericConceptFindMax<string>(firstString1, secondString1, thirdString1);
                    stringObj.TestMax();
                    break;
                case 5:
                    FindMaxUsingSort.FindMaxInteger();
                    FindMaxUsingSort.FindMaxfloat();
                    FindMaxUsingSort.FindMaxString();
                    break;
                case 6:
                    Console.WriteLine("\nEnter any five integer number");
                    int intInput1 = Convert.ToInt32(Console.ReadLine());
                    int intInput2 = Convert.ToInt32(Console.ReadLine());
                    int intInput3 = Convert.ToInt32(Console.ReadLine());
                    int intInput4 = Convert.ToInt32(Console.ReadLine());
                    int intInput5 = Convert.ToInt32(Console.ReadLine());
                    GenericsFindMaxBySort<int> intInput = new GenericsFindMaxBySort<int>(intInput1, intInput2, intInput3, intInput4, intInput5);
                    intInput.TestMax();

                    Console.WriteLine("\nEnter any five float number");
                    float floarInput1 = Convert.ToInt64(Console.ReadLine());
                    float floatInput2 = Convert.ToInt64(Console.ReadLine());
                    float floatInput3 = Convert.ToInt64(Console.ReadLine());
                    float floatInput4 = Convert.ToInt64(Console.ReadLine());
                    float floatInput5 = Convert.ToInt64(Console.ReadLine());
                    GenericsFindMaxBySort<float> floatInput = new GenericsFindMaxBySort<float>(floarInput1, floatInput2, floatInput3, floatInput4, floatInput5);
                    floatInput.TestMax();

                    Console.WriteLine("\nEnter any five string");
                    string strInput1 = Console.ReadLine();
                    string strInput2 = Console.ReadLine();
                    string strInput3 = Console.ReadLine();
                    string strInput4 = Console.ReadLine();
                    string strInput5 = Console.ReadLine();
                    GenericsFindMaxBySort<string> strInput = new GenericsFindMaxBySort<string>(strInput1, strInput2, strInput3, strInput4, strInput5);
                    strInput.TestMax();
                    break;
            }
            Console.ReadLine();
        }
    }
}
