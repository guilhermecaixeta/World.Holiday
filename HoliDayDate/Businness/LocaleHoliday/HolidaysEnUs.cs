using System;
using HoliDayDate.Entity;
using HoliDayDate.Locale.CommomMethod;

namespace HoliDayDate.Locale
{
    public static class HolidaysEnUS
    {
        private static DateTimeHoliday dateReturn = new DateTimeHoliday(new DateTime(), false, "");
        public static DateTimeHoliday VerifyHolidaysEnUs(this DateTime date)
        {
            date.CalculateMobileHolidays();
            switch (date.Month)
            {
                case 1:
                    if (date.Day.Equals(21))
                        dateReturn = date.ReturnNewDateType(true, "Birthday of Martin Luther King Jr.");
                    break;
                case 2:
                    if (date.Day.Equals(14))
                        dateReturn = date.ReturnNewDateType(true, "Valentine's Day");
                    else if (date.Day.Equals(18))
                        dateReturn = date.ReturnNewDateType(true, "Washington's Birthday");
                    break;
                case 5:
                    if (date.Day.Equals(27))
                        dateReturn = date.ReturnNewDateType(true, "Memorial Day");
                    break;
                case 7:
                    if (date.Day.Equals(4))
                        dateReturn = date.ReturnNewDateType(true, "Independence Day");
                    break;
                case 9:
                    if (date.IsAFatherOrMotherDay(1, DayOfWeek.Monday))
                        dateReturn = date.ReturnNewDateType(true, "Labor Day");
                    break;
                case 10:
                    if (date.Day.Equals(14))
                        dateReturn = date.ReturnNewDateType(true, "Columbus Day");
                    break;
                case 11:
                    if (date.Day.Equals(11))
                        dateReturn = date.ReturnNewDateType(true, "Veterans Day");
                    else if (date.Day.Equals(28))
                        dateReturn = date.ReturnNewDateType(true, "Thanksgiving Day");
                    break;
            }
            return dateReturn;
        }

    }
}
