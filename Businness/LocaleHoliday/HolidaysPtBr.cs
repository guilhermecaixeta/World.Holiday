using System;

namespace HoliDayDate.Locale.PtBr
{
    public static class HolidaysPtBr
    {
        private const int numberOfSunday = 2;

        public static bool VerifyHolidaysPtBr(this DateTime date)
        {
            bool isHoliday = false;
            switch (date.Month)
            {
                case 2 | 3 | 4:
                    if ((date.Day == 21 && date.Month == 4) || date.IsCarnaval() || date.IsSextaSanta() || date.IsPascoa())
                        isHoliday = true;
                    break;
                case 5:
                    if (date.Day == 1 || date.IsMotherDays() || date.IsCorpusCristi())
                        isHoliday = true;
                    break;
                case 6:
                    if (date.IsCorpusCristi() || date.Day.Equals(24))
                        isHoliday = true;
                    break;
                case 9:
                    if (date.Day.Equals(7))
                        isHoliday = true;
                    break;
                case 10:
                    if (date.Day.Equals(12))
                        isHoliday = true;
                    break;
                case 11:
                    if (date.Day.Equals(2) || date.Day.Equals(15) || date.Day.Equals(20))
                        isHoliday = true;
                    break;
            }
            return isHoliday;
        }

        public static bool IsMotherDays(this DateTime date)
        {
            int countSunday = 0;
            DateTime firstDayMonth = new DateTime(date.Year, date.Month, 1);
            for (int i = 0; i <= new DateTime(date.Year, date.Month, firstDayMonth.AddMonths(1).AddDays(-1).Day).Day; i++)
            {
                if (firstDayMonth.DayOfWeek == DayOfWeek.Sunday)
                    countSunday++;
                if (countSunday == numberOfSunday && firstDayMonth.Day == date.Day)
                    return true;
                else firstDayMonth.AddDays(1);
            }
            return false;
        }

        public static DateTime CalculateMobileHolidays(this DateTime date)
        {
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
            int m = 3 + ((1 + 40) / 44);
            int d = l + 28 - (31 * (m / 4));
            var pascoa = new DateTime(date.Year, m, d);
            return pascoa;
        }

        public static bool IsCarnaval(this DateTime date) => CalculateMobileHolidays(date).AddDays(-47).Date.Equals(date.Date);
        public static bool IsSextaSanta(this DateTime date) => CalculateMobileHolidays(date).AddDays(-2).Date.Equals(date.Date);
        public static bool IsCorpusCristi(this DateTime date) => CalculateMobileHolidays(date).AddDays(60).Date.Equals(date.Date);
        public static bool IsPascoa(this DateTime date) => CalculateMobileHolidays(date).Date.Equals(date.Date);
    }
}
