using System.Collections.Generic;
using HoliDayDate.Entity;

namespace HoliDayDate.Locale.Dictionary
{
    /// <summary>
    /// Inform brazilian's holidays.
    /// </summary>
    public static class DictionaryHolidayPtBR
    {
        public static readonly Dictionary<int, Dictionary<int, Holiday>> Holidays = new Dictionary<int, Dictionary<int, Holiday>>()
        {
            {
                4, new Dictionary<int, Holiday>()
                {
                    {21, new Holiday("Tiradentes", true)}
                }
            },
            {
                5, new Dictionary<int, Holiday>()
                {
                    {1, new Holiday("Dia do Trabalhador", true)}
                }
            },
            {
                6, new Dictionary<int, Holiday>()
                {
                    {24, new Holiday("São João", true)}
                }
            },
            {
                9, new Dictionary<int, Holiday>()
                {
                    {7, new Holiday("Independência do Brasil", true)}
                }
            },
            {
                10, new Dictionary<int, Holiday>()
                {
                    {10, new Holiday("Dia das Crianças", true)}
                }
            },
            {
                11, new Dictionary<int, Holiday>()
                {
                    {2, new Holiday("Dia de Finados", true)},
                    {15, new Holiday("Proclamação da República", true)},
                    {20, new Holiday("Dia da Consciência Negra", true)}
                }
            },
        };
    }
}