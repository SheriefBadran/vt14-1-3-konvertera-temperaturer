using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TempConverter.Model
{
    static class TemperatureConverter
    {
        // Static Methods.S
        public static int CelsiusToFahrenheit(this int degreesC)
        {
            
            return degreesC * 9/5 + 32;
        }

        public static int FahrenheitToCelcius(this int degreesF)
        {
            return (degreesF - 32) * 5 / 9;
        }
    }
}