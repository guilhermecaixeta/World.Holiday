using System;
using HoliDayDate.Entity;

namespace HoliDayDate.Locale.PtBr
{
    public static class HolidaysPtBr
    {
        private static DateTimeHoliday dateReturn;
        private const int _numberOfSunday = 2;
        private static DateTime pascoa;
        public static DateTimeHoliday VerifyHolidaysPtBr(this DateTime date)
        {
            dateReturn = new DateTimeHoliday(date, false, "");
            date.CalculateMobileHolidays();

            switch (date.Month)
            {
                case 2:
                    if (date.IsCarnaval())
                    {
                        dateReturn = date.ReturnNewDateType(true, "Carnaval");
                    }
                    break;
                case 3:
                    if (date.IsCarnaval())
                        dateReturn = date.ReturnNewDateType(true, "Carnaval");
                    else if (date.IsSextaSanta())
                        dateReturn = date.ReturnNewDateType(true, "Sexta-Feira Santa");
                    else if (date.Day >= 22 && date.IsPascoa())
                        dateReturn = date.ReturnNewDateType(true, "Páscoa");
                    break;
                case 4:
                    if (date.Day == 21)
                        dateReturn = date.ReturnNewDateType(true, "Tiradentes");
                    else if (date.IsSextaSanta())
                        dateReturn = date.ReturnNewDateType(true, "Sexta-Feira Santa");
                    else if (date.IsPascoa())
                        dateReturn = date.ReturnNewDateType(true, "Páscoa");

                    break;
                case 5:
                    if (date.Day == 1)
                        dateReturn = date.ReturnNewDateType(true, "Dia do Trabalhador");
                    else if (date.IsAMobileHoliday(_numberOfSunday, DayOfWeek.Sunday))
                        dateReturn = date.ReturnNewDateType(true, "Dia das Mães");
                    else if (date.IsCorpusCristi())
                        dateReturn = date.ReturnNewDateType(true, "Corpus Cristi");
                    break;
                case 6:
                    if (date.IsCorpusCristi() || date.Day.Equals(24))
                        dateReturn = date.ReturnNewDateType(true, "Páscoa");
                    break;
                case 8:
                    if (date.IsAMobileHoliday(_numberOfSunday, DayOfWeek.Sunday))
                        dateReturn = date.ReturnNewDateType(true, "Páscoa");
                    break;
                case 9:
                    if (date.Day.Equals(7))
                        dateReturn = date.ReturnNewDateType(true, "Páscoa");
                    break;
                case 10:
                    if (date.Day.Equals(12))
                        dateReturn = date.ReturnNewDateType(true, "Páscoa");
                    break;
                case 11:
                    if (date.Day.Equals(2) || date.Day.Equals(15) || date.Day.Equals(20))
                        dateReturn = date.ReturnNewDateType(true, "Páscoa");
                    break;
            }
            return dateReturn;
        }

        public static bool IsAMobileHoliday(this DateTime date, int numCountDays, DayOfWeek dayOfWeek)
        {
            int countSunday = 0;
            DateTime firstDayMonth = new DateTime(date.Year, date.Month, 1);
            for (int i = 0; i <= new DateTime(date.Year, date.Month, firstDayMonth.AddMonths(1).AddDays(-1).Day).Day; i++)
            {
                if (firstDayMonth.DayOfWeek == dayOfWeek)
                    countSunday++;
                if (countSunday == numCountDays && firstDayMonth.Day == date.Day)
                    return true;
                else firstDayMonth = firstDayMonth.AddDays(1);
            }
            return false;
        }

        public static void CalculateMobileHolidays(this DateTime date)
        {
            int y = date.Year;
            int c = y / 100;
            int n = y - (19 * (y / 19));
            int k = (c - 17) / 25;
            int i = c - c / 4 - ((c - k) / 3) + (19 * n) + 15;
            i = i - (30 * (i / 30));
            i = i - ((i / 28) * (1 - (i / 28)) * (29 / (i + 1)) * ((21 - n) / 11));  //((i / 28) * (1 - (i / 28)) * (29 / (i + 1)) * ((21 - n) / 11));
            int j = y + y / 4 + i + 2 - c + c / 4;
            j = j - ((7 * (j / 7)));
            int l = i - j;
            int m = 3 + ((l + 40) / 44);
            int d = l + 28 - (31 * (m / 4));
            pascoa = new DateTime(date.Year, m, d);
        }

        public static DateTime EasterDate() => pascoa;
        public static bool IsCarnaval(this DateTime date) => EasterDate().AddDays(-47).Date.Equals(date.Date);
        public static bool IsQuartaCinza(this DateTime date) => EasterDate().AddDays(-46).Date.Equals(date.Date);
        public static bool IsSextaSanta(this DateTime date) => EasterDate().AddDays(-2).Date.Equals(date.Date);
        public static bool IsCorpusCristi(this DateTime date) => EasterDate().AddDays(60).Date.Equals(date.Date);
        public static bool IsPascoa(this DateTime date) => pascoa.Date.Equals(date.Date);

        public static DateTimeHoliday ReturnNewDateType(this DateTime date, bool isHoliday, string nameHoliday) => new DateTimeHoliday(date, isHoliday, nameHoliday);
    }
}
