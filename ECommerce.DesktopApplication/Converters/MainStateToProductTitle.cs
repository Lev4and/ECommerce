using ECommerce.Model.Marketplace.Ozon.Types;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;

namespace ECommerce.DesktopApplication.Converters
{
    [ValueConversion(typeof(List<MainState>), typeof(string))]
    public class MainStateToProductTitle : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((List<MainState>)value)?.Find(state => state.Id == "name")?.Atom?.TextAtom?.Text ?? 
                "Название продукта неизвестно";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
