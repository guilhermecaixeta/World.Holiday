using System;
using System.Linq;
using World.Holidays.Entities;
using World.Holidays.Entities.HolidaysList;
using static World.Holidays.Enum.Culture;

namespace World.Holidays.Extensions
{
    /// <summary>
    /// Validate is the date informed is holiday
    /// </summary>
    public static class Holidays
    {
        /// <summary>
        /// Determines whether the specified date is holidays for the informed culture.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <param name="culture">The culture.</param>
        /// <returns></returns>
        public static DateTimeHoliday IsHoliday(this DateTime date, ECulture culture)
        {
            var worldHolidays = new WorldHolidays(culture, date.Year).Holidays().ToList();

            var holidays = worldHolidays.
                Where(x => (culture & x.Culture) == culture && x.Date.Date.CompareTo(date.Date) == 0);

            var mobileHoliday = FindMobileHolidays.GetMobileHoliday(date, culture);

            holidays = holidays.Concat(mobileHoliday);

            var dateHoliday = new DateTimeHoliday(date, holidays);

            return dateHoliday;
        }
    }
}