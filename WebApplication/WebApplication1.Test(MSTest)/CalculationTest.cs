using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WebApplication1.Test_MSTest_
{
    [TestClass]
    public class CalculationTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            int expected = 10;
            int numerator = 20;
            int denominator = 4;

            // Act
            int actual = WebApplication1.ClassLibrary.Calculation.addition(5, 5);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
