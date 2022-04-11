using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoDynamicArray();
        }

        private static void DemoDynamicArray()
        {
            var stringList = new List<string>() { "one", "two", "three" };
            var intList = new List<int>() { 1, 2, 3 };
            var array1 = new DynamicArray<int>();
            var array2 = new DynamicArray<double>(20);
            var array3 = new DynamicArray<string>(stringList);
            Console.WriteLine(array1.Length);

            array1.Add(24);
            array1.AddRange(intList);
            array1.Remove(0);
            array1.Insert(0, 5);
            var length = array1.Length;
            var capacity = array1.Capacity;
            var secondElement = array1[1];

            Console.ReadLine();
        }

        private static void PrintArray<T>(T[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]} ");
            }
        }
    }
}
