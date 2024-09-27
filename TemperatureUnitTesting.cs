using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Homework_02
{
    public class TemperatureUnitTesting
    {
        [Fact]
        public void testCelsiusToFahrenheit()
        {
            // Arrange
            double celsius = 0.0;

            // Act
            double result = TemperatureConverter.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.Equal(32.0, result);
        }

        [Fact]
        public void testFahrenheitToCelsius()
        {
            // Arrange
            double fahrenheit = 32.0;

            // Act
            double result = TemperatureConverter.FahrenheitToCelsius(fahrenheit);

            // Assert
            Assert.Equal(0.0, result);
        }
    }
}
