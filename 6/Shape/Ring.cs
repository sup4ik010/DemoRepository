using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Ring : Round
    {
        #region Fields

        private double innerRadius;

        #endregion

        #region Properties

        /// <summary>
        /// Внутренний радиус.
        /// </summary>
        public double InnerRadius
        {
            get { return innerRadius; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Внутренний радиус должен быть больше нуля.");
                }
                else
                {
                    if (value >= Radius)
                    {
                        throw new ArgumentException("Внутренний радиус должен быть меньше внешнего.");
                    }
                }

                innerRadius = value;
            }
        }

        /// <summary>
        /// Площадь кольца.
        /// </summary>
        public override double Area
        {
            get
            {
                if (InnerRadius == 0)
                {
                    throw new ArgumentException("Не задан внутренний радиус кольца.");
                }

                return Math.PI * ( Radius * Radius - InnerRadius * InnerRadius);
            }
        }

        #endregion

        #region Constructors

        public Ring(double x, double y, double outerRadius, double innerRadius)
        {
            X = x;
            Y = y;
            Radius = outerRadius;
            InnerRadius = innerRadius;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Переопределенный метод ToString, который возвращает описание объекта.
        /// </summary>
        /// <returns>Описание объекта.</returns>
        public override string ToString()
        {
            return "X: " + X + " Y: " + Y +
                "\nOuter radius: " + Radius +
                "\nInner radius: " + InnerRadius +
                "\nArea: " + Area;
        }

        #endregion

    }
}
