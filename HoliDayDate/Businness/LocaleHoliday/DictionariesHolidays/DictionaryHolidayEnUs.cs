using System.Collections.Generic;
using HoliDayDate.Entity;

namespace HoliDayDate.Locale.Dictionary
{
    /// <summary>
    /// Inform american's holidays.
    /// </summary>
    public static class DictionaryHolidayEnUs
    {
        public static readonly Dictionary<int, Dictionary<int, Holiday>> Holidays = new Dictionary<int, Dictionary<int, Holiday>>()
        {
            {
                1, new Dictionary<int, Holiday>()
                {
                    {21, new Holiday("Birthday of Martin Luther King Jr.")}
                }
            },
            {
                2, new Dictionary<int, Holiday>()
                {
                    {14, new Holiday("Valentine's Day")},
                    {18, new Holiday("Washington's Birthday")}
                }
            },{
                5, new Dictionary<int, Holiday>()
                {
                    {27, new Holiday("Memorial Day")}
                }
            },
            {
                7, new Dictionary<int, Holiday>()
                {
                    {4, new Holiday("Independence Day")}
                }
            },
            {
                10, new Dictionary<int, Holiday>()
                {
                    {14, new Holiday("Columbus Day")}
                }
            },
            {
                11, new Dictionary<int, Holiday>()
                {
                    {11, new Holiday("Veterans Day")},
                    {28, new Holiday("Thanksgiving Day")}
                }
            },
        };
    }
}