using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace View
{
    public class ConverterViewModel : INotifyPropertyChanged
    {
        private double temperatureInKelvin;
        public event PropertyChangedEventHandler PropertyChanged;

        public ConverterViewModel()
        {
            this.Kelvin = new TemperatureScaleViewModel(new KelvinTemperatureScale());
            this.Celsius = new TemperatureScaleViewModel(new CelsiusTemperatureScale());
            this.Fahrenheit = new TemperatureScaleViewModel(new FahrenheitTemperatureScale());
        }
        public double TemperatureInKelvin
        {
            get
            {
                return temperatureInKelvin;
            }
            set
            {
                temperatureInKelvin = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TemperatureInKelvin)));
            }
        }
        public TemperatureScaleViewModel Kelvin { get; }

        public TemperatureScaleViewModel Celsius { get; }

        public TemperatureScaleViewModel Fahrenheit { get; }
    }

    public class TemperatureScaleViewModel : INotifyPropertyChanged
    {
        private readonly ITemperatureScale temperatureScale;

        private readonly ConverterViewModel parent;


        public TemperatureScaleViewModel(ConverterViewModel parent, ITemperatureScale temperatureScale)
        {
            this.parent = parent;
            this.temperatureScale = temperatureScale;

            this.parent.PropertyChanged += TemperatureUpdated;
        }

        public string Name => temperatureScale.Name;

        public double Temperature
        {
            get
            {
                return temperatureScale.ConvertFromKelvin(parent.TemperatureInKelvin);
            }
            set
            {
                parent.TemperatureInKelvin = temperatureScale.ConvertFromKelvin(value);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void TemperatureUpdated(object sender, PropertyChangedEventArgs args)
       {
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Temperature)));
      }
}
}
