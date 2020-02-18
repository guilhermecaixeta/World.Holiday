using System;
using System.Collections.Generic;
using System.Linq;

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
        /// <param name="holidaysInMonth">The holidays in month.</param>
        public DateTimeHoliday(DateTime date, IEnumerable<Holiday> holidaysInMonth)
        {
            Date = date;
            HolidaysInMonth = holidaysInMonth;
        }

        /// <summary>
        /// Gets the current date informed.
        /// </summary>
        /// <value>
        /// The date.
        /// </value>
        public DateTime Date { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this instance has holiday.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has holiday; otherwise, <c>false</c>.
        /// </value>
        public bool HasHoliday { get => HolidaysInMonth.Any(); }

        /// <summary>
        /// Gets or sets the holidays in month.
        /// </summary>
        /// <value>
        /// The holidays in month.
        /// </value>
        private IEnumerable<Holiday> HolidaysInMonth { get; set; }

        /// <summary>
        /// Gets the holidays.
        /// </summary>
        /// <value>
        /// The holidays.
        /// </value>
        public IReadOnlyList<Holiday> Holidays { get => HolidaysInMonth.ToList(); }
    }
}