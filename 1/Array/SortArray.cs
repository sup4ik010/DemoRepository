using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /// <summary>
    /// Функции для работы с массивом.
    /// </summary>
    internal class SortArray
    {
        #region Методы

        /// <summary>
        /// Проверка на массива на null.
        /// </summary>
        /// <param name="array">Массив</param>
        /// <exception cref="ArgumentNullException"></exception>
        private static void Test(int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException("Массив не может быть null.");
            }
        }

        /// <summary>
        /// Заполнит массив случайными числами.
        /// </summary>
        /// <param name="array">Массив, который нужно заполнить.</param>
        /// <returns>Заполненный массив.</returns>
        public int[] FillArray(int[] array)
        {
            Test(array);

            var random = new Random();

            for (var i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100);
            }

            return array;
        }

        /// <summary>
        /// Вернет строку с элементами массива.
        /// </summary>
        /// <param name="array">Массив, элементы которого необходимо посмотреть.</param>
        /// <returns>Строка с элементами массива.</returns>
        public string GetArrayString(int[] array)
        {
            Test(array);
            var result = "";

            for (var i = 0; i < array.Length; i++)
            {
                result += array[i] + " ";
            }

            return result;
        }

        /// <summary>
        /// Отсортирует массив по возрастанию.
        /// </summary>
        /// <param name="array">Массив для сортировки.</param>
        /// <returns>Отсортированный массив.</returns>
        public int[] SortAsc(int[] array)
        {
            Test(array);

            for (var i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    for (var j = i + 1; j > 0; j--)
                    {
                        if (array[j] < array[j - 1])
                        {
                            var element = array[j];
                            array[j] = array[j - 1];
                            array[j - 1] = element;
                        }
                    }
                }
            }

            return array;
        }

        /// <summary>
        /// Найдет минимальный элемент массива.
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <returns>Минимальное число в массиве.</returns>
        public int FindMin(int[] array)
        {
            Test(array);
            var minimum = array[0];

            for (var i = 1; i < array.Length; i++)
            {
                if (array[i] < minimum)
                {
                    minimum = array[i];
                }
            }

            return minimum;
        }
        /// <summary>
        /// Найдет максимальный элемент массива.
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <returns>Максимальное число в массиве.</returns>
        public int FindMax(int[] array)
        {
            Test(array);
            var maximum = array[0];

            for (var i = 1; i < array.Length; i++)
            {
                if (array[i] > maximum)
                {
                    maximum = array[i];
                }
            }

            return maximum;
        }

        #endregion
    }
}