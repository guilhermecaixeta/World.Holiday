using System;
using HoliDayDate.Entity;
using HoliDayDate.Enums;
using HoliDayDate.Locale.PtBr;

namespace HoliDayDate.CalcHoliday
{
    public static class CalcHoliday
    {
        private static DateTimeHoliday dateReturn;
        public static DateTimeHoliday TodayIsAHoliday(this DateTime today, LocaleHoliday localeHoliday)
        {
            today.WorldHoliday();
            if (!dateReturn.IsHoliday)
            {
                switch (localeHoliday)
                {
                    case LocaleHoliday.ptBr:
                        dateReturn = today.VerifyHolidaysPtBr();
                        break;
                    case LocaleHoliday.enUS:
                        return dateReturn;
                }
            }
            return dateReturn;
        }

        private static DateTimeHoliday WorldHoliday(this DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                    if (date.Day == 1)
                        dateReturn = date.ReturnNewDateType(true, "Ano Novo");
                    break;
                case 12:
                    if (date.Day == 25)
                        dateReturn = date.ReturnNewDateType(true, "Ano Novo");
                    break;
                default:
                    dateReturn = date.ReturnNewDateType(false, "");
                    break;
            }
            return dateReturn;
        }
    }
}