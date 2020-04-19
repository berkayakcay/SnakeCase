using System;

namespace SnakeCase.Formatter
{
    public class SnakeCaseFormatProvider : IFormatProvider
    {
        private readonly SnakeCaseFormatter _snakeCaseFormatter = new SnakeCaseFormatter();

        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
            {
                return _snakeCaseFormatter;
            }

            return null;
        }
    }
}