using System;

namespace World.Holidays.Exceptions
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class DateTimeMinMaxException : Exception
    {
        private static string message = "The date {0} are equal to min or max date time value.";

        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeMinMaxException"/> class.
        /// </summary>
        public DateTimeMinMaxException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeMinMaxException"/> class.
        /// </summary>
        /// <param name="dateTime">The date time.</param>
        public DateTimeMinMaxException(DateTime dateTime) : base(string.Format(message, dateTime))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeMinMaxException"/> class.
        /// </summary>
        /// <param name="dateTime">The date time.</param>
        /// <param name="innerException">The inner exception.</param>
        public DateTimeMinMaxException(DateTime dateTime, Exception innerException) : base(string.Format(message, dateTime), innerException)
        {
        }
    }
}