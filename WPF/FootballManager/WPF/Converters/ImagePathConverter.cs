using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace WPF.Converters
{
    class ImagePathConverter : IValueConverter
    {
        Dictionary<string, BitmapImage> cache = new Dictionary<string, BitmapImage>();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var club = (string)value;
            if(!cache.ContainsKey(club))
            {
                var uri = new Uri(string.Format(@"..\Images\{0}.png", club), UriKind.Relative);
                cache.Add(club, new BitmapImage(uri));
            }
            
            return cache[club];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
