using System;
using World.Holidays.Exceptions;

namespace World.Holidays.Extensions
{
    internal static class DateTimeHolidayValidations
    {
        /// <summary>
        /// Dates the is valid.
        /// </summary>
        /// <param name="datesTicks">The dates ticks.</param>
        /// <exception cref="DateTimeMinMaxException"></exception>
        /// <exception cref="DateTime"></exception>
        public static void DateIsValid(params long[] datesTicks)
        {
            var ticksDateMax = DateTime.MaxValue.Date.Ticks;
            var ticksDateMin = DateTime.MinValue.Date.Ticks;

            foreach (var ticks in datesTicks)
            {
                if (ticksDateMin == ticks || ticksDateMax == ticks)
                {
                    throw new DateTimeMinMaxException(new DateTime(ticks));
                }
            }
        }

        /// <summary>
        /// Ints the is valid.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <exception cref="World.Holidays.Exceptions.LessThanZeroException"></exception>
        public static void IntIsValid(int value)
        {
            if (value < 0)
            {
                throw new LessThanZeroException();
            }
        }
    }
}