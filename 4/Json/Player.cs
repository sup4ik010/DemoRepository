using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Json
{
    /// <summary>
    /// Содержит информация о игроке.
    /// </summary>
    internal class Player
    {
        #region Fields

        private double health;
        private double stamina;

        #endregion

        #region Properties

        /// <summary>
        /// Здоровье.
        /// </summary>
        public double Health
        {
            get => health;
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Здоровье должно быть в от 0 до 100.", nameof(Health));
                }

                health = value;
            }
        }

        /// <summary>
        /// Выносливость.
        /// </summary>
        public double Stamina
        {
            get => stamina;
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Выносливость должна быть в от 0 до 100.", nameof(Health));
                }

                stamina = value;
            }
        }

        #endregion

        #region Constants

        const int DefaultHealth = 1;
        const int DefaultStamina = 1;

        #endregion

        #region Constructors

        public Player(double health, double stamina)
        {
            Health = health;
            Stamina = stamina;
        }

        public Player() : this(DefaultHealth, DefaultStamina) { }

        #endregion

        #region Methods

        public override string ToString()
        {
            return "Health: " + Health + "\nStamina: " + Stamina;
        }

        #endregion
    }
}
