using System;
using System.Collections.Generic;
using World.Holidays.Enum;
using World.Holidays.Extensions;
using static World.Holidays.Enum.Culture;

namespace World.Holidays.Entities.HolidaysList
{
    internal class WorldHolidays
    {
        private static ECulture Culture;

        public WorldHolidays(ECulture culture)
        {
            Culture = culture;
        }

        public Tuple<int, IEnumerable<Holiday>>[] Holidays() =>
            new Tuple<int, IEnumerable<Holiday>>[]
            {
                new Tuple<int, IEnumerable<Holiday>>(1, new List<Holiday>()
                    {
                        new Holiday(01, true, EHolidayName.NewYear.GetDescription(Culture), AllCultures),
                        //ES-ES
                        new Holiday(06, true, "Epifanía / Reyes Magos", ECulture.esES)
                    }),
                new Tuple<int, IEnumerable<Holiday>>(2, new List<Holiday>()
                    {
                        //EN-CA
                        new Holiday(17, false, "Family Day",ECulture.enCA),
                        //PT-BR
                        new Holiday(14, false, EHolidayName.ValentineDay.GetDescription(Culture), ValentineDayCulture),
                        //EN-US
                        new Holiday(17, true, "Washington's Birthday",ECulture.enUS),
                        //ES-ES
                        new Holiday(28, false, "Día de Andalucía",ECulture.esES),
                    }),
                new Tuple<int, IEnumerable<Holiday>>(3, new List<Holiday>()
                    {
                        //EN-CA
                        new Holiday(17, false, "St. Patrick's Day",ECulture.enCA),
                        //PT-BR
                        new Holiday(19,
                            false,
                            EHolidayName.SaintJose.GetDescription(Culture),
                            ECulture.ptBR | ECulture.esES),
                        new Holiday(25, false, "Data magna do estado do Ceará", ECulture.ptBR),
                        //ES-ES
                        new Holiday(01,true, "Día de las Illes Balears", ECulture.esES),
                    }),
                new Tuple<int, IEnumerable<Holiday>>(4, new List<Holiday>()
                    {
                        //PT-BR
                        new Holiday(21, true, "Tiradentes", ECulture.ptBR),
                        //ES-PT
                        new Holiday(23, false, EHolidayName.SaintGeorge.GetDescription(Culture), ECulture.ptBR | ECulture.esES),
                        //PT-PT
                        new Holiday(25, false, "Dia da Liberdade", ECulture.ptPT),
                    }),
                new Tuple<int, IEnumerable<Holiday>>(5, new List<Holiday>()
                    {
                        //EN-CA
                        new Holiday(18, false, "Victoria Day",ECulture.enCA),
                        //PT-ES
                        new Holiday(01,
                            true,
                            EHolidayName.LabourDay.GetDescription(Culture),
                            PtCulture | ECulture.esES),
                        //EN-US
                        new Holiday(25, true, "Memorial Day",ECulture.enUS),
                        //ES-ES
                        new Holiday(15, false, "San Isidro",ECulture.esES),
                        new Holiday(30, false, "Día de Canarias",ECulture.esES),
                    }),
                new Tuple<int, IEnumerable<Holiday>>(6, new List<Holiday>()
                    {
                        //EN-CA
                        new Holiday(21, false, "National Aboriginal Day", ECulture.enCA),
                        new Holiday(24, false, "National Holiday of Quebec", ECulture.enCA),
                        //PT-BR
                        new Holiday(12,
                            false,
                            EHolidayName.ValentineDay.GetDescription(Culture),
                            ECulture.ptBR),
                        //PT-ES
                        new Holiday(24,
                            false,
                            EHolidayName.SanJuan.GetDescription(Culture),
                            ECulture.ptBR | ECulture.esES),
                        //PT-PT
                        new Holiday(13, false, "Dia de Santo António", ECulture.ptPT),
                        //ES-ES
                        new Holiday(09, false, "Día de la Región de Murcia", ECulture.esES),
                    }),
                new Tuple<int, IEnumerable<Holiday>>(7, new List<Holiday>()
                    {
                        //EN-CA
                        new Holiday(01, true, "Canada Day",ECulture.enCA),
                        new Holiday(09, false, "Nunavut Day",ECulture.enCA),
                        //PT-BR
                        new Holiday(02, false, "Independência da Bahia (BA)", ECulture.ptBR),
                        new Holiday(09, false, "Revolução Constitucionalista de 1932 (SP)", ECulture.ptBR),
                        //EN-US
                        new Holiday(03, true, EHolidayName.IndependencyDay.GetDescription(Culture), ECulture.enUS),
                        new Holiday(04, true, EHolidayName.IndependencyDay.GetDescription(Culture), ECulture.enUS),
                        //ES-ES
                        new Holiday(25, false, "Santiago Apóstol", ECulture.esES),
                    }),
                new Tuple<int, IEnumerable<Holiday>>(8, new List<Holiday>()
                    {
                        //EN-CA
                        new Holiday(03, false, "August Civic Holiday",ECulture.enCA),
                        //PT-ES
                        new Holiday(15,
                                    IsPtEs()? true : false,
                                    EHolidayName.AssumptionOfMaria.GetDescription(Culture),
                                    PtCulture | ECulture.esES),
                    }),
                new Tuple<int, IEnumerable<Holiday>>(9, new List<Holiday>()
                    {
                        //EN
                        new Holiday(07, true, EHolidayName.LabourDay.GetDescription(Culture), EnCulture),
                        //PT-BR
                        new Holiday(07, true, EHolidayName.IndependencyDay.GetDescription(Culture), ECulture.ptBR),
                        //ES-ES
                        new Holiday(08, false, "Día de Asturias", ECulture.esES),
                        new Holiday(11, false, "Fiesta Nacional de Cataluña", ECulture.esES),
                    }),
                new Tuple<int, IEnumerable<Holiday>>(10, new List<Holiday>()
                    {
                        //EN-CA
                        new Holiday(12, false, EHolidayName.Thanksgiving.GetDescription(Culture), ECulture.enCA),
                        //PT-BR
                        new Holiday(12, true, "Nossa Senhora Aparecida", ECulture.ptBR),
                        //EN-US
                        new Holiday(12, true, "Columbus Day", ECulture.enUS),
                        //PT-PT
                        new Holiday(05, true, "Implantação da República", ECulture.ptPT),
                        //ES-ES
                        new Holiday(09, true, "Día de la Comunidad Valenciana", ECulture.esES),
                        new Holiday(09, true, "Fiesta Nacional de España", ECulture.esES)
                    }),
                new Tuple<int, IEnumerable<Holiday>>(11, new List<Holiday>()
                    {
                        //EN-CA
                        new Holiday(11, false, "Remembrance Day",ECulture.enCA),
                        //PT-BR
                        new Holiday(02, true, "Dia dos finados", ECulture.ptBR),
                        new Holiday(15, true, "Proclamação da República", ECulture.ptBR),
                        new Holiday(20, false, "Dia da Consciência Negra", ECulture.ptBR),
                        // EN-US
                        new Holiday(11, true, "Veterans Day", ECulture.enUS),
                        new Holiday(26, true, EHolidayName.Thanksgiving.GetDescription(Culture), ECulture.enUS),
                        //PT-ES
                        new Holiday(01, true, EHolidayName.AllSaintsDay.GetDescription(Culture), ECulture.ptPT),
                        //ES-ES
                        new Holiday(09, true, "Virgen de la Almudena", ECulture.esES),
                    }),
                new Tuple<int, IEnumerable<Holiday>>(12, new List<Holiday>()
                    {
                        //PT-PT
                        new Holiday(01, true, "Restauração da Independência", ECulture.ptPT),
                        //PT
                        new Holiday(08,
                                    IsPtEs()? true : false,
                                    EHolidayName.ImmaculateConception.GetDescription(Culture),
                                    PtCulture),
                        // ALL
                        new Holiday(25, true, EHolidayName.ChristmasDay.GetDescription(Culture), AllCultures),
                        // EN-CA
                        new Holiday(26, false, "Boxing Day", ECulture.enCA),
                        // ES-ES
                        new Holiday(06, false, "Día de la Constitución", ECulture.esES),
                    }),
            };

        /// <summary>
        /// Determines whether [is pt es].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [is pt es]; otherwise, <c>false</c>.
        /// </returns>
        private static bool IsPtEs() => (Culture & (ECulture.ptPT | ECulture.esES)) == Culture;
    }
}