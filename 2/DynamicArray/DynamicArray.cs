using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    /// <summary>
    /// Представляет динамический массив и методы для работы с ним.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DynamicArray<T>
    {
        #region Свойства

        /// <summary>
        /// Содержимое динамического массива.
        /// </summary>
        public T[] Array { get; private set; }

        /// <summary>
        /// Длина масиива.
        /// </summary>
        public int Length 
        { 
            get => Array.Length;
        }

        /// <summary>
        /// Занимаемая массивом емкость.
        /// </summary>
        public int Capacity { get; private set; }

        #endregion

        #region Константы

        private const int DefaultSize = 8;

        #endregion

        #region Индексатор

        public T this[int index]
        {
            get
            {
                IsIndexOutOfRange(index);
                IsNull(index);

                return Array[index];
            }
            set
            {
                IsIndexOutOfRange(index);
                IsNull(index);

                Array[index] = value;
            }
        }

        #endregion

        #region Конструкторы

        public DynamicArray() : this(DefaultSize) {}

        public DynamicArray(int size)
        {
            IsNull(size);

            if (size < 0)
            {
                throw new ArgumentOutOfRangeException("Размер не может быть меньше нуля.", nameof(size));
            }

            Array = new T[size];
        }

        public DynamicArray(IEnumerable<T> list)
        {
            IsNull(list);

            Array = list.ToArray();
            Capacity = list.Count();
        }

        #endregion 

        #region Методы

        /// <summary>
        /// Добавляет элемент в конец массива.
        /// </summary>
        /// <param name="value">Значение.</param>
        public void Add(T value)
        {
            IsNull(value); 

            this.AddRange(new List<T>() { value });
        }

        /// <summary>
        /// Добавляет в конец массива содержимое коллекции.
        /// </summary>
        /// <param name="list">Коллекция для добавления.</param>
        public void AddRange(IEnumerable<T> list)
        {
            IsNull(list);

            if(Capacity + list.Count() >= Length)
            {
                var array = Array;
                Array = new T[Array.Length * 2];
                Array = array;
            }

            for(var i = Capacity; i < list.Count(); i++)
            {
                Array[i] = list.ElementAt(i - Capacity);
            }

            Capacity += list.Count();
        }

        /// <summary>
        /// Удаляет элемент из массива.
        /// </summary>
        /// <param name="index">Индекс элемента, который необходимо удалить.</param>
        public bool Remove(int index)
        {
            IsNull(index);
            IsIndexOutOfRange(index);

            for (var i = index; i < Array.Length - 1; i++)
            {
                Array[i] = Array[i + 1];
            }
            
            Array[Array.Length - 1] = default(T);

            return true;
        }

        /// <summary>
        /// Добавляет элемент в произвольное место массива.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void Insert(int index, T value)
        {
            IsIndexOutOfRange(index);
            IsNull(index);
            IsNull(value);

            if (Capacity + 1 == Array.Length)
            {
                var array = Array;
                Array = new T[Array.Length * 2];
                Array = array;
            }

            Capacity++;

            for (var i = Array.Length - 2; i >= index; i--)
            {
                Array[i] = Array[i + 1];
            }

            Array[index] = value;
        }

        /// <summary>
        /// Проверка индекса на исключение ArgumentOutOfRangeException.
        /// </summary>
        /// <param name="index"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private void IsIndexOutOfRange(int index)
        {
            if (index >= this.Length || index < 0)
            {
                throw new ArgumentOutOfRangeException("Индекс выходит за пределы массива.", nameof(index));
            }
        }

        /// <summary>
        /// Проверка значения на null.
        /// </summary>
        /// <param name="variable"></param>
        /// <exception cref="ArgumentNullException"></exception>
        private void IsNull<T>(T variable)
        {
            if (variable == null)
            {
                throw new ArgumentNullException("Размер не может быть null", nameof(variable));
            }
        }

        #endregion
    }
}
