using System;
using static World.Holidays.Enum.Culture;

namespace World.Holidays.Attributes
{
    /// <summary>
    /// Attribute used to set description and culture used on the holidays.
    /// </summary>
    /// <seealso cref="System.Attribute" />
    [System.AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    internal class DescriptionHoliday : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DescriptionHoliday"/> class.
        /// </summary>
        /// <param name="description">The description.</param>
        /// <param name="culture">The culture.</param>
        public DescriptionHoliday(string description, ECulture culture)
        {
            Description = description;
            Culture = culture;
        }

        /// <summary>
        /// Gets or sets the culture.
        /// </summary>
        /// <value>
        /// The culture.
        /// </value>
        public ECulture Culture { get; private set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; private set; }
    }
}