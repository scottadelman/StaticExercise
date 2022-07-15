using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius()
        {
            var fahrenheit = double.Parse(Console.ReadLine());
            var toCelsius = (fahrenheit - 32) / 1.8;
            return toCelsius;
        }
        public static double CelsiusToFahrenheit()
        {
            var celsius = double.Parse(Console.ReadLine());
            var toFahrenheit = (celsius * 9) / 5 + 32;
            return toFahrenheit;
        }
    }
}
