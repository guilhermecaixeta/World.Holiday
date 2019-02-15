using System.Collections.Generic;
using HoliDayDate.Entity;
using HoliDayDate.Enums;

namespace HoliDayDate.Locale.Dictionary
{
    public static class DictionaryHolidayWorld
    {
        public static readonly Dictionary<int, Dictionary<int, Dictionary<LocaleHoliday, string>>> Holidays = new Dictionary<int, Dictionary<int, Dictionary<LocaleHoliday, string>>>()
        {
            {
                1, new Dictionary<int, Dictionary<LocaleHoliday, string>>()
                {
                    {1, new Dictionary<LocaleHoliday, string>()
                        {
                            {LocaleHoliday.ptBr, "Ano Novo"},
                            {LocaleHoliday.enUS, "New Year's Day"}
                        }
                    }
                }
            },
            {
                12, new Dictionary<int, Dictionary<LocaleHoliday, string>>()
                {
                    {25, new Dictionary<LocaleHoliday, string>()
                        {
                            {LocaleHoliday.ptBr, "Natal"},
                            {LocaleHoliday.enUS, "Christmas Day"}
                        }
                    }
                }
            }
        };
    }
}