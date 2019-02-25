using System.Collections.Generic;
using HoliDayDate.Entity;

namespace HoliDayDate.Locale.Dictionary {
    /// <summary>
    /// Inform american's holidays.
    /// </summary>
    public static class DictionaryHolidayEnUs {
        public static readonly Dictionary<int, Dictionary<int, HolidayDate>> Holidays = new Dictionary<int, Dictionary<int, HolidayDate>> () {
            {
            1,
            new Dictionary<int, HolidayDate> () { { 21, new HolidayDate ("Birthday of Martin Luther King Jr.", true) }
            }
            }, {
            2,
            new Dictionary<int, HolidayDate> () { { 18, new HolidayDate ("Washington's Birthday", true) }
            }
            }, {
            5,
            new Dictionary<int, HolidayDate> () { { 27, new HolidayDate ("Memorial Day", true) }
            }
            }, {
            7,
            new Dictionary<int, HolidayDate> () { { 4, new HolidayDate ("Independence Day", true) }
            }
            }, {
            10,
            new Dictionary<int, HolidayDate> () { { 14, new HolidayDate ("Columbus Day", true) }
            }
            }, {
            11,
            new Dictionary<int, HolidayDate> () { { 11, new HolidayDate ("Veterans Day", true) }, { 28, new HolidayDate ("Thanksgiving Day", true) }
            }
            },
        };
    }
}