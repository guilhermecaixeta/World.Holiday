using System.Linq;
using World.Holidays.Attributes;
using World.Holidays.Enum;
using static World.Holidays.Enum.Culture;

namespace World.Holidays.Extensions
{
    /// <summary>
    /// Extension to get description by culture
    /// </summary>
    public static class EnumDescritiption
    {
        /// <summary>
        /// Gets the description.
        /// </summary>
        /// <param name="holidayName">Name of the holiday.</param>
        /// <param name="culture">The culture.</param>
        /// <returns></returns>
        public static string GetDescription(this EHolidayName holidayName, ECulture culture)
        {
            var enumType = holidayName.GetType();
            var memberInfo = enumType.GetMember(holidayName.ToString()).FirstOrDefault();
            var attributes = (DescriptionHoliday[])memberInfo.GetCustomAttributes(typeof(DescriptionHoliday), true);

            var description = string.Empty;

            foreach (var attr in attributes)
            {
                if ((culture & attr.Culture) == culture)
                {
                    description = attr.Description;
                }
            }

            return description;
        }
    }
}