using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFeatures.MyExtensions
{
    public static class StringExtensions
    {
        public static double ToDouble(this string text)
        {
            if (!double.TryParse(text, out double result))
            {
                result = 0;
            }
            return result;
        }

        public static double ToDouble(this string text, double defaultValue)
        {
            if (!double.TryParse(text, out double result))
            {
                result = defaultValue;
            }
            return result;
        }
    }
}
