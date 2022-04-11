using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoSort();
        }

        private static void DemoSort()
        {
            var sortArray = new SortArray();
            int[] array = null;

            array = sortArray.FillArray(array);
            var unsortedArray = sortArray.GetArrayString(array);
            array = sortArray.SortAsc(array);
            var sortedArray = sortArray.GetArrayString(array);
            var min = sortArray.FindMin(array);
            var max = sortArray.FindMax(array);

            Console.WriteLine("Unsorted array:\n" + unsortedArray +
                              "\nSorted array:\n" + sortedArray +
                              "\nMin: " + min +
                              "\nMax: " + max);

            Console.ReadLine();
        }
    }
}