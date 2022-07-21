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
    public class CircleTests
    {

        [TestMethod()]
        public void GetSquareTest()
        {
            //Arrange
            Circle circle = new Circle(24d);
            double predictedResult = Math.PI * Math.Pow(24d, 2d);

            //Act
            double result = circle.GetSquare();

            //Assert
            Assert.AreEqual(predictedResult, result);
        }
    }
}