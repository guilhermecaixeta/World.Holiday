using System;
using System.Collections.Generic;

namespace World.Holidays.Entities
{
    /// <summary>
    /// Date time for holidays
    /// </summary>
    public class DateTimeHoliday
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeHoliday"/> class.
        /// </summary>
        /// <param name="date">The date.</param>
        public DateTimeHoliday(DateTime date)
        {
            Date = date;
            IsHoliday = false;
            IsNational = false;
            HolidayName = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeHoliday"/> class.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <param name="isHoliday">if set to <c>true</c> [is holiday].</param>
        /// <param name="isNational">if set to <c>true</c> [is national].</param>
        /// <param name="holidayName">Name of the holiday.</param>
        public DateTimeHoliday(DateTime date, bool isHoliday, bool isNational, IEnumerable<string> holidayName)
        {
            Date = date;
            IsHoliday = isHoliday;
            IsNational = isNational;
            HolidayName = holidayName;
        }

        /// <summary>
        /// Gets the date.
        /// </summary>
        /// <value>
        /// The date.
        /// </value>
        public DateTime Date { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this instance is holiday.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is holiday; otherwise, <c>false</c>.
        /// </value>
        public bool IsHoliday { get; private set; }

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
        /// Gets the name of the holiday.
        /// </summary>
        /// <value>
        /// The name of the holiday.
        /// </value>
        public IEnumerable<string> HolidayName { get; private set; }
    }
}