using System;

namespace HoliDayDate.Entity
{
    public class DateTimeHoliday
    {
        public DateTime Date {get; private set;}
        public bool IsHoliday { get; private set; }
        public string NameHoliday { get; private set; }
        public DateTimeHoliday(DateTime date, bool isHoliday, string nameHoliday)
        {
            Date = date;
            IsHoliday = isHoliday;
            NameHoliday = nameHoliday;
        }
    }
}