using NUnit.Framework;
using System;
using System.Linq;
using World.Holidays.Enum;
using World.Holidays.Extensions;
using static World.Holidays.Enum.Culture;

namespace World.Holidays.Test.Tests
{
    [TestFixture]
    public class HolidaysTest
    {
        private const int Year = 2020;
        
        [TestCase(Year, 7, 25, ECulture.esES, false)]
        [TestCase(Year, 8, 15, ECulture.esES, true)]
        [TestCase(Year, 5, 22, ECulture.ptPT, false)]
        [TestCase(Year, 12, 8, ECulture.ptPT, true)]
        [TestCase(Year, 4, 21, ECulture.ptBR, true)]
        [TestCase(Year, 12, 8, ECulture.ptBR, false)]
        [TestCase(Year, 7, 1, ECulture.enCA, true)]
        [TestCase(Year, 6, 24, ECulture.enCA, false)]
        [TestCase(Year, 1, 1, ECulture.ptBR, true)]
        [TestCase(Year, 12, 25, ECulture.enCA, true)]
        public void HolidayDate_ValidateHolidays(int year, int month, int day, ECulture culture, bool isNational)
        {
            var fakeDate = new DateTime(year, month, day);

            var fakeHoliday = fakeDate.IsHoliday(culture);

            if (fakeHoliday.HasHoliday)
            {
                Assert.AreEqual(isNational, fakeHoliday.Holidays.FirstOrDefault().IsNational);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

        [TestCase(Year, 4, 21, ECulture.enCA)]
        [TestCase(Year, 4, 23, ECulture.enCA)]
        [TestCase(Year, 7, 1, ECulture.ptBR)]
        [TestCase(Year, 6, 21, ECulture.ptBR)]
        [TestCase(Year, 5, 22, ECulture.enUS)]
        [TestCase(Year, 5, 3, ECulture.enUS)]
        [TestCase(Year, 11, 11, ECulture.ptPT)]
        [TestCase(Year, 3, 7, ECulture.ptPT)]
        public void HolidayDate_InvalidHolidays(int year, int month, int day, ECulture culture)
        {
            var fakeDate = new DateTime(year, month, day);

            var fakeHoliday = fakeDate.IsHoliday(culture);

            if (!fakeHoliday.HasHoliday)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

        [TestCase(Year, 5, 22, ECulture.ptPT)]
        [TestCase(Year, 5, 3, ECulture.ptPT)]
        [TestCase(Year, 5, 10, ECulture.ptBR)]
        [TestCase(Year, 8, 9, ECulture.ptBR)]
        [TestCase(Year, 5, 10, ECulture.enCA)]
        [TestCase(Year, 6, 21, ECulture.enCA)]
        [TestCase(Year, 4, 12, ECulture.esES)]
        [TestCase(Year, 4, 9, ECulture.esES)]
        public void HolidayDate_ValidateMobileHolidays(int year, int month, int day, ECulture culture)
        {
            var fakeDate = new DateTime(year, month, day);

            var fakeHoliday = fakeDate.IsHoliday(culture);

            if (fakeHoliday.HasHoliday)
            {
                Assert.AreEqual(1, fakeHoliday.Holidays.Count);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

        [TestCase(Year, 4, 12, ECulture.ptBR, EHolidayName.EasterDay)]
        [TestCase(Year, 10, 12, ECulture.ptBR, EHolidayName.DayOfAparecida)]
        [TestCase(Year, 4, 13, ECulture.enCA, EHolidayName.EasterMonday)]
        [TestCase(Year, 8, 3, ECulture.enCA, EHolidayName.AugustCivicHoliday)]
        [TestCase(Year, 12, 8, ECulture.ptBR, EHolidayName.ImmaculateConception)]
        [TestCase(Year, 12, 8, ECulture.ptPT, EHolidayName.ImmaculateConception)]
        [TestCase(Year, 8, 15, ECulture.ptPT, EHolidayName.AssumptionOfMaria)]
        [TestCase(Year, 8, 15, ECulture.esES, EHolidayName.AssumptionOfMaria)]
        public void HolidayDate_ValidateNameHolidays(int year, int month, int day, ECulture culture, EHolidayName nameHoliday)
        {
            var fakeDate = new DateTime(year, month, day);

            var fakeHoliday = fakeDate.IsHoliday(culture);

            if (fakeHoliday.HasHoliday)
            {
                var count = fakeHoliday.Holidays.Where(x => x.Name.Equals(nameHoliday.GetDescription(culture))).Count();

                Assert.AreEqual(1, count);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

        [TestCase(Year, 02, 03, ECulture.ptBR)]
        [TestCase(Year, 04, 04, ECulture.ptPT)]
        [TestCase(Year, 04, 05, ECulture.esES)]
        public void HolidayDate_HolidaysInMonth_MinMaxDates(int year, int month, int holidaysInMonth, ECulture culture)
        {
            var fakeStartDate = new DateTime(year, month, 01);

            var fakeEndDate = fakeStartDate.AddMonths(1).AddDays(-1);

            var fakeHolidays = DateHolidays.GetInInterval(fakeStartDate, fakeEndDate, culture);

            var count = fakeHolidays.Count();

            Assert.AreEqual(holidaysInMonth, count);
        }

        [TestCase(Year, 02, 03, ECulture.ptBR)]
        [TestCase(Year, 04, 04, ECulture.ptPT)]
        [TestCase(Year, 04, 05, ECulture.esES)]
        public void HolidayDate_HolidaysInMonth_DateInDays(int year, int month, int holidaysInMonth, ECulture culture)
        {
            var fakeStartDate = new DateTime(year, month, 01);

            var fakeEndDate = fakeStartDate.AddMonths(1).AddDays(-1);

            var fakeDays = (fakeEndDate - fakeStartDate).Days;

            var fakeHolidays = DateHolidays.GetInInterval(fakeStartDate, fakeDays, culture);

            var count = fakeHolidays.Count();

            Assert.AreEqual(holidaysInMonth, count);
        }

        [TestCase(03, ECulture.ptBR)]
        [TestCase(01, ECulture.ptPT)]
        [TestCase(01, ECulture.esES)]
        public void HolidayDate_HolidaysInMonth_FromCurrentlyDate(int holidaysInMonth, ECulture culture)
        {
            var now = DateTime.Now;
            
            var fakeStartDate = new DateTime(now.Year, now.Month, 01);

            var fakeEndDate = fakeStartDate.AddMonths(1).AddDays(-1);

            var fakeDays = (fakeEndDate - now).Days;

            var fakeHolidays = DateHolidays.GetFromCurrentlyDate(fakeDays, culture);

            var count = fakeHolidays.Count();

            Assert.AreEqual(holidaysInMonth, count);
        }

    }
}