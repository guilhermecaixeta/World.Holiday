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

        [TestCase(Year, 11, 02, ECulture.enUS)]
        [TestCase(Year, 02, 02, ECulture.ptPT)]
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

        [TestCase(25, ECulture.ptBR)]
        [TestCase(19, ECulture.ptPT)]
        [TestCase(13, ECulture.enUS)]
        [TestCase(19, ECulture.enCA)]
        [TestCase(27, ECulture.esES)]
        public void HolidayDate_HolidaysInMonth_DateInDays_Year(int totalHolidays, ECulture culture)
        {
            var fakeStartDate = new DateTime(Year, 01, 01);

            var fakeHolidays = DateHolidays.GetInInterval(fakeStartDate, 365, culture);

            var count = 0;

            foreach (var fakeHoliday in fakeHolidays)
            {
                if (string.IsNullOrEmpty(fakeHoliday.Name))
                {
                    count++;
                }
            }

            var value = (count, fakeHolidays.Count());

            Assert.AreEqual((0, totalHolidays), value);

        }

        [TestCase(02, 03, ECulture.ptBR)]
        [TestCase(02, 01, ECulture.ptPT)]
        [TestCase(02, 02, ECulture.esES)]
        public void HolidayDate_HolidaysInMonth_FromCurrentlyDate(int month, int holidaysInMonth, ECulture culture)
        {
            var fakeHolidays = DateHolidays.GetFromCurrentlyDate(15, culture);

            var count = fakeHolidays.Count();

            Assert.AreEqual(holidaysInMonth, count);
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

        [TestCase(Year, 04, 21, ECulture.enCA)]
        [TestCase(Year, 04, 23, ECulture.enCA)]
        [TestCase(Year, 07, 01, ECulture.ptBR)]
        [TestCase(Year, 06, 21, ECulture.ptBR)]
        [TestCase(Year, 05, 22, ECulture.enUS)]
        [TestCase(Year, 05, 03, ECulture.enUS)]
        [TestCase(Year, 11, 11, ECulture.ptPT)]
        [TestCase(Year, 03, 07, ECulture.ptPT)]
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

        [TestCase(Year, 07, 25, ECulture.esES, false)]
        [TestCase(Year, 08, 15, ECulture.esES, true)]
        [TestCase(Year, 05, 22, ECulture.ptPT, false)]
        [TestCase(Year, 12, 08, ECulture.ptPT, true)]
        [TestCase(Year, 04, 21, ECulture.ptBR, true)]
        [TestCase(Year, 12, 08, ECulture.ptBR, false)]
        [TestCase(Year, 07, 01, ECulture.enCA, true)]
        [TestCase(Year, 06, 24, ECulture.enCA, false)]
        [TestCase(Year, 01, 01, ECulture.ptBR, true)]
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

        [TestCase(Year, 05, 22, ECulture.ptPT)]
        [TestCase(Year, 05, 03, ECulture.ptPT)]
        [TestCase(Year, 05, 10, ECulture.ptBR)]
        [TestCase(Year, 08, 09, ECulture.ptBR)]
        [TestCase(Year, 05, 10, ECulture.enCA)]
        [TestCase(Year, 06, 21, ECulture.enCA)]
        [TestCase(Year, 04, 12, ECulture.esES)]
        [TestCase(Year, 04, 09, ECulture.esES)]
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

        [TestCase(Year, 04, 12, ECulture.ptBR, EHolidayName.EasterDay)]
        [TestCase(Year, 10, 12, ECulture.ptBR, EHolidayName.DayOfAparecida)]
        [TestCase(Year, 04, 13, ECulture.enCA, EHolidayName.EasterMonday)]
        [TestCase(Year, 08, 03, ECulture.enCA, EHolidayName.AugustCivicHoliday)]
        [TestCase(Year, 12, 08, ECulture.ptBR, EHolidayName.ImmaculateConception)]
        [TestCase(Year, 12, 08, ECulture.ptPT, EHolidayName.ImmaculateConception)]
        [TestCase(Year, 08, 15, ECulture.ptPT, EHolidayName.AssumptionOfMaria)]
        [TestCase(Year, 08, 15, ECulture.esES, EHolidayName.AssumptionOfMaria)]
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
    }
}