using System;

namespace World.Holidays.Extensions
{
    /// <summary>
    /// DateTime extension.
    /// </summary>
    public static class DateTimeExtension
    {
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
            DateTimeHolidayValidations.DateIsValid(dateBetween, dateMin, dateMax);

            var isValid = dateMax >= dateBetween && dateMin <= dateBetween;

            return isValid;
        }

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
            DateTimeHolidayValidations.DateIsValid(d1, d2);

            return d1 > d2;
        }
    }
}