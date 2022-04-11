using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DynamicArray;

namespace ObjectComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoComparison();
        }

        private static void DemoComparison()
        {
            var firstObject = new DynamicArray<string>();
            var otherObject = new DynamicArray<float>(5);
            var standartArray = new int[10];

            Console.WriteLine(firstObject.Equals(firstObject));
            Console.WriteLine(firstObject.Equals(otherObject));
            Console.WriteLine(firstObject.Equals(standartArray));


            Console.ReadLine();
        }
    }
}
