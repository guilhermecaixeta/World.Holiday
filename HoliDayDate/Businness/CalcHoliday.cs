using System;
using System.Collections.Generic;
using HoliDayDate.Entity;
using HoliDayDate.Enums;
using HoliDayDate.Locale;
using HoliDayDate.Locale.CommomMethod;
using HoliDayDate.Locale.Dictionary;

namespace HoliDayDate.CalcHoliday
{
    public static class CalcHoliday
    {
        private static DateTimeHoliday dateReturn = new DateTimeHoliday(new DateTime(), false, "");
        public static DateTimeHoliday TodayIsAHoliday(this DateTime today, LocaleHoliday localeHoliday)
        {
            today.WorldHoliday(localeHoliday);
            if (!dateReturn.IsHoliday)
            {
                switch (localeHoliday)
                {
                    case LocaleHoliday.ptBr:
                        dateReturn = today.VerifyHolidaysPtBr();
                        break;
                    case LocaleHoliday.enUS:
                        dateReturn = today.VerifyHolidaysEnUs();
                        break;
                }
            }
            return dateReturn;
        }

        private static DateTimeHoliday WorldHoliday(this DateTime date, LocaleHoliday localeHoliday)
        {
            Dictionary<LocaleHoliday, string> holiday = new Dictionary<LocaleHoliday, string>();
            bool result = DictionaryHolidayWorld.Holidays.TryGetValue(date.Month, out Dictionary<int, Dictionary<LocaleHoliday, string>> holidays) ?
            holidays.TryGetValue(date.Day, out holiday) : false;

            if (result && holiday.TryGetValue(localeHoliday, out string holidayName))
            {
                dateReturn = date.ReturnNewDateType(true, holidayName);
            }

            return dateReturn;
        }
    }
}