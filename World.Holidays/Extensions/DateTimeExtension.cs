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
            var ticksDateBetween = dateBetween.Ticks;
            var ticksDateMax = dateMax.Ticks;
            var ticksDateMin = dateMin.Ticks;

            DateTimeHolidayValidations.DateIsValid(ticksDateBetween, ticksDateMax, ticksDateMin);

            var isValid = ticksDateMax >= ticksDateBetween && ticksDateMin <= ticksDateBetween;

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
            var d1Ticks = d1.Ticks;
            var d2Ticks = d2.Ticks;

            DateTimeHolidayValidations.DateIsValid(d2Ticks, d1Ticks);

            return d1Ticks > d2Ticks;
        }
    }
}