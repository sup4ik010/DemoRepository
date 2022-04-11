using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class ListManager
    {
        #region Methods

        /// <summary>
        /// Возвращает заполенную коллекцию с типом Person.
        /// </summary>
        /// <returns>Коллекция с типом Person.</returns>
        public static List<Person> LoadData()
        {
            return new List<Person>
            {
                new Person("Ivan", "Romanov", 5, Convert.ToDateTime("15.6.1989")),
                new Person("Michael", "Shishkin", 3, Convert.ToDateTime("28.12.1999")),
                new Person("Maxim", "Nechaev", 7, Convert.ToDateTime("5.3.1991")),
                new Person("Arina", "Nikitina", 4, Convert.ToDateTime("17.9.1995")),
                new Person("Avrora", "Shirokova", 5, Convert.ToDateTime("3.8.1994")),
                new Person("Ivan", "Stolov", 15, Convert.ToDateTime("3.8.1985")),
                new Person("Maxim", "Filatov", 12, Convert.ToDateTime("3.8.1984"))
            };
        }

        #endregion
    }
}
