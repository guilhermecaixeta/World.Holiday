using System.Collections.Generic;
using static World.Holidays.Enum.Culture;

namespace World.Holidays.Entities
{
    internal class Holiday
    {
        public Holiday(int? day, bool isNational, string holidayName, ECulture culture)
        {
            Day = day;
            IsNational = isNational;
            HolidayName = new List<string>();
            HolidayName.Add(holidayName);
            Culture = culture;
        }

        public Holiday(int? daysLeft, int? day, bool isNational, string holidayName, ECulture culture)
        {
            DaysLeft = daysLeft;
            Day = day;
            IsNational = isNational;
            HolidayName = new List<string>();
            HolidayName.Add(holidayName);
            Culture = culture;
        }

        public Holiday(int? daysLeft, int? day, bool isNational, List<string> holidayName, ECulture culture)
        {
            DaysLeft = daysLeft;
            Day = day;
            IsNational = isNational;
            HolidayName = holidayName;
            Culture = culture;
        }

        public int? DaysLeft { get; private set; }
        public int? Day { get; private set; }
        public bool IsNational { get; private set; }
        public List<string> HolidayName { get; private set; }
        public ECulture Culture { get; private set; }
    }
}