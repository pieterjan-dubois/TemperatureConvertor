﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    class TemperatureScale
    {
        public interface ITemperatureScale
        {
            string Name { get; }

       double ConvertToKelvin(double temperature);
       double ConvertFromKelvin(double temperature);
        }

        public class KelvinTemperatureScale : ITemperatureScale
        {
            public string Name => throw new NotImplementedException();

            public double ConvertFromKelvin(double temperature)
            {
                return temperature;
            }

            public double ConvertToKelvin(double temperature)
            {
                return temperature;
            }
        }

        public class CelsiusTemperatureScale : ITemperatureScale
        {
            public string Name => throw new NotImplementedException();

            public double ConvertFromKelvin(double temperature)
            {
                return temperature - 273.15;
            }

            public double ConvertToKelvin(double temperature)
            {
                return temperature + 273.15;
            }
        }

        public class FahrenheitTemperatureScale : ITemperatureScale
        {
            public string Name => throw new NotImplementedException();

            public double ConvertFromKelvin(double temperature)
            {
               return (temperature * 1.8) - 459.67;
            }

            public double ConvertToKelvin(double temperature)
            {
                return (temperature + 459.67) / 1.8;
            }
        }
    }
}
