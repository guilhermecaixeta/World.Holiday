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
            var date = DateTime.Now;

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
            DateTimeHolidayValidations.DateIsValid(dateMin.Ticks, dateMax.Ticks);

            if (dateMin.IsBiggerThan(dateMax))
            {
                throw new MinDateIsBiggerThanMaxDate(dateMin, dateMax);
            }

            var holidays = new List<Holiday>();

            var days = (dateMax - dateMin).Days;

            for (var day = 0; day <= days; day++)
            {
                holidays.AddRange(dateMin.IsHoliday(culture).Holidays);

                dateMin = dateMin.AddDays(1);
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
            DateTimeHolidayValidations.IntIsValid(days);

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
            var ticks = date.Date.Ticks;

            DateTimeHolidayValidations.DateIsValid(ticks);

            var worldHolidays = new WorldHolidays(culture, date.Year).Holidays().ToList();

            var holidays = worldHolidays.
                Where(x => (culture & x.Culture) == culture && x.Ticks == ticks);

            var mobileHoliday = FindMobileHolidays.GetMobileHoliday(ticks, culture);

            holidays = holidays.Concat(mobileHoliday);

            var dateHoliday = new DateTimeHoliday(date, holidays);

            return dateHoliday;
        }
    }
}