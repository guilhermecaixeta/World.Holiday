using System;
using static World.Holidays.Enum.Culture;

namespace World.Holidays.Entities
{
    /// <summary>
    /// The Holiday.
    /// </summary>
    public class Holiday
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Holiday"/> class.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <param name="month">The month.</param>
        /// <param name="day">The day.</param>
        /// <param name="isNational">if set to <c>true</c> [is national].</param>
        /// <param name="name">The name.</param>
        /// <param name="culture">The culture.</param>
        public Holiday(int year, int month, int day, bool isNational, string name, ECulture culture)
        {
            Date = new DateTime(year, month, day);
            Ticks = Date.Date.Ticks;
            IsNational = isNational;
            Name = name;
            Culture = culture;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Holiday"/> class.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <param name="daysLeft">The days left.</param>
        /// <param name="isNational">if set to <c>true</c> [is national].</param>
        /// <param name="name">The name.</param>
        /// <param name="culture">The culture.</param>
        public Holiday(DateTime date, int? daysLeft, bool isNational, string name, ECulture culture)
        {
            Date = date;
            Ticks = Date.Date.Ticks;
            DaysLeft = daysLeft;
            IsNational = isNational;
            Name = name;
            Culture = culture;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Holiday"/> class.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <param name="isNational">if set to <c>true</c> [is national].</param>
        /// <param name="name">The name.</param>
        /// <param name="culture">The culture.</param>
        public Holiday(DateTime date, bool isNational, string name, ECulture culture)
        {
            Date = date;
            Ticks = Date.Date.Ticks;
            IsNational = isNational;
            Name = name;
            Culture = culture;
        }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>
        /// The date.
        /// </value>
        public DateTime Date { get; private set; }

        /// <summary>
        /// Gets the days left.
        /// </summary>
        /// <value>
        /// The days left.
        /// </value>
        public int? DaysLeft { get; private set; } = 0;

        /// <summary>
        /// Gets the day.
        /// </summary>
        /// <value>
        /// The day.
        /// </value>
        public int? Day { get => Date.Day; }

        /// <summary>
        /// Gets a value indicating whether this instance is national.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is national; otherwise, <c>false</c>.
        /// </value>
        public bool IsNational { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this instance is weekend.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is weekend; otherwise, <c>false</c>.
        /// </value>
        public bool IsWeekend
        {
            get => Date.DayOfWeek == DayOfWeek.Sunday ||
                Date.DayOfWeek == DayOfWeek.Saturday;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the culture.
        /// </summary>
        /// <value>
        /// The culture.
        /// </value>
        public ECulture Culture { get; private set; }

        internal long Ticks { get; private set; }

        /// <summary>
        /// Calculates the days left.
        /// </summary>
        /// <param name="currentDate">The current date.</param>
        internal void CalculateDaysLeft(DateTime currentDate)
        {
            if (Date.Date.CompareTo(currentDate) > 0)
            {
                var timeSpan = Date - currentDate;

                DaysLeft = timeSpan.Days;
            }
        }
    }
}