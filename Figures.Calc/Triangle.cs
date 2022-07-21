using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Calc
{
    public class Triangle : IFigure
    {
        private readonly double sideA;
        private readonly double sideB;
        private readonly double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if(sideA < 0d)
            {
                throw new ArgumentException("Неверно указана первая сторона треугольника");
            }
            if (sideB < 0d)
            {
                throw new ArgumentException("Неверно указана вторая сторона треугольника");
            }
            if (sideC < 0d)
            {
                throw new ArgumentException("Неверно указана третья сторона треугольника");
            }

            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;

        }

        public double GetSquare()
        {
            double perimeter = GetPerimeter();

            return Math.Sqrt(perimeter * (perimeter - sideA) * (perimeter - sideB) * (perimeter - sideC));
        }

        private double GetPerimeter()
        {
            return (sideA + sideB + sideC) / 2d;
        }

        private bool IsTriangleRightAngled()
        {
            if(Math.Pow(sideA,2d) + Math.Pow(sideB,2d) == Math.Pow(sideC,2d))
            {
                return true;
            }
            else if(Math.Pow(sideA, 2d) + Math.Pow(sideC, 2d) == Math.Pow(sideB, 2d))
            {
                return true;
            }
            else if(Math.Pow(sideC, 2d) + Math.Pow(sideB, 2d) == Math.Pow(sideA, 2d))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
