using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoBmiCalc();
        }

        private static void DemoBmiCalc()
        {
            var weight = ToDouble(GetValueFromUser("Введите вес: "));
            var height = ToDouble(GetValueFromUser("Введите рост: "));

            var bmiCalc = new BmiCalculator();
            var bmi = bmiCalc.Calculate(weight, height);
            var description = bmiCalc.GetDescription(bmi);

            Console.WriteLine(description);
        }

        private static double ToDouble(string value)
        {
            return double.Parse(value);
        }

        private static string GetValueFromUser(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}