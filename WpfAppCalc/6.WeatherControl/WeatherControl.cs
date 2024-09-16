using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WeatherControl
{
    class WeatherControl : DependencyObject
    {
        public static readonly DependencyProperty TemperatureProperty =
            DependencyProperty.Register(
                nameof(Temperature),
                typeof(float),
                typeof(WeatherControl),
                new FrameworkPropertyMetadata(
                    0f,
                    FrameworkPropertyMetadataOptions.AffectsRender,
                    null,
                    new CoerceValueCallback(CoerceTemperature),
                    true));

        public float Temperature
        {
            get => (float)GetValue(TemperatureProperty);
            set => SetValue(TemperatureProperty, value);
        }

        private static object CoerceTemperature(DependencyObject d, object baseValue)
        {
            float temp = (float)baseValue;
            if (temp > 50)
            {
                return 50;
            }
            else if (temp < -50)
            {
                return -50;
            }
            else
            {
                return temp;
            }
        }

        public string WindDirection
        {
            get; set;
        }

        public int WindSpeed
        {
            get; set;
        }

        public Perciptiation Perciptiation
        {
            get; set;
        }
    }
}
