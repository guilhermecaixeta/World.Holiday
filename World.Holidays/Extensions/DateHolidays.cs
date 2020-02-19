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
        /// Determines whether the specified date is holidays for the informed culture.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <param name="culture">The culture.</param>
        /// <returns></returns>
        public static DateTimeHoliday IsHoliday(this DateTime date, ECulture culture)
        {
            DateTimeExtension.DateIsValid(date);

            var worldHolidays = new WorldHolidays(culture, date.Year).Holidays().ToList();

            var holidays = worldHolidays.
                Where(x => (culture & x.Culture) == culture && x.Date.Ticks == date.Date.Ticks);

            var mobileHoliday = FindMobileHolidays.GetMobileHoliday(date, culture);

            holidays = holidays.Concat(mobileHoliday);

            var dateHoliday = new DateTimeHoliday(date, holidays);

            return dateHoliday;
        }

        /// <summary>
        /// Gets holidays from the in interval.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="culture">The culture.</param>
        /// <returns></returns>
        public static IEnumerable<Holiday> GetInInterval(DateTime min, DateTime max, ECulture culture)
        {
            DateTimeExtension.DateIsValid(min, max);

            if (min.IsBiggerThan(max))
            {
                throw new MinDateIsBiggerThanMaxDate(min, max);
            }

            var holidays = new List<Holiday>();

            var days = (max - min).Days;

            for (var day = 0; day <= days; day++)
            {
                holidays.AddRange(min.IsHoliday(culture).Holidays);

                min = min.AddDays(1);
            }
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
            DateTimeExtension.IntIsValid(days);

            return GetInInterval(date, date.AddDays(days), culture);
        }

        /// <summary>
        /// Gets holidays from currently date.
        /// </summary>
        /// <param name="days">The days.</param>
        /// <param name="culture">The culture.</param>
        /// <returns></returns>
        public static IEnumerable<Holiday> GetFromCurrentlyDate(int days, ECulture culture)
        {
            var date = DateTime.Now;

            return GetInInterval(date, days, culture);
        }

    }
}