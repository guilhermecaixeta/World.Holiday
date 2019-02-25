using System.Collections.Generic;
using HoliDayDate.Entity;
using HoliDayDate.Enums;

namespace HoliDayDate.Locale.Dictionary {
    /// <summary>
    /// Informing world holiday
    /// </summary>
    public static class DictionaryHolidayWorld {
        public static readonly Dictionary<int, Dictionary<int, Dictionary<LocaleHoliday, string>>> Holidays = new Dictionary<int, Dictionary<int, Dictionary<LocaleHoliday, string>>> () {
            {
            1,
            new Dictionary<int, Dictionary<LocaleHoliday, string>> () {
            {
            1,
            new Dictionary<LocaleHoliday, string> () { { LocaleHoliday.ptBr, "Ano Novo" }, { LocaleHoliday.enUS, "New Year's Day" }
            }
            }
            }
            }, {
            2,
            new Dictionary<int, Dictionary<LocaleHoliday, string>> () {
            {
            14,
            new Dictionary<LocaleHoliday, string> () { { LocaleHoliday.ptPt, "Dia dos Namorados" }, { LocaleHoliday.enUS, "Valentine's Day" },
            { LocaleHoliday.enCa, "Valentine's Day" }
            }
            }
            }
            }, {
            12,
            new Dictionary<int, Dictionary<LocaleHoliday, string>> () {
            {
            25,
            new Dictionary<LocaleHoliday, string> () { { LocaleHoliday.ptBr, "Natal" }, { LocaleHoliday.enUS, "Christmas Day" }
            }
            }
            }
            }
        };
    }
}