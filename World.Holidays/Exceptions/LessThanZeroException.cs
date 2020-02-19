using System;

namespace World.Holidays.Exceptions
{
    /// <summary>
    /// Less than zero exception
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class LessThanZeroException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LessThanZeroException"/> class.
        /// </summary>
        public LessThanZeroException() : base("The value is less than zero!")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LessThanZeroException"/> class.
        /// </summary>
        /// <param name="innerException">The inner exception.</param>
        public LessThanZeroException(Exception innerException) : base("The value is less than zero!", innerException)
        {
        }
    }
}