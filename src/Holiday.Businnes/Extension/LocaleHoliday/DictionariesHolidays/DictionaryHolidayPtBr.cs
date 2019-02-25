using System.Collections.Generic;
using HoliDayDate.Entity;

namespace HoliDayDate.Locale.Dictionary
{
    /// <summary>
    /// Inform brazilian's holidays.
    /// </summary>
    public static class DictionaryHolidayPtBR
    {
        public static readonly Dictionary<int, Dictionary<int, HolidayDate>> Holidays = new Dictionary<int, Dictionary<int, HolidayDate>>()
        {
            {
                4, new Dictionary<int, HolidayDate>()
                {
                    {21, new HolidayDate("Tiradentes", true)}
                }
            },
            {
                5, new Dictionary<int, HolidayDate>()
                {
                    {1, new HolidayDate("Dia do Trabalhador", true)}
                }
            },
            {
                6, new Dictionary<int, HolidayDate>()
                {
                    {24, new HolidayDate("São João", true)}
                }
            },
            {
                9, new Dictionary<int, HolidayDate>()
                {
                    {7, new HolidayDate("Independência do Brasil", true)}
                }
            },
            {
                10, new Dictionary<int, HolidayDate>()
                {
                    {10, new HolidayDate("Dia das Crianças", true)}
                }
            },
            {
                11, new Dictionary<int, HolidayDate>()
                {
                    {2, new HolidayDate("Dia de Finados", true)},
                    {15, new HolidayDate("Proclamação da República", true)},
                    {20, new HolidayDate("Dia da Consciência Negra", true)}
                }
            },
        };
    }
}