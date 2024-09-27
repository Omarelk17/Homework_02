using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_02
{
    class TemperatureApp
    {
        static void Main(string[] args)
        {
            PerformTemperatureConversion performConversion = new PerformTemperatureConversion();
            performConversion.RunConversion();

            // Prevent console from closing immediately
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}

