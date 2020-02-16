using System;
using System.Collections.Generic;
using System.Linq;
using World.Holidays.Entities;
using World.Holidays.Entities.HolidaysList;
using static World.Holidays.Enum.Culture;

namespace World.Holidays.Extensions
{
    /// <summary>
    ///
    /// </summary>
    public static class Holidays
    {
        /// <summary>
        /// Determines whether the specified culture is holiday.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <param name="culture">The culture.</param>
        /// <returns></returns>
        public static DateTimeHoliday IsHoliday(this DateTime date, ECulture culture)
        {
            var worldHolidays = new WorldHolidays(culture).Holidays();

            var worldHolidayList = worldHolidays.
                FirstOrDefault(x => x.Item1 == date.Month).
                Item2.
                Where(x => (culture & x.Culture) == culture).ToList();

            var holiday = new List<Holiday>();

            holiday.AddRange(worldHolidayList.Where(x => x.Day == date.Day));

            var mobileHoliday = FindMobileHolidays.GetMobileHoliday(date, culture);

            if (mobileHoliday != null)
            {
                holiday.Add(mobileHoliday);
            }

            var isHoliday = holiday.Any();

            var isNational = holiday.Any(x => x.IsNational);

            var holidayNames = holiday.
                Select(x => x.HolidayName).
                Aggregate(new List<string>(), (list, current) =>
                {
                    list.AddRange(current);
                    return list;
                });

            var dateHoliday = new DateTimeHoliday(date, isHoliday, isNational, holidayNames);

            return dateHoliday;
        }
    }
}