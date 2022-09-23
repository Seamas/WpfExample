using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp
{
    public class StringToHumanTypeConverter: TypeConverter
    {

        public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
        {
            if (value is string s)
            {
                Human h = new Human();
                h.Name = s;
                return h;
            }
            return base.ConvertFrom(context, culture, value);
        }
    }
}
