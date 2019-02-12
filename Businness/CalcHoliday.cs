using System;
using HoliDayDate.Enums;
using HoliDayDate.Locale.PtBr;

namespace HoliDayDate.CalcHoliday
{
    public static class CalcHoliday
    {
        public static bool TodayIsAHoliday(this DateTime today, LocaleHoliday localeHoliday)
        {
            bool isHoliday = today.WorldHoliday();
            if (!isHoliday)
            {
                switch (localeHoliday)
                {
                    case LocaleHoliday.ptBr:
                        isHoliday = today.VerifyHolidaysPtBr();
                        break;
                    case LocaleHoliday.enUS:
                        return false;
                        break;
                }
            }
            return isHoliday;
        }

        private static bool WorldHoliday(this DateTime today)
        {
            switch (today.Month)
            {
                case 1:
                    if (today.Day == 1)
                        return true;
                    else return false;
                case 12:
                    if (today.Day == 25)
                        return true;
                    else return false;
                default: return false;
            }
        }
    }
}