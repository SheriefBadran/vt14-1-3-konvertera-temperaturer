using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TempConverter.Model
{

    public class Temperature
    {
        // Private fields
        private int _maxTemp;
        private int _tempRate;
        private bool _celciusToFahrenheit;

        // Properties

        // auto implemented
        public int StartTemp { get; private set; }

        public int TempRate 
        {
            get
            {
                return _tempRate;
            }
            private set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentException("Temperaturssteget måste ligga mellan 1 och 100.");
                }

                _tempRate = value;
            }
        }

        public int MaxTemp 
        {
            get
            {
                return _maxTemp;
            } 
            private set
            {
                if (value <= StartTemp)
                {
                    throw new ArgumentException("Sluttemperaturen måste vara större än starttemperaturen.");
                }

                _maxTemp = value;
            }
        }

        // Constructor
        public Temperature(int startTemp, int maxTemp, int tempRate, bool convDirection)
        {
            StartTemp = startTemp;
            MaxTemp = maxTemp;
            TempRate = tempRate;
            _celciusToFahrenheit = convDirection; 
        }

        // Method
        public Dictionary<int, int> CreateResultTableTemperatures()
        {
            Dictionary<int, int> tableContent  = new Dictionary<int, int>();
            int convertedTemp;

            for (int temp = StartTemp; temp <= MaxTemp; temp += TempRate)
            {
                if (_celciusToFahrenheit)
                {
                    convertedTemp = temp.CelsiusToFahrenheit();
                }
                else
                {
                    convertedTemp = temp.FahrenheitToCelcius();
                }
                tableContent.Add(temp, convertedTemp);
            }
            return tableContent;
        }
    }
}