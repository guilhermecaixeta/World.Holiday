using NUnit.Framework;
using System;
using World.Holidays.Extensions;

namespace World.Holidays.Test.Tests
{
    [TestFixture]
    public class DateTimeExtensionTest
    {
        private DateTime DateBetween { get; set; }

        private DateTime DateMax { get; set; }

        /// <summary>
        /// The date now
        /// </summary>
        private DateTime DateMin { get; set; }

        [Test]
        public void DateTime_IsBetween_InvalidValues()
        {
            var isValid = DateBetween.IsBetween(DateMax, DateMin);

            Assert.IsFalse(isValid);
        }

        [Test]
        public void DateTime_IsBetween_ValidValues()
        {
            var isValid = DateBetween.IsBetween(DateMin, DateMax);

            Assert.IsTrue(isValid);
        }

        [Test]
        public void DateTime_IsBiggerThan_InvalidValues()
        {
            var isValid = DateMin.IsBiggerThan(DateMax);

            Assert.IsFalse(isValid);
        }

        [Test]
        public void DateTime_IsBiggerThan_ValidValues()
        {
            var isValid = DateMax.IsBiggerThan(DateMin);

            Assert.IsTrue(isValid);
        }

        [SetUp]
        public void SetUp()
        {
            DateMin = DateTime.Now;
            DateMax = DateMin.AddDays(4);
            DateBetween = DateMin.AddDays(2);
        }
    }
}