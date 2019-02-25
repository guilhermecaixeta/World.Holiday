using System;
using System.Collections.Generic;
using Holiday.Businness.Extension.LocaleHoliday.DictionariesHolidays;
using HoliDayDate.Entity;
using HoliDayDate.Locale.CommomMethod;

namespace Holiday.Businness.Extension.LocaleHoliday {
    public static class HolidaysPtPt {
        private static DateTimeHoliday dateReturn;
        private const int _numberOfSunday = 2;
        public static DateTimeHoliday VerifyHolidaysPtPt (this DateTime date) {
            dateReturn = new DateTimeHoliday (date, false, "");
            HolidayDate holiday = new HolidayDate (null, false);

            bool result = DictionaryHolidayPtPt.Holidays.TryGetValue (date.Month, out Dictionary<int, HolidayDate> holidays) ?
                holidays.TryGetValue (date.Day, out holiday) : false;

            if (!result) {
                date.CalculateMobileHolidays ();
                switch (date.Month) {
                    case 2:
                        if (date.IsCarnaval ())
                            dateReturn = date.ReturnNewDateType (true, "Carnaval");
                       break;
                    case 3:
                        if (date.IsCarnaval ())
                            dateReturn = date.ReturnNewDateType (true, "Carnaval");
                        else if (date.IsSextaSanta ())
                            dateReturn = date.ReturnNewDateType (true, "Sexta-Feira Santa");
                        else if (date.Day >= 22 && date.IsEasterDate ())
                            dateReturn = date.ReturnNewDateType (true, "Páscoa");
                        break;
                    case 4:
                        if (date.IsSextaSanta ())
                            dateReturn = date.ReturnNewDateType (true, "Sexta-Feira Santa");
                        else if (date.IsEasterDate ())
                            dateReturn = date.ReturnNewDateType (true, "Páscoa");
                        break;
                    case 5:
                        if (date.IsAFatherOrMotherDay (_numberOfSunday, DayOfWeek.Sunday))
                            dateReturn = date.ReturnNewDateType (true, "Dia das Mães");
                        else if (date.IsCorpusCristi ())
                            dateReturn = date.ReturnNewDateType (true, "Corpo de Deus");
                        break;
                    case 6:
                        if (date.IsCorpusCristi ())
                            dateReturn = date.ReturnNewDateType (true, "Corpo de Deus");
                        break;
                }
            } else if (holiday != null && holiday.isHoliday) {
                dateReturn = date.ReturnNewDateType (holiday.isHoliday, holiday.nameHoliday);
            }
            return dateReturn;
        }
    }
}