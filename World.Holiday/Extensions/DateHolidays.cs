using System;
using System.Collections.Generic;
using System.Linq;
using World.Holidays.Entities;
using World.Holidays.Entities.HolidaysList;
using World.Holidays.Exceptions;
using static World.Holidays.Enum.Culture;

namespace World.Holidays.Extensions
{
    /// <summary>
    /// Validate is the date informed is holiday
    /// </summary>
    public static class DateHolidays
    {
        /// <summary>
        /// Gets holidays from currently date.
        /// </summary>
        /// <param name="days">The days.</param>
        /// <param name="culture">The culture.</param>
        /// <returns></returns>
        public static IEnumerable<Holiday> GetFromCurrentlyDate(int days, ECulture culture)
        {
            DateTimeHolidayValidations.IntIsValid(days);

            var date = DateTime.UtcNow;

            return GetInInterval(date, days, culture);
        }

        /// <summary>
        /// Gets the in interval.
        /// </summary>
        /// <param name="dateMin">The date minimum.</param>
        /// <param name="dateMax">The date maximum.</param>
        /// <param name="culture">The culture.</param>
        /// <returns></returns>
        /// <exception cref="MinDateIsBiggerThanMaxDate"></exception>
        public static IEnumerable<Holiday> GetInInterval(DateTime dateMin, DateTime dateMax, ECulture culture)
        {
            var holidays = InInterval(dateMin, dateMax, culture);

            return holidays;
        }

        /// <summary>
        /// Gets holidays from the in interval.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <param name="days">The days.</param>
        /// <param name="culture">The culture.</param>
        /// <returns></returns>
        public static IEnumerable<Holiday> GetInInterval(DateTime date, int days, ECulture culture)
        {
            return GetInInterval(date, date.AddDays(days), culture);
        }

        /// <summary>
        /// Determines whether the specified date is holidays for the informed culture.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <param name="culture">The culture.</param>
        /// <returns></returns>
        public static DateTimeHoliday IsHoliday(this DateTime date, ECulture culture)
        {
            DateTimeHolidayValidations.DateIsValid(date);

            var worldHolidays = new WorldHolidays(culture, date).Holidays();

            var holidays = worldHolidays.
                Where(x => x != null && (culture & x.Culture) == culture && x.Date.CompareTo(date.Date) == 0);

            var dateHoliday = new DateTimeHoliday(date, holidays);

            return dateHoliday;
        }

        /// <summary>
        /// Ins the interval.
        /// </summary>
        /// <param name="dateMin">The date minimum.</param>
        /// <param name="dateMax">The date maximum.</param>
        /// <param name="culture">The culture.</param>
        /// <returns></returns>
        /// <exception cref="MinDateIsBiggerThanMaxDate"></exception>
        private static IEnumerable<Holiday> InInterval(DateTime dateMin, DateTime dateMax, ECulture culture)
        {
            DateTimeHolidayValidations.DateIsValid(dateMin, dateMax);

            if (dateMin.IsBiggerThan(dateMax))
            {
                throw new MinDateIsBiggerThanMaxDate(dateMin, dateMax);
            }

            var worldHolidays = new WorldHolidays(culture, dateMin).Holidays();

            var holidays = worldHolidays.
                Where(x => x != null && (culture & x.Culture) == culture && x.Date.IsBetween(dateMin.Date, dateMax.Date));

            return holidays;
        }
    }
}