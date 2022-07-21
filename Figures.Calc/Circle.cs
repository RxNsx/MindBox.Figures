using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Calc
{
    public class Circle : IFigure
    {
        private readonly double radius;

        public Circle(double radius)
        {
            if(radius < 0d)
            {
                throw new ArgumentException("Радиус меньше 0");
            }
            this.radius = radius;
        }

        public double GetSquare()
        {
            return Math.PI * Math.Pow(radius, 2d);
        }
    }
}
