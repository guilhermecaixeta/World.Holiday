using System;
using System.Collections.Generic;
using World.Holidays.Entities;
using World.Holidays.Enum;
using static World.Holidays.Enum.Culture;

namespace World.Holidays.Extensions
{
    /// <summary>
    /// Mobile holidays.
    /// </summary>
    internal static class FindMobileHolidays
    {
        /// <summary>
        /// The days on week
        /// </summary>
        private static readonly int DaysOnWeek = 7;

        /// <summary>
        /// The easter day
        /// </summary>
        private static DateTime EasterDay;

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
        /// Gets the days left to.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <param name="month">The month.</param>
        /// <param name="sundaysUntilHoliday">The sundays until holiday.</param>
        /// <returns></returns>
        private static DateTime GetDaysLeftTo(int year, int month, int sundaysUntilHoliday)
        {
            var firstDay = new DateTime(year, month, 1);

            var dayOfWeek = firstDay.DayOfWeek;

            var daysLeft = 0;

            if (dayOfWeek != DayOfWeek.Sunday)
            {
                daysLeft = (DaysOnWeek * sundaysUntilHoliday) - (int)dayOfWeek;
            }

            var parentDate = firstDay.AddDays(daysLeft);

            return parentDate;
        }

        /// <summary>
        /// Gets the fathers day.
        /// </summary>
        /// <param name="dateTime">The date time.</param>
        /// <param name="culture">The culture.</param>
        /// <returns></returns>
        private static Holiday GetFathersDay(DateTime dateTime, ECulture culture)
        {
            if ((culture & (EnCulture | ECulture.ptBR)) != culture)
            {
                return null;
            }

            var month = 0;

            if ((culture & ECulture.ptBR) == culture)
            {
                month = 8;
            }
            if ((culture & EnCulture) == culture)
            {
                month = 6;
            }

            var holiday = GetParentDay(dateTime.Year, month, culture, EHolidayName.FatherDay, false);

            return holiday;
        }

        /// <summary>
        /// Gets the mothers day.
        /// </summary>
        /// <param name="dateTime">The date time.</param>
        /// <param name="culture">The culture.</param>
        /// <returns></returns>
        private static Holiday GetMothersDay(DateTime dateTime, ECulture culture) =>
            GetParentDay(dateTime.Year, 5, culture, EHolidayName.MotherDay, true);

        /// <summary>
        /// Gets the parent day.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <param name="month">The month.</param>
        /// <param name="culture">The culture.</param>
        /// <param name="holidayName">Name of the holiday.</param>
        /// <param name="isNational">if set to <c>true</c> [is national].</param>
        /// <returns></returns>
        private static Holiday GetParentDay(int year, int month, ECulture culture, EHolidayName holidayName, bool isNational)
        {
            var sundays = GetTotalSunday(holidayName, culture);

            var parentDate = GetDaysLeftTo(year, month, sundays);

            return new Holiday(parentDate, isNational, holidayName.GetDescription(culture), culture);
        }

        /// <summary>
        /// Gets the total sunday.
        /// </summary>
        /// <param name="holidayName">Name of the parent date.</param>
        /// <param name="culture">The culture.</param>
        /// <returns></returns>
        private static int GetTotalSunday(EHolidayName holidayName, ECulture culture)
        {
            var sundaysInMonth = 2;

            switch (culture)
            {
                case ECulture.enCA:
                case ECulture.enUS:
                    if (holidayName == EHolidayName.FatherDay)
                    {
                        sundaysInMonth = 3;
                    }
                    break;

                case ECulture.esES:
                case ECulture.ptPT:
                    if (holidayName == EHolidayName.MotherDay)
                    {
                        sundaysInMonth = 1;
                    }
                    break;
            }
            return sundaysInMonth;
        }

        /// <summary>
        /// The holidays
        /// </summary>
        public static Holiday[] Holidays(DateTime dateTime, ECulture culture)
        {
            CalculateEasterDay(dateTime);

            return new[]
            {
                new Holiday(EasterDay.AddDays(-3), false, EHolidayName.HolyThursday.GetDescription(culture), ECulture.esES),
                new Holiday(EasterDay.AddDays(-2), true, EHolidayName.GoodFriday.GetDescription(culture), EasterMonday | ECulture.ptBR),
                new Holiday(EasterDay.AddDays(-46), true, EHolidayName.AshWednesday.GetDescription(culture), ECulture.ptBR),
                new Holiday(EasterDay.AddDays(-47), true, EHolidayName.MardiGrass.GetDescription(culture), ECulture.ptBR),
                new Holiday(EasterDay.AddDays(-48), culture != ECulture.ptPT, EHolidayName.MardiGrass.GetDescription(culture), PtCulture),
                new Holiday(EasterDay.AddDays(60), false, EHolidayName.CorpusChristi.GetDescription(culture), PtCulture | ECulture.esES),
                new Holiday(EasterDay.AddDays(39), false, EHolidayName.AscensionThursday.GetDescription(culture), ECulture.ptPT),
                new Holiday(EasterDay.AddDays(0), true, EHolidayName.EasterDay.GetDescription(culture), PtCulture | ECulture.esES),
                new Holiday(EasterDay.AddDays(1), false, EHolidayName.EasterMonday.GetDescription(culture), EasterMonday),
                GetMothersDay(dateTime, culture),
                GetFathersDay(dateTime, culture)
            };
        }
    }
}