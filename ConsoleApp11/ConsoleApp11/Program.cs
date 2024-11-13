using System;
using System.Collections.Generic;

namespace ConsoleApp11
{
    class Program
    {
        // Define a list of integers
        static IList<int> intList = new List<int>();

        // Define a list of strings
        static IList<string> strList = new List<string>();

        static void Main(string[] args)
        {
            // Add integers to the integer list
            intList.Add(10);
            intList.Add(20);
            intList.Add(30);
            intList.Add(40);
            intList.Add(50);

            // Add strings to the string list
            strList.Add("one");
            strList.Add("two");
            strList.Add("three");
            strList.Add("four");

            // Print the counts and contents of both lists
            Print(intList);
            Print(strList);
        }

        // Generic Print method to display the count and contents of a list
        static void Print<T>(IList<T> list)
        {
            Console.WriteLine("Count: {0}", list.Count);
            foreach (T value in list)
            {
                Console.WriteLine(value);
            }
        }
    }
}