using System;
using System.Collections.Generic;
using HoliDayDate.Entity;
using HoliDayDate.Enums;
using HoliDayDate.Locale;
using HoliDayDate.Locale.CommomMethod;
using HoliDayDate.Locale.Dictionary;

namespace HoliDayDate.CalcHoliday
{
    /// <summary>
    /// Extension class to verify holiday
    /// </summary>
    public static class CalcHoliday
    {
        private static DateTimeHoliday dateReturn;
        /// <summary>
        /// Verify holidays around world
        /// </summary>
        /// <param name="today">Day to verify</param>
        /// <param name="localeHoliday">Locale of holiday</param>
        /// <returns></returns>
        public static DateTimeHoliday TodayIsAHoliday(this DateTime today, LocaleHoliday localeHoliday)
        {
            dateReturn = new DateTimeHoliday(today, false, "");
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

        /// <summary>
        /// Verify if the informed day is new year or christmas. 
        /// This method is executed always if a verify is executed. 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="localeHoliday"></param>
        /// <returns></returns>
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