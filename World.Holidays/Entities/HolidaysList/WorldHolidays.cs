using System.Collections.Generic;
using World.Holidays.Enum;
using World.Holidays.Extensions;
using static World.Holidays.Enum.Culture;

namespace World.Holidays.Entities.HolidaysList
{
    internal class WorldHolidays
    {
        private static ECulture Culture;

        private static int Year;

        public WorldHolidays(ECulture culture, int year)
        {
            Culture = culture;
            Year = year;
        }

        public IEnumerable<Holiday> Holidays() =>
            new List<Holiday>()
            {
#region January
                new Holiday(Year, 01, 01, true, EHolidayName.NewYear.GetDescription(Culture), AllCultures),
                //ES-ES
                new Holiday(Year, 01, 06, true, "Epifanía / Reyes Magos", ECulture.esES),
#endregion

#region February
                //EN-CA
                new Holiday(Year, 02,17, false, "Family Day",ECulture.enCA),
                //PT-BR
                new Holiday(Year, 02,14, false, EHolidayName.ValentineDay.GetDescription(Culture), ValentineDayCulture),
                //EN-US
                new Holiday(Year, 02,17, true, "Washington's Birthday",ECulture.enUS),
                //ES-ES
                new Holiday(Year, 02,28, false, "Día de Andalucía",ECulture.esES),
#endregion

#region March
                //EN-CA
                new Holiday(Year, 03,17, false, "St. Patrick's Day",ECulture.enCA),
                //PT-BR
                new Holiday(Year, 03,19,
                    false,
                    EHolidayName.SaintJose.GetDescription(Culture),
                    ECulture.ptBR | ECulture.esES),
                new Holiday(Year, 03, 25, false, "Data magna do estado do Ceará", ECulture.ptBR),
                //ES-ES
                new Holiday(Year, 03, 01,true, "Día de las Illes Balears", ECulture.esES),
#endregion

#region April
                //PT-BR
                new Holiday(Year, 04, 21, true, "Tiradentes", ECulture.ptBR),
                //ES-PT
                new Holiday(Year, 04, 23, false, EHolidayName.SaintGeorge.GetDescription(Culture), ECulture.ptBR | ECulture.esES),
                //PT-PT
                new Holiday(Year, 04, 25, false, "Dia da Liberdade", ECulture.ptPT),
#endregion

#region May
                //EN-CA
                new Holiday(Year, 05, 18, false, "Victoria Day",ECulture.enCA),
                //PT-ES
                new Holiday(Year, 05, 01,
                    true,
                    EHolidayName.LabourDay.GetDescription(Culture),
                    PtCulture | ECulture.esES),
                //EN-US
                new Holiday(Year, 05, 25, true, "Memorial Day",ECulture.enUS),
                //ES-ES
                new Holiday(Year, 05, 15, false, "San Isidro",ECulture.esES),
                new Holiday(Year, 05, 30, false, "Día de Canarias",ECulture.esES),
#endregion

#region June
                //EN-CA
                new Holiday(Year, 06, 21, false, "National Aboriginal Day", ECulture.enCA),
                new Holiday(Year, 06, 24, false, "National Holiday of Quebec", ECulture.enCA),
                //PT-BR
                new Holiday(Year, 06, 12,
                    false,
                    EHolidayName.ValentineDay.GetDescription(Culture),
                    ECulture.ptBR),
                //PT-ES
                new Holiday(Year, 06, 24,
                    false,
                    EHolidayName.SanJuan.GetDescription(Culture),
                    ECulture.ptBR | ECulture.esES),
                //PT-PT
                new Holiday(Year, 06, 13, false, "Dia de Santo António", ECulture.ptPT),
                //ES-ES
                new Holiday(Year, 06, 09, false, "Día de la Región de Murcia", ECulture.esES),
#endregion

#region July
                //EN-CA
                new Holiday(Year, 07, 01, true, "Canada Day",ECulture.enCA),
                new Holiday(Year, 07, 09, false, "Nunavut Day",ECulture.enCA),
                //PT-BR
                new Holiday(Year, 07, 02, false, "Independência da Bahia (BA)", ECulture.ptBR),
                new Holiday(Year, 07, 09, false, "Revolução Constitucionalista de 1932 (SP)", ECulture.ptBR),
                //EN-US
                new Holiday(Year, 07, 03, true, EHolidayName.IndependencyDay.GetDescription(Culture), ECulture.enUS),
                new Holiday(Year, 07, 04, true, EHolidayName.IndependencyDay.GetDescription(Culture), ECulture.enUS),
                //ES-ES
                new Holiday(Year, 07, 25, false, "Santiago Apóstol", ECulture.esES),
#endregion

#region August
                //EN-CA
                new Holiday(Year, 08, 03, false, "August Civic Holiday",ECulture.enCA),
                //PT-ES
                new Holiday(Year, 08, 15,
                            IsPtEs(),
                            EHolidayName.AssumptionOfMaria.GetDescription(Culture),
                            PtCulture | ECulture.esES),
#endregion 

#region September
                //EN
                new Holiday(Year, 09, 07, true, EHolidayName.LabourDay.GetDescription(Culture), EnCulture),
                //PT-BR
                new Holiday(Year, 09, 07, true, EHolidayName.IndependencyDay.GetDescription(Culture), ECulture.ptBR),
                //ES-ES
                new Holiday(Year, 09, 08, false, "Día de Asturias", ECulture.esES),
                new Holiday(Year, 09, 11, false, "Fiesta Nacional de Cataluña", ECulture.esES),
#endregion

#region October
                //EN-CA
                new Holiday(Year, 10, 12, false, EHolidayName.Thanksgiving.GetDescription(Culture), ECulture.enCA),
                //PT-BR
                new Holiday(Year, 10, 12, true, "Nossa Senhora Aparecida", ECulture.ptBR),
                //EN-US
                new Holiday(Year, 10, 12, true, "Columbus Day", ECulture.enUS),
                //PT-PT
                new Holiday(Year, 10, 05, true, "Implantação da República", ECulture.ptPT),
                //ES-ES
                new Holiday(Year, 10, 09, true, "Día de la Comunidad Valenciana", ECulture.esES),
                new Holiday(Year, 10, 09, true, "Fiesta Nacional de España", ECulture.esES),
#endregion

#region November #Rain
                //EN-CA
                new Holiday(Year, 11, 11, false, "Remembrance Day",ECulture.enCA),
                //PT-BR
                new Holiday(Year, 11, 02, true, "Dia dos finados", ECulture.ptBR),
                new Holiday(Year, 11, 15, true, "Proclamação da República", ECulture.ptBR),
                new Holiday(Year, 11, 20, false, "Dia da Consciência Negra", ECulture.ptBR),
                // EN-US
                new Holiday(Year, 11, 11, true, "Veterans Day", ECulture.enUS),
                new Holiday(Year, 11, 26, true, EHolidayName.Thanksgiving.GetDescription(Culture), ECulture.enUS),
                //PT-ES
                new Holiday(Year, 11, 01, true, EHolidayName.AllSaintsDay.GetDescription(Culture), ECulture.ptPT),
                //ES-ES
                new Holiday(Year, 11, 09, true, "Virgen de la Almudena", ECulture.esES),
#endregion

#region December
                //PT-PT
                new Holiday(Year, 12, 01, true, "Restauração da Independência", ECulture.ptPT),
                //PT
                new Holiday(Year, 12, 08,
                            IsPtEs(),
                            EHolidayName.ImmaculateConception.GetDescription(Culture),
                            PtCulture),
                // ALL
                new Holiday(Year, 12, 25, true, EHolidayName.ChristmasDay.GetDescription(Culture), AllCultures),
                // EN-CA
                new Holiday(Year, 12, 26, false, "Boxing Day", ECulture.enCA),
                // ES-ES
                new Holiday(Year, 12, 06, false, "Día de la Constitución", ECulture.esES)
#endregion
            };

        /// <summary>
        /// Determines whether [is pt es].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [is pt es]; otherwise, <c>false</c>.
        /// </returns>
        private static bool IsPtEs() =>
            (Culture & (ECulture.ptPT | ECulture.esES)) == Culture;
    }
}