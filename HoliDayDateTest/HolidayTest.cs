using HoliDayDate.CalcHoliday;
using HoliDayDate.Enums;
using NUnit.Framework;
using System;

namespace Tests
{
    public class Test_Holidays
    {
        [TestCase(2019, 4, 21, LocaleHoliday.ptBr)]
        [TestCase(2019, 1, 21, LocaleHoliday.enUS)]
        [TestCase(2019, 1, 1, LocaleHoliday.ptBr)]
        [TestCase(2019, 1, 1, LocaleHoliday.enUS)]
        public void TestHolidayTrue(int year, int month, int day, LocaleHoliday locale)
        {
            var falseEnUsHoliday = new DateTime(year, month, day);
            var result = falseEnUsHoliday.TodayIsAHoliday(locale);
            Assert.IsTrue(result.IsHoliday);
        }

        [TestCase(2019, 4, 21, LocaleHoliday.enUS)]
        [TestCase(2019, 1, 21, LocaleHoliday.ptBr)]
        [TestCase(2019, 2, 2, LocaleHoliday.ptBr)]
        [TestCase(2019, 2, 2, LocaleHoliday.enUS)]
        public void TestHolidayFalse(int year, int month, int day, LocaleHoliday locale)
        {
            var falseEnUsHoliday = new DateTime(year, month, day);
            var result = falseEnUsHoliday.TodayIsAHoliday(locale);
            Assert.IsFalse(result.IsHoliday);
        }
    }
}