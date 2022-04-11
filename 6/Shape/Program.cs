using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoShape();
        }

        private static void DemoShape()
        {
            var x = ToDouble(GetValueFromUser("Введите координату x: "));
            var y = ToDouble(GetValueFromUser("Введите координату y: "));
            var outerRadius = ToDouble(GetValueFromUser("Введите внешний радиус: "));
            var innerRadius = ToDouble(GetValueFromUser("Введите внутренний радиус: "));
            var ring = new Ring(x, y, outerRadius, innerRadius);
            Console.WriteLine(ring.ToString());

            Console.ReadKey();
        }

        private static string GetValueFromUser(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        private static double ToDouble(string value)
        {
            return double.Parse(value);
        }
    }
}
