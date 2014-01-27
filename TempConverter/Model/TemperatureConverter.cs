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
            
            return (int)(degreesC * 1.8 + 32);
        }

        public static int FahrenheitToCelcius(this int degreesF)
        {
            return (int)((degreesF - 32) * (5/9));
        }
    }
}