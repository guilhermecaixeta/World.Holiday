using HoliDayDate.CalcHoliday;
using HoliDayDate.Enums;
using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class Test_Holidays
    {
        [TestCase(2019, 4, 21, LocaleHoliday.ptBr)]
        [TestCase(2019, 1, 21, LocaleHoliday.enUS)]
        [TestCase(2019, 1, 1, LocaleHoliday.ptBr)]
        [TestCase(2019, 1, 1, LocaleHoliday.enUS)]
        public void Test_Date_Holiday_True(int year, int month, int day, LocaleHoliday locale)
        {
            var falseHoliday = new DateTime(year, month, day);
            var fakeResult = falseHoliday.TodayIsAHoliday(locale);
            Assert.IsTrue(fakeResult.IsHoliday);
        }

        [TestCase(2019, 4, 21, LocaleHoliday.enUS)]
        [TestCase(2019, 1, 21, LocaleHoliday.ptBr)]
        [TestCase(2019, 2, 2, LocaleHoliday.ptBr)]
        [TestCase(2019, 2, 2, LocaleHoliday.enUS)]
        public void Test_Date_Holiday_False(int year, int month, int day, LocaleHoliday locale)
        {
            var falseHoliday = new DateTime(year, month, day);
            var fakeResult = falseHoliday.TodayIsAHoliday(locale);
            Assert.IsFalse(fakeResult.IsHoliday);
        }
    }
}