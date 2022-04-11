using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hihierarchy
{
    public abstract class Person
    {
        #region Properties

        /// <summary>
        /// Имя.
        /// </summary>
        public string FirstName { get; set; }
        
        /// <summary>
        /// Фамилия.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Дата рождения.
        /// </summary>
        public DateTime Birthday { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Возвращает приветственную фразу.
        /// </summary>
        /// <returns>Приветственная фраза.</returns>
        public virtual string GetWelcomePhrase()
        {
            return "Привет";
        }

        #endregion
    }

    public interface IMovable
    {
        /// <summary>
        /// Максимальная скорость.
        /// </summary>
        double MaxSpeed { get; set; }
    }
}
