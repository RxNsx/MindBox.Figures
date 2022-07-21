using Microsoft.VisualStudio.TestTools.UnitTesting;
using Figures.Calc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Calc.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void GetSquareTest()
        {
            //Arrange
            Triangle triangle = new Triangle(4d, 5d, 6d);

            double perimeter = (4d + 5d + 6d)/2;
            double predictedResult = Math.Sqrt(perimeter * (perimeter - 4d) * (perimeter - 5d) * (perimeter - 6d));


            //Act
            var result = triangle.GetSquare();

            //Assert
            Assert.AreEqual(predictedResult, result);
        }
    }
}