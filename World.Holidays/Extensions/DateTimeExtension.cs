using System;
using World.Holidays.Exceptions;

namespace World.Holidays.Extensions
{
    /// <summary>
    /// DateTime extension.
    /// </summary>
    public static class DateTimeExtension
    {
        /// <summary>
        /// Determines whether [is bigger than] [the specified d2].
        /// </summary>
        /// <param name="d1">The d1.</param>
        /// <param name="d2">The d2.</param>
        /// <returns>
        ///   <c>true</c> if [is bigger than] [the specified d2]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsBiggerThan(this DateTime d1, DateTime d2)
        {
            DateIsValid(d2, d1);

            return d1.Ticks > d2.Ticks;
        }

        /// <summary>
        /// Determines whether the specified date minimum is between.
        /// </summary>
        /// <param name="dateMin">The date minimum.</param>
        /// <param name="dateMax">The date maximum.</param>
        /// <param name="dateBetween">The date between.</param>
        /// <returns>
        ///   <c>true</c> if the specified date minimum is between; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsBetween(this DateTime dateBetween, DateTime dateMin, DateTime dateMax)
        {
            DateIsValid(dateMin, dateMax, dateBetween);

            var isValid = dateMax.Ticks >= dateBetween.Ticks && dateMin.Ticks <= dateBetween.Ticks;

            return isValid;
        }

        /// <summary>
        /// Check if the dates is valid.
        /// </summary>
        /// <param name="dates">The dates.</param>
        /// <exception cref="World.Holidays.Exceptions.DateTimeMinMaxException"></exception>
        internal static void DateIsValid(params DateTime[] dates)
        {
            foreach (var date in dates)
            {
                if (date == DateTime.MinValue || date == DateTime.MaxValue)
                {
                    throw new DateTimeMinMaxException(date);
                }
            }
        }

        /// <summary>
        /// Ints the is valid.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <exception cref="World.Holidays.Exceptions.LessThanZeroException"></exception>
        internal static void IntIsValid(int value)
        {
            if (value < 0)
            {
                throw new LessThanZeroException();
            }
        }
    }
}
