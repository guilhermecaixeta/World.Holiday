using NUnit.Framework;
using System;
using World.Holidays.Exceptions;
using World.Holidays.Extensions;
using static World.Holidays.Enum.Culture;

namespace World.Holidays.Test.Tests
{
    [TestFixture]
    public class ExceptionsTest
    {
        [Test]
        public void DateTimeHoliday_IsHoliday_DateMinException() =>
            Assert.Throws<DateTimeMinMaxException>(() => DateTime.MinValue.IsHoliday(ECulture.ptBR));

        [Test]
        public void DateTimeHoliday_IsHoliday_DateMaxException() =>
            Assert.Throws<DateTimeMinMaxException>(() => DateTime.MaxValue.IsHoliday(ECulture.ptBR));

        [Test]
        public void DateTimeHoliday_SetInterval_ECultureDefault_ArgumentNullException() =>
            Assert.Throws<LessThanZeroException>(() => DateHolidays.GetFromCurrentlyDate(-1, ECulture.enCA));
    }
}
