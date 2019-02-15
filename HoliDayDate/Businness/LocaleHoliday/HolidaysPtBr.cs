using System;
using System.Collections.Generic;
using HoliDayDate.Entity;
using HoliDayDate.Locale.CommomMethod;
using HoliDayDate.Locale.Dictionary;

namespace HoliDayDate.Locale
{
    public static class HolidaysPtBr
    {
        private static DateTimeHoliday dateReturn = new DateTimeHoliday(new DateTime(), false, "");
        private const int _numberOfSunday = 2;
        public static DateTimeHoliday VerifyHolidaysPtBr(this DateTime date)
        {
            Holiday holiday = new Holiday(null);
            bool result = DictionaryHolidayPtBR.Holidays.TryGetValue(date.Month, out Dictionary<int, Holiday> holidays)? 
            holidays.TryGetValue(date.Day, out holiday) : false;
            if (!result)
            {
                date.CalculateMobileHolidays();
                switch (date.Month)
                {
                    case 2:
                        if (date.IsCarnaval())
                            dateReturn = date.ReturnNewDateType(true, "Carnaval");
                        break;
                    case 3:
                        if (date.IsCarnaval())
                            dateReturn = date.ReturnNewDateType(true, "Carnaval");
                        else if (date.IsSextaSanta())
                            dateReturn = date.ReturnNewDateType(true, "Sexta-Feira Santa");
                        else if (date.Day >= 22 && date.IsEasterDate())
                            dateReturn = date.ReturnNewDateType(true, "Páscoa");
                        break;
                    case 4:
                        if (date.IsSextaSanta())
                            dateReturn = date.ReturnNewDateType(true, "Sexta-Feira Santa");
                        else if (date.IsEasterDate())
                            dateReturn = date.ReturnNewDateType(true, "Páscoa");
                        break;
                    case 5:
                        if (date.IsAFatherOrMotherDay(_numberOfSunday, DayOfWeek.Sunday))
                            dateReturn = date.ReturnNewDateType(true, "Dia das Mães");
                        else if (date.IsCorpusCristi())
                            dateReturn = date.ReturnNewDateType(true, "Corpus Cristi");
                        break;
                    case 6:
                        if (date.IsCorpusCristi())
                            dateReturn = date.ReturnNewDateType(true, "Corpus Cristi");
                        break;
                    case 8:
                        if (date.IsAFatherOrMotherDay(_numberOfSunday, DayOfWeek.Sunday))
                            dateReturn = date.ReturnNewDateType(true, "Dia dos Pais");
                        break;
                }
            }
            else
            {
                dateReturn = date.ReturnNewDateType(holiday.isHoliday, holiday.nameHoliday);
            }
            return dateReturn;
        }

        private static bool IsCarnaval(this DateTime date) => CommomMethod.CommomMethod.EasterDate().AddDays(-47).Date.Equals(date.Date);
        private static bool IsQuartaCinza(this DateTime date) => CommomMethod.CommomMethod.EasterDate().AddDays(-46).Date.Equals(date.Date);
        private static bool IsSextaSanta(this DateTime date) => CommomMethod.CommomMethod.EasterDate().AddDays(-2).Date.Equals(date.Date);
        private static bool IsCorpusCristi(this DateTime date) => CommomMethod.CommomMethod.EasterDate().AddDays(60).Date.Equals(date.Date);
    }
}
