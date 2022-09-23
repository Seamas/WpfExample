using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp
{
    public class RangeValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (double.TryParse(value.ToString(), out var d))
            {
                if (d >= 0 && d <= 100)
                {
                    return new ValidationResult(true, null);
                }
            }
            return new ValidationResult(false, "Validation failed");
        }
    }
}
