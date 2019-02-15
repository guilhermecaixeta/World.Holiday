using System;
using System.Collections.Generic;
using HoliDayDate.Entity;
using HoliDayDate.Locale.CommomMethod;
using HoliDayDate.Locale.Dictionary;

namespace HoliDayDate.Locale
{
    public static class HolidaysEnUS
    {
        private static DateTimeHoliday dateReturn = new DateTimeHoliday(new DateTime(), false, "");
        public static DateTimeHoliday VerifyHolidaysEnUs(this DateTime date)
        {
            Holiday holiday = new Holiday(null);
            bool result = DictionaryHolidayEnUs.Holidays.TryGetValue(date.Month, out Dictionary<int, Holiday> holidays) ?
            holidays.TryGetValue(date.Day, out holiday) : false;
            if (date.Month == 9)
            {
                date.CalculateMobileHolidays();
                if (date.IsAFatherOrMotherDay(1, DayOfWeek.Monday))
                    dateReturn = date.ReturnNewDateType(true, "Labor Day");
            }
            return dateReturn;
        }

    }
}
