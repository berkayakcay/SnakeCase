using System;
using System.Globalization;

namespace SnakeCase.Formatter
{
    public class SnakeCaseFormatter : ICustomFormatter
    {
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            if (arg == null)
                return "NULL";
            if (arg is string)
                return "'" + ((string) arg).Replace("'", "''") + "'";
            if (arg is DateTime)
                return "'" + ((DateTime) arg).ToString("MM/dd/yyyy") + "'";
            if (arg is IFormattable)
                return ((IFormattable) arg).ToString(format, CultureInfo.InvariantCulture);
            return arg.ToString();
        }
    }
}