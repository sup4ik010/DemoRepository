using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoLinq();
        }

        private static void DemoLinq()
        {
            // Использование фильтрации c помощью лямбды.
            var people = ListManager.LoadData();
            PrintList(people, "Первоначальная коллекция:");

            var selectedPeople = people.Where(x => x.YearsExpirience > 5).ToList();
            PrintList(selectedPeople, "Люди с опытом работы большим или равным 5-ти:");

            // Использование Linq с анонимными типами через from.
            var anonymousRectangles = new[]
            {
                new { TopEdge = 5, RightEdge = 10, BackgroundColor = "Red"},
                new { TopEdge = 6, RightEdge = 3, BackgroundColor = "Green"},
                new { TopEdge = 22, RightEdge = 15, BackgroundColor = "Blue"}
            }.ToList();

            PrintList(anonymousRectangles, "Первоначальная коллекция с анонимными типами:");

            var selectedRectangles = from rectangle in anonymousRectangles
                                     where rectangle.TopEdge > 5
                                     select rectangle;

            Console.WriteLine("Прямоугольники с верхней стороной большей 5:");

            foreach (var rectangle in selectedRectangles)
            {
                Console.WriteLine($"TopEdge = {rectangle.TopEdge}, RightEdge = {rectangle.RightEdge}, BackgroundColor = {rectangle.BackgroundColor}");
            }

            Console.WriteLine();

            // Использование группировки с помощью лямбды.
            var groups = people.GroupBy(p => p.FirstName);

            foreach (var group in groups)
            {
                Console.WriteLine(group.Key);

                foreach (var person in group)
                {
                    Console.WriteLine(person.ToString());
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }

        private static void PrintList<T>(List<T> dataList, string message)
        {
            Console.WriteLine(message);

            foreach (var record in dataList)
            {
                Console.WriteLine(record.ToString());
            }

            Console.WriteLine();
        }
    }
}
