using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TempConverter.Model
{
    static class TemperatureConverter
    {
        // Static Methods.
        public static int CelsiusToFahrenheit(this int degreesC)
        {
            return (int)(degreesC * 1.8 + 32);
        }

        public static int FahrenheitToCelcius(this int degreesF)
        {
            // d for double division.
            return (int)Math.Round((degreesF - 32) * 5/9d);
        }
    }
}