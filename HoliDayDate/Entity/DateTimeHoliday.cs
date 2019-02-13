using System;

namespace HoliDayDate.Entity
{
    public struct DateTimeHoliday
    {
        public DateTime Date {get; private set;}
        public bool IsHoliday { get; private set; }
        public string HolidayName { get; private set; }
        public DateTimeHoliday(DateTime date, bool isHoliday, string holidayName)
        {
            Date = date;
            IsHoliday = isHoliday;
            HolidayName = holidayName;
        }
    }
}