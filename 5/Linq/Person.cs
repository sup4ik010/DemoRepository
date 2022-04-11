using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Person
    {
        #region Properties

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearsExpirience { get; set; }
        public DateTime Birthday { get; set; }

        #endregion

        #region Constructors

        public Person(string firstName, string lastName, int yearExpirience, DateTime birthday)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.YearsExpirience = yearExpirience; 
            this.Birthday = birthday;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Получает описание объекта класса Person в виде строки.
        /// </summary>
        /// <returns>Описание объекта.</returns>
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}, ({this.Birthday.ToShortDateString()}): Expirience {this.YearsExpirience}";
        }

        #endregion
    }
}
