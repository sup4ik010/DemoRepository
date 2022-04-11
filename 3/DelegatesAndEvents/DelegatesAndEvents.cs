using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    internal class DelegatesAndEvents
    {
        #region Delegates

        public delegate bool CompareDelegate(int first, int second);

        #endregion

        #region Events

        /// <summary>
        /// Событие окончания сортировки.
        /// </summary>
        public event EventHandler OnSortingEnded;

        /// <summary>
        /// Событие начала сортировки.
        /// </summary>
        public event Action OnSortingStarted;

        /// <summary>
        /// Событие перестановки элементов массива местами.
        /// </summary>
        public event Action<int, int> OnElementsSwapped;

        #endregion

        #region Methods

        /// <summary>
        /// Сортирует масссив в порядке возрастания.
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <param name="compareDelegate">Метод сравнения двух элементов.</param>
        /// <returns></returns>
        public int[] SortAsc(int[] array, CompareDelegate compareDelegate)
        {
            if(array == null)
            {
                throw new ArgumentNullException("Массив не может быть null.", nameof(array));
            }

            if (compareDelegate == null)
            {
                throw new ArgumentNullException("Делегат не может быть null.", nameof(array));
            }

            OnSortingStarted?.Invoke();

            for (var i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    for (var j = i + 1; j > 0; j--)
                    {
                        if (compareDelegate(array[j], array[j - 1]))
                        {
                            var element = array[j];
                            array[j] = array[j - 1];
                            array[j - 1] = element;
                            OnElementsSwapped?.Invoke(array[j], array[j - 1]);
                        }
                    }
                }
            }

            OnSortingEnded?.Invoke(this, EventArgs.Empty);

            return array;
        }

        #endregion
    }
}
