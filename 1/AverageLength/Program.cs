using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageLength
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoAverageLength();
        }

        private static void DemoAverageLength()
        {
            var wordCounter = new AverageFinder();
            var text = GetValueFromUser("Введите текст: ");
            var words = wordCounter.SplitWords(text);
            var average = wordCounter.FindAverage(words);
            Console.WriteLine($"Средняя длина слова: {average}");

            Console.ReadLine();
        }

        private static string GetValueFromUser(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}