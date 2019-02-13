using System;
using HoliDayDate.Entity;
using HoliDayDate.Enums;
using HoliDayDate.Locale;
using HoliDayDate.Locale.CommomMethod;

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
            switch (date.Month)
            {
                case 1:
                    if (date.Day == 1)
                        dateReturn = date.ReturnNewDateType(true, "Ano Novo");
                    break;
                case 12:
                    if (date.Day == 25)
                        dateReturn = date.ReturnNewDateType(true, "Natal");
                    break;
            }
            return dateReturn;
        }
    }
}