using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Round
    {
        #region Fields

        private double radius;

        #endregion

        #region Properties

        /// <summary>
        /// Координата x.
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Координата y.
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// Радиус круга.
        /// </summary>
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Внутренний радиус должен быть больше нуля.");
                }

                radius = value;
            }
        }

        /// <summary>
        /// Длина круга.
        /// </summary>
        public double Circumference { get => 2 * Math.PI * Radius; }

        /// <summary>
        /// Площадь круга.
        /// </summary>
        public virtual double Area
        { 
            get 
            {
                if (Radius == 0)
                {
                    throw new ArgumentException("Не задан радиус круга.");
                }

                return Math.PI * Radius * Radius; 
            } 
        }

        #endregion

        #region Methods

        /// <summary>
        /// Передвигает объект на заданные расстония.
        /// </summary>
        /// <param name="dx">Расстояние перемещения по оси x.</param>
        /// <param name="dy">Расстояние перемещения по оси y.</param>
        public void Move(double dx, double dy)
        {
            X += dx;
            Y += dy;
        }

        #endregion
    }
}
