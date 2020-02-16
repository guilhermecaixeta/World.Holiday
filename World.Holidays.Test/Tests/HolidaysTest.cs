using NUnit.Framework;
using System;
using System.Linq;
using World.Holidays.Extensions;
using static World.Holidays.Enum.Culture;

namespace World.Holidays.Test.Tests
{
    [TestFixture]
    public class HolidaysTest
    {
        private const int Year = 2020;

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

            if (isNational == fakeHoliday.IsNational && fakeHoliday.IsHoliday)
            {
                Assert.IsTrue(true);
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

            if (!fakeHoliday.IsHoliday)
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
        public void HolidayDate_ValidateMobileHolidays(int year, int month, int day, ECulture culture)
        {
            var fakeDate = new DateTime(year, month, day);

            var fakeHoliday = fakeDate.IsHoliday(culture);

            if (fakeHoliday.IsHoliday)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

        [TestCase(Year, 4, 12, ECulture.ptBR, "Páscoa")]
        [TestCase(Year, 10, 12, ECulture.ptBR, "Nossa Senhora Aparecida")]
        [TestCase(Year, 4, 13, ECulture.enCA, "Easter Monday")]
        [TestCase(Year, 8, 3, ECulture.enCA, "August Civic Holiday")]
        [TestCase(Year, 12, 8, ECulture.ptBR, "Nossa Senhora da Conceição")]
        [TestCase(Year, 12, 8, ECulture.ptPT, "Imaculada Conceição")]
        public void HolidayDate_ValidateNameHolidays(int year, int month, int day, ECulture culture, string nameHoliday)
        {
            var fakeDate = new DateTime(year, month, day);

            var fakeHoliday = fakeDate.IsHoliday(culture);

            if (fakeHoliday.IsHoliday)
            {
                Assert.IsTrue(fakeHoliday.HolidayName.Any(x => x.Equals(nameHoliday)));
            }
            else
            {
                Assert.IsTrue(false);
            }
        }
    }
}