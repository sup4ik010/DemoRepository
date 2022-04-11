using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoDelegatesAndEvents();
        }

        private static void DemoDelegatesAndEvents()
        {
            var testArray = new int[] { 4, 5, 1, 13, 7 };
            Console.WriteLine("Unsorted array:");
            PrintArray(testArray); 

            var delegatesAndEvents = new DelegatesAndEvents();
            delegatesAndEvents.OnSortingEnded += PrintMessageSortingEnded;
            delegatesAndEvents.OnElementsSwapped += PrintSwappedElements;
            delegatesAndEvents.OnSortingStarted += () => { Console.WriteLine("Sorting started."); };
            delegatesAndEvents.SortAsc(testArray, CompareElements);

            Console.WriteLine("Sorted array:");
            PrintArray(testArray);

            delegatesAndEvents.OnSortingEnded -= PrintMessageSortingEnded;
            delegatesAndEvents.OnElementsSwapped -= PrintSwappedElements;
            delegatesAndEvents.OnSortingStarted -= () => { Console.WriteLine("Sorting started."); };

            Console.ReadKey();
        }

        private static void PrintArray(int[] testArray)
        {
            for (var i = 0; i < testArray.Length; i++)
            {
                Console.Write($"{testArray[i]} ");
            }

            Console.WriteLine("");
        }

        private static bool CompareElements(int firstElement, int secondElement)
        {
            if (firstElement < secondElement)
            {
                return true;
            }

            return false;
        }

        private static void PrintMessageSortingEnded(object sender, EventArgs e)
        {
            Console.WriteLine($"Sorting finished.");
        }

        private static void PrintSwappedElements(int firstElement, int secondElement)
        {
            Console.WriteLine($"Swap since {firstElement} > {secondElement}");
        }
    }
}
