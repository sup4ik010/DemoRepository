using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// Содержит методы для работы с ИМТ.
    /// </summary>
    internal class BmiCalculator
    {
        #region Методы

        /// <summary>
        /// Вычисляет ИМТ по входным массе и росту.
        /// </summary>
        /// <param name="weight">Вес</param>
        /// <param name="height">Рост</param>
        /// <returns>Индекс массы тела.</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public double Calculate(double weight, double height)
        {
            if (weight < 10 || weight > 500)
            {
                throw new ArgumentOutOfRangeException("Вес должен быть в промежутке от 10 до 500.", nameof(weight));
            }

            if (height < 50 || weight > 250)
            {
                throw new ArgumentOutOfRangeException("Рост должен быть в промежутке от 50 до 250.", nameof(height));
            }

            return weight / Math.Pow(height, 2);
        }

        /// <summary>
        /// Вернет описание ИМТ по вычисленному значению ИМТ.
        /// </summary>
        /// <param name="bmi">Вычисленный ИМТ.</param>
        /// <returns>Описание для человека.</returns>
        public string GetDescription(double bmi)
        {
            var result = "";

            if (bmi > 0 && bmi < 16)
            {
                result = "Выраженный дефицит массы тела.";
            }
            else if (bmi < 18.5)
            {
                result = "Недостаточная (дефицит) масса тела.";
            }
            else if (bmi < 25)
            {
                result = "Норма.";
            }
            else if (bmi < 30)
            {
                result = "Избыточная масса тела (предожирение).";
            }
            else if (bmi < 35)
            {
                result = "Ожирение первой степени.";
            }
            else if (bmi < 40)
            {
                result = "Ожирение второй степени.";
            }
            else
            {
                result = "Ожирение третьей степени (морбидное).";
            }

            return $"Ваш ИМТ: {bmi},\nОписание: {result}";
        }

        #endregion
    }
}