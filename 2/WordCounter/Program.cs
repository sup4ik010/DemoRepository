using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoWordCounter();
        }

        private static void DemoWordCounter()
        {
            var wordCounter = new WordCounter();
            var text = GetValueFromUser("Enter text: ");
            var words = wordCounter.SplitWords(text);

            var wordFrequency = wordCounter.CountWords(words);

            foreach(KeyValuePair<string, int> kvp in wordFrequency)
            {
                Console.WriteLine($"Word = {kvp.Key}, frequency = {kvp.Value}");
            }

            Console.ReadLine();
        }

        private static string GetValueFromUser(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}