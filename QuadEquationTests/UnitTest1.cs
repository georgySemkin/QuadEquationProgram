using System;
using NUnit.Framework;
using QuadEquationProgram;

namespace QuadEquationTests
{
    public class Tests
    {

        //Тесты для уравнения вида ax^2 + bx = 0 
        [Test]
        public void QuadEquationTest_c0()
        {
            //Arrange
            float a = 2;
            float b = -30;
            float c = 0;
            float expectedX1 = 0;
            float expectedX2 = 15;

            //Actual
            float actualX1 = QuadEquation.Solve(a, b, c).Item1;
            float actualX2 = QuadEquation.Solve(a, b, c).Item2;

            //Assert
            Assert.AreEqual(expectedX1, actualX1);
            Assert.AreEqual(expectedX2, actualX2);
        }

        //Тесты для уравнения вида ax^2 + c = 0 
        [Test]
        public void QuadEquationTest_b0()
        {
            //Arrange
            float a = 4;
            float b = 0;
            float c = -100;
            float expectedX1 = 5;
            float expectedX2 = -5;

            //Actual
            float actualX1 = QuadEquation.Solve(a, b, c).Item1;
            float actualX2 = QuadEquation.Solve(a, b, c).Item2;

            //Assert
            Assert.AreEqual(expectedX1, actualX1);
            Assert.AreEqual(expectedX2, actualX2);
        }

        // Тесты для стандартного уравнения ax^2 + bx + c = 0
        [Test]
        public void QuadEquationTest()
        {
            //Arrange
            float a = 1;
            float b = -5;
            float c = 4;
            float expectedX1 = 1;
            float expectedX2 = 4;

            //Actual
            float actualX1 = QuadEquation.Solve(a, b, c).Item1;
            float actualX2 = QuadEquation.Solve(a, b, c).Item2;

            //Assert
            Assert.AreEqual(expectedX1, actualX1);
            Assert.AreEqual(expectedX2, actualX2);
        }
    }
}