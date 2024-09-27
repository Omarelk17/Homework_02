using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_02
{
    public class PerformTemperatureConversion
    {
        public void RunConversion()
        {
            Console.WriteLine("Choose conversion type:");
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Enter temperature in Celsius:");
                double celsius = double.Parse(Console.ReadLine());
                double fahrenheit = TemperatureConverter.CelsiusToFahrenheit(celsius);
                Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter temperature in Fahrenheit:");
                double fahrenheit = double.Parse(Console.ReadLine());
                double celsius = TemperatureConverter.FahrenheitToCelsius(fahrenheit);
                Console.WriteLine($"{fahrenheit}°F = {celsius}°C");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}
