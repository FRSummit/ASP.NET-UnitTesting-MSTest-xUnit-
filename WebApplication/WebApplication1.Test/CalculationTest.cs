using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace WebApplication1.Test
{
    public class CalculationTest
    {
        [Fact]
        public void TestMethod1()
        {
            // Arrange
            int expected = 10;
            int numerator = 20;
            int denominator = 4;

            // Act
            int actual = WebApplication1.ClassLibrary.Calculation.addition(5, 5);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
