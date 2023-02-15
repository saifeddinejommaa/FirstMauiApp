using System;
using System.Collections.Generic;
using System.Globalization;

namespace FirstMauiApp.converters
{
    public class IconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string icon = (string)value;
            switch (icon)
            {
                case "01d":  {
                        return "sunny1";
                };
                case "02d":{
                        return "sunny2";
                };
                case "01n":{
                        return "night1";
                };
                case "02n":{
                        return "night2";
                };
                case "03d":{
                        return "couverage1";
                };
                case "03n":{
                        return "couverage2";
                };

                case "09n":{
                        return "rain2";
                };
                case "09d":{
                        return "rain1";
                };
                case "10n":{
                        return "night3";
                };
                case "10d":{
                        return "sunny3";
                };
                case "11d":{
                        return "flash1";
                };
                case "13d":{
                        return "snow1";
                };
                case "13n":{
                        return "snow2";
                };
                case "50d":{
                        return "wind1";
                };
                case "50n":{
                        return "wind2";
                };
            }

            return null;
            
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException("ConvertBack is not supported");
        }
    }
}
