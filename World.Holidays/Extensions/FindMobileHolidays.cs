using System;
using System.Collections.Generic;
using System.Linq;
using World.Holidays.Entities;
using World.Holidays.Enum;
using static World.Holidays.Enum.Culture;

namespace World.Holidays.Extensions
{
    internal static class FindMobileHolidays
    {
        private static DateTime EasterDay;

        /// <summary>
        /// The holidays
        /// </summary>
        private static Holiday[] Holidays(ECulture culture) => new Holiday[]{
            new Holiday(-3, null, false, EHolidayName.HolyThursday.GetDescription(culture), ECulture.esES),
            new Holiday(-2, null, true, EHolidayName.GoodFriday.GetDescription(culture), AllCultures),
            new Holiday(-46, null, true, EHolidayName.AshWednesday.GetDescription(culture), ECulture.ptBR),
            new Holiday(-47, null, culture == ECulture.ptPT? false: true, EHolidayName.MardiGrass.GetDescription(culture), PtCulture),
            new Holiday(-48, null, true, EHolidayName.MardiGrass.GetDescription(culture), ECulture.ptBR),
            new Holiday(60, null, false, EHolidayName.CorpusChristi.GetDescription(culture), PtCulture),
            new Holiday(40, null, false, EHolidayName.AscensionThursday.GetDescription(culture), ECulture.ptPT),
            new Holiday(0, null, true, EHolidayName.EasterDay.GetDescription(culture), PtCulture | ECulture.esES),
            new Holiday(1, null, false, EHolidayName.EasterMonday.GetDescription(culture), EasterMonday)
            };

        /// <summary>
        /// The days on week
        /// </summary>
        private static readonly int DaysOnWeek = 7;

        /// <summary>
        /// Determines whether [is parent day] [the specified date].
        /// </summary>
        /// <param name="date">The date.</param>
        /// <param name="culture">The culture.</param>
        /// <returns></returns>
        private static string GetParentDay(DateTime date, ECulture culture)
        {
            if (date.Month != 5 && date.Month != 8)
            {
                return null;
            }

            if (culture == ECulture.enCA && (date.Month != 7 && date.Month != 5))
            {
                return null;
            }

            var parentDateName = date.Month == 5 ?
                EHolidayName.MotherDay : EHolidayName.FatherDay;

            var firstDay = new DateTime(date.Year, date.Month, 1);

            var parentDate = firstDay.AddDays(DaysOnWeek);

            if (firstDay.DayOfWeek != DayOfWeek.Sunday)
            {
                var sundaysInMonth = GetTotalSunday(parentDateName, culture);

                var daysLeft = (DaysOnWeek * sundaysInMonth) - (int)firstDay.DayOfWeek;

                parentDate = firstDay.AddDays(daysLeft);
            }

            var isParentDate = parentDate.Date.CompareTo(date.Date) == 0;

            if (!isParentDate)
            {
                return null;
            }

            return parentDateName.GetDescription(culture);
        }

        /// <summary>
        /// Gets the total sunday.
        /// </summary>
        /// <param name="parentDateName">Name of the parent date.</param>
        /// <param name="culture">The culture.</param>
        /// <returns></returns>
        private static int GetTotalSunday(EHolidayName parentDateName, ECulture culture)
        {
            var sundaysInMonth = 2;
            switch (culture)
            {
                case ECulture.enCA:
                    if (parentDateName == EHolidayName.FatherDay)
                    {
                        sundaysInMonth = 3;
                    }
                    break;

                case ECulture.ptPT:
                    if (parentDateName == EHolidayName.MotherDay)
                    {
                        sundaysInMonth = 1;
                    }
                    break;

                default:
                    sundaysInMonth = 2;
                    break;
            }
            return sundaysInMonth;
        }

        /// <summary>
        /// Calculates the mobile holidays.
        /// </summary>
        /// <param name="date">The date.</param>
        private static void CalculateEasterDay(DateTime date)
        {
            var year = date.Year;
            var c = year / 100;
            var n = year - (19 * (year / 19));
            var k = (c - 17) / 25;
            var i = c - c / 4 - ((c - k) / 3) + (19 * n) + 15;
            i = i - (30 * (i / 30));
            i = i - ((i / 28) * (1 - (i / 28)) * (29 / (i + 1)) * ((21 - n) / 11));
            var j = year + year / 4 + i + 2 - c + c / 4;
            j = j - ((7 * (j / 7)));
            var l = i - j;
            var month = 3 + ((l + 40) / 44);
            var day = l + 28 - (31 * (month / 4));

            EasterDay = new DateTime(year, month, day);
        }

        /// <summary>
        /// Determines whether [is mobile holiday] [the specified culture].
        /// </summary>
        /// <param name="date">The date.</param>
        /// <param name="culture">The culture.</param>
        /// <returns></returns>
        public static Holiday GetMobileHoliday(DateTime date, ECulture culture)
        {
            var holidayNameList = new List<string>();

            var isNational = false;

            var parentDate = GetParentDay(date, culture);

            if (!string.IsNullOrEmpty(parentDate))
            {
                holidayNameList.Add(parentDate);
                isNational = true;
            }

            CalculateEasterDay(date);

            foreach (var holiday in Holidays(culture))
            {
                if (((culture & holiday.Culture) == culture) && EqualsDate(date, holiday.DaysLeft.Value))
                {
                    holidayNameList.AddRange(holiday.HolidayName);
                }
            }

            var isHoliday = holidayNameList.Any();

            if (isHoliday)
            {
                return new Holiday(null, date.Day, isNational, holidayNameList, culture);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Equals the specified date.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <param name="days">The days.</param>
        /// <returns></returns>
        private static bool EqualsDate(DateTime date, int days)
        {
            var holiday = EasterDay.AddDays(days);

            var result = holiday.Date.CompareTo(date.Date);

            return result == 0;
        }
    }
}