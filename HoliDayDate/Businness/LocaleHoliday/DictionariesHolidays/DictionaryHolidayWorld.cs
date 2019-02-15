using System.Collections.Generic;
using HoliDayDate.Entity;

namespace HoliDayDate.Locale.Dictionary
{
    public static class DictionaryHolidayWorld
    {
        public static readonly Dictionary<int, Dictionary<int, Holiday>> Holidays = new Dictionary<int, Dictionary<int, Holiday>>()
        {
            {
                1, new Dictionary<int, Holiday>()
                {
                    {1, new Holiday("Ano Novo")}
                }
            },
            {
                12, new Dictionary<int, Holiday>()
                {
                    {14, new Holiday("Natal")},
                }
            }
        };
    }
}