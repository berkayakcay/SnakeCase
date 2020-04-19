using System;

namespace SnakeCase.Formatter
{
    public static class Extensions
    {
        public static string SnakeCase(FormattableString formattableString)
        {
            return formattableString.ToString(new SnakeCaseFormatProvider());
        }
    }
}