using System;
using System.Collections.Generic;
using System.Text;

namespace World.Holidays.Exceptions
{
    /// <summary>
    /// The date min is bigger than max date.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class MinDateIsBiggerThanMaxDate : Exception
    {
        private static string message = "The date {0} is bigger than {1}, check the dates informed.";

        /// <summary>
        /// Initializes a new instance of the <see cref="MinDateIsBiggerThanMaxDate"/> class.
        /// </summary>
        public MinDateIsBiggerThanMaxDate()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MinDateIsBiggerThanMaxDate"/> class.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        public MinDateIsBiggerThanMaxDate(DateTime min, DateTime max) : base(string.Format(message, min, max))
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MinDateIsBiggerThanMaxDate"/> class.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <param name="innerException">The inner exception.</param>
        public MinDateIsBiggerThanMaxDate(DateTime min, DateTime max, Exception innerException) : base(string.Format(message, min, max), innerException)
        {

        }
    }
}
