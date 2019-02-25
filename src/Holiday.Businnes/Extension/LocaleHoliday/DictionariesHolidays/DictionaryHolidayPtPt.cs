using System;
using System.Collections.Generic;
using HoliDayDate.Entity;

namespace Holiday.Businness.Extension.LocaleHoliday.DictionariesHolidays {
    public static class DictionaryHolidayPtPt {
        public static readonly Dictionary<int, Dictionary<int, HolidayDate>> Holidays = new Dictionary<int, Dictionary<int, HolidayDate>> () {
            {
            4,
            new Dictionary<int, HolidayDate> () { { 25, new HolidayDate ("Dia da Liberdade", true) }
            }
            }, {
            5,
            new Dictionary<int, HolidayDate> () { { 1, new HolidayDate ("Dia do Trablhador", true) }
            }
            }, {
            6,
            new Dictionary<int, HolidayDate> () { { 10, new HolidayDate ("Dia de Portugal", true) }
            }
            }, {
            8,
            new Dictionary<int, HolidayDate> () { { 15, new HolidayDate ("Assunção de Maria", true) }
            }
            }, {
            10,
            new Dictionary<int, HolidayDate> () { { 5, new HolidayDate ("Implantação da Replúbica", true) }
            }
            }, {
            11,
            new Dictionary<int, HolidayDate> () { { 1, new HolidayDate ("Todos os Santos", true) }
            }
            }, {
            12,
            new Dictionary<int, HolidayDate> () { { 10, new HolidayDate ("Restauração da Independência", true) }, { 10, new HolidayDate ("Imaculada Conceição", true) }
            }
            },
        };
    }
}