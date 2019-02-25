using System;
using HoliDayDate.Entity;

namespace HoliDayDate.Locale.CommomMethod {
    public static class CommomMethod {
        private static DateTime EasterDay;

        public static bool IsAFatherOrMotherDay (this DateTime date, int numCountDays, DayOfWeek dayOfWeek) {
            int countSunday = 0;
            DateTime firstDayMonth = new DateTime (date.Year, date.Month, 1);
            for (int i = 0; i <= new DateTime (date.Year, date.Month, firstDayMonth.AddMonths (1).AddDays (-1).Day).Day; i++) {
                if (firstDayMonth.DayOfWeek == dayOfWeek)
                    countSunday++;
                if (countSunday == numCountDays && firstDayMonth.Day == date.Day)
                    return true;
                else firstDayMonth = firstDayMonth.AddDays (1);
            }
            return false;
        }

        public static void CalculateMobileHolidays (this DateTime date) {
            int y = date.Year;
            int c = y / 100;
            int n = y - (19 * (y / 19));
            int k = (c - 17) / 25;
            int i = c - c / 4 - ((c - k) / 3) + (19 * n) + 15;
            i = i - (30 * (i / 30));
            i = i - ((i / 28) * (1 - (i / 28)) * (29 / (i + 1)) * ((21 - n) / 11));
            int j = y + y / 4 + i + 2 - c + c / 4;
            j = j - ((7 * (j / 7)));
            int l = i - j;
            int m = 3 + ((l + 40) / 44);
            int d = l + 28 - (31 * (m / 4));
            EasterDay = new DateTime (date.Year, m, d);
        }

        public static DateTime EasterDate () => EasterDay;
        public static bool IsEasterDate (this DateTime date) => EasterDay.Date.Equals (date.Date);
        public static DateTimeHoliday ReturnNewDateType (this DateTime date, bool isHoliday, string nameHoliday) => new DateTimeHoliday (date, isHoliday, nameHoliday);
        public static bool IsCarnaval (this DateTime date) => EasterDate ().AddDays (-47).Date.Equals (date.Date);
        public static bool IsQuartaCinza (this DateTime date) => EasterDate ().AddDays (-46).Date.Equals (date.Date);
        public static bool IsSextaSanta (this DateTime date) => EasterDate ().AddDays (-2).Date.Equals (date.Date);
        public static bool IsCorpusCristi (this DateTime date) => EasterDate ().AddDays (60).Date.Equals (date.Date);
    }
}