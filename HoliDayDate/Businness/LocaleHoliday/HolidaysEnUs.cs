using System;
using System.Collections.Generic;
using HoliDayDate.Entity;
using HoliDayDate.Locale.CommomMethod;
using HoliDayDate.Locale.Dictionary;

namespace HoliDayDate.Locale
{
    public static class HolidaysEnUS
    {
        private static DateTimeHoliday dateReturn;
        public static DateTimeHoliday VerifyHolidaysEnUs(this DateTime date)
        {
            dateReturn = new DateTimeHoliday(date, false, "");
            Holiday holiday = new Holiday(null, false);
            bool result = DictionaryHolidayEnUs.Holidays.TryGetValue(date.Month, out Dictionary<int, Holiday> holidays) ?
            holidays.TryGetValue(date.Day, out holiday) : false;
            if (date.Month == 9 && !holiday.isHoliday)
            {
                date.CalculateMobileHolidays();
                if (date.IsAFatherOrMotherDay(1, DayOfWeek.Monday))
                    dateReturn = date.ReturnNewDateType(true, "Labor Day");
            }
            else if(holiday != null && holiday.isHoliday)
            {
                dateReturn = date.ReturnNewDateType(holiday.isHoliday, holiday.nameHoliday);
            }
            return dateReturn;
        }

    }
}
