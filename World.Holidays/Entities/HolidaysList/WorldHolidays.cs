using System.Collections.Generic;
using World.Holidays.Enum;
using World.Holidays.Extensions;
using static World.Holidays.Enum.Culture;

namespace World.Holidays.Entities.HolidaysList
{
    internal class WorldHolidays
    {
        private readonly ECulture Culture;

        private readonly int Year;

        public WorldHolidays(ECulture culture, int year)
        {
            Culture = culture;
            Year = year;
        }

        public IEnumerable<Holiday> Holidays() =>
            new List<Holiday>
            {
#region January

                new Holiday(Year, 01, 01, true, EHolidayName.NewYear.GetDescription(Culture), AllCultures),
                //ES-ES
                new Holiday(Year, 01, 06, true, EHolidayName.Epiphany.GetDescription(Culture), ECulture.esES),

#endregion January

#region February

                //EN-CA
                new Holiday(Year, 02,17, false, EHolidayName.FamilyDay.GetDescription(Culture),ECulture.enCA),
                //PT-BR
                new Holiday(Year, 02,14, false, EHolidayName.ValentineDay.GetDescription(Culture), ValentineDayCulture),
                //EN-US
                new Holiday(Year, 02,17, true, EHolidayName.WashingtonsBirthday.GetDescription(Culture),ECulture.enUS),
                //ES-ES
                new Holiday(Year, 02,28, false, EHolidayName.AndaluciaDay.GetDescription(Culture),ECulture.esES),

#endregion February

#region March

                //EN-CA
                new Holiday(Year, 03,17, false, EHolidayName.StPatrickDay.GetDescription(Culture),ECulture.enCA),
                //PT-BR
                new Holiday(Year, 03,19,
                    false,
                    EHolidayName.SaintJose.GetDescription(Culture),
                    ECulture.ptBR | ECulture.esES),
                new Holiday(Year, 03, 25, false,  EHolidayName.MagnaLetterOfCeara.GetDescription(Culture), ECulture.ptBR),
                //ES-ES
                new Holiday(Year, 03, 01,true, EHolidayName.DayOfIllesBalears.GetDescription(Culture), ECulture.esES),

#endregion March

#region April

                //PT-BR
                new Holiday(Year, 04, 21, true, EHolidayName.Tiradentes.GetDescription(Culture), ECulture.ptBR),
                //ES-PT
                new Holiday(Year, 04, 23, false, EHolidayName.SaintGeorge.GetDescription(Culture), ECulture.ptBR | ECulture.esES),
                //PT-PT
                new Holiday(Year, 04, 25, false, EHolidayName.LibertyDay.GetDescription(Culture), ECulture.ptPT),

#endregion April

#region May

                //EN-CA
                new Holiday(Year, 05, 18, false, EHolidayName.VictoriaDay.GetDescription(Culture),ECulture.enCA),
                //PT-ES
                new Holiday(Year, 05, 01,
                    true,
                    EHolidayName.LabourDay.GetDescription(Culture),
                    CultureptPTES),
                //EN-US
                new Holiday(Year, 05, 25, true, EHolidayName.MemorialDay.GetDescription(Culture),ECulture.enUS),
                //ES-ES
                new Holiday(Year, 05, 15, false, EHolidayName.SanIsidro.GetDescription(Culture),ECulture.esES),
                new Holiday(Year, 05, 30, false, EHolidayName.CanariasDay.GetDescription(Culture),ECulture.esES),

#endregion May

#region June

                //EN-CA
                new Holiday(Year, 06, 21, false, EHolidayName.NationalAboriginalDay.GetDescription(Culture), ECulture.enCA),
                new Holiday(Year, 06, 24, false, EHolidayName.NationalHolidayOfQuebec.GetDescription(Culture), ECulture.enCA),
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
                new Holiday(Year, 06, 13, false, EHolidayName.StAnthonysDay.GetDescription(Culture), ECulture.ptPT),
                //ES-ES
                new Holiday(Year, 06, 09, false,EHolidayName.DayOfMurciaRegion.GetDescription(Culture), ECulture.esES),

#endregion June

#region July

                //EN-CA
                new Holiday(Year, 07, 01, true, EHolidayName.CanadaDay.GetDescription(Culture),ECulture.enCA),
                new Holiday(Year, 07, 09, false, EHolidayName.NunavutDay.GetDescription(Culture),ECulture.enCA),
                //PT-BR
                new Holiday(Year, 07, 02, false, EHolidayName.IndependenceOfBahia.GetDescription(Culture), ECulture.ptBR),
                new Holiday(Year, 07, 09, false, EHolidayName.ConstitutionalistRevolutionOf1932.GetDescription(Culture), ECulture.ptBR),
                //EN-US
                new Holiday(Year, 07, 03, true, EHolidayName.IndependencyDay.GetDescription(Culture), ECulture.enUS),
                new Holiday(Year, 07, 04, true, EHolidayName.IndependencyDay.GetDescription(Culture), ECulture.enUS),
                //ES-ES
                new Holiday(Year, 07, 25, false, EHolidayName.SantiagoApostle.GetDescription(Culture), ECulture.esES),

#endregion July

#region August

                //EN-CA
                new Holiday(Year, 08, 03, false, EHolidayName.AugustCivicHoliday.GetDescription(Culture),ECulture.enCA),
                //PT-ES
                new Holiday(Year, 08, 15,
                            IsPtEs(),
                            EHolidayName.AssumptionOfMaria.GetDescription(Culture),
                            CultureptPTES),

#endregion August

#region September

                //EN
                new Holiday(Year, 09, 07, true, EHolidayName.LabourDay.GetDescription(Culture), EnCulture),
                //PT-BR
                new Holiday(Year, 09, 07, true, EHolidayName.IndependencyDay.GetDescription(Culture), ECulture.ptBR),
                //ES-ES
                new Holiday(Year, 09, 08, false, EHolidayName.DayOfAsturias.GetDescription(Culture), ECulture.esES),
                new Holiday(Year, 09, 11, false, EHolidayName.NationalFiestaOfCatalunia.GetDescription(Culture), ECulture.esES),

#endregion September

#region October

                //EN-CA
                new Holiday(Year, 10, 12, false, EHolidayName.Thanksgiving.GetDescription(Culture), ECulture.enCA),
                //PT-BR
                new Holiday(Year, 10, 12, true, EHolidayName.DayOfAparecida.GetDescription(Culture), ECulture.ptBR),
                //EN-US
                new Holiday(Year, 10, 12, true, EHolidayName.ColumbusDay.GetDescription(Culture), ECulture.enUS),
                //PT-PT
                new Holiday(Year, 10, 05, true, EHolidayName.ImplantationOfRepublic.GetDescription(Culture), ECulture.ptPT),
                //ES-ES
                new Holiday(Year, 10, 09, true, EHolidayName.DayOfValencianCommunity.GetDescription(Culture), ECulture.esES),
                new Holiday(Year, 10, 09, true, EHolidayName.NationalFiestaOfSpain.GetDescription(Culture), ECulture.esES),

#endregion October

#region November #Rain

                //EN-CA
                new Holiday(Year, 11, 11, false, EHolidayName.RemembranceDay.GetDescription(Culture),ECulture.enCA),
                //PT-BR
                new Holiday(Year, 11, 02, true, EHolidayName.DayOfDeads.GetDescription(Culture), ECulture.ptBR),
                new Holiday(Year, 11, 15, true, EHolidayName.ProclamationOfRepublic.GetDescription(Culture), ECulture.ptBR),
                new Holiday(Year, 11, 20, false, EHolidayName.BlackConscienceDay.GetDescription(Culture), ECulture.ptBR),
                // EN-US
                new Holiday(Year, 11, 11, true, EHolidayName.VeteransDay.GetDescription(Culture), ECulture.enUS),
                new Holiday(Year, 11, 26, true, EHolidayName.Thanksgiving.GetDescription(Culture), ECulture.enUS),
                //PT-ES
                new Holiday(Year, 11, 01, true, EHolidayName.AllSaintsDay.GetDescription(Culture), ECulture.ptPT),
                //ES-ES
                new Holiday(Year, 11, 09, true, EHolidayName.VirginOfAlmudena.GetDescription(Culture), ECulture.esES),

#endregion November #Rain

#region December

                // EN-CA
                new Holiday(Year, 12, 26, false, EHolidayName.BoxingDay.GetDescription(Culture), ECulture.enCA),
                //PT-PT
                new Holiday(Year, 12, 01, true, EHolidayName.IndependencyDay.GetDescription(Culture), ECulture.ptPT),
                //PT
                new Holiday(Year, 12, 08,
                            IsPtEs(),
                            EHolidayName.ImmaculateConception.GetDescription(Culture),
                            PtCulture),
                // ALL
                new Holiday(Year, 12, 25, true, EHolidayName.ChristmasDay.GetDescription(Culture), AllCultures),
                // ES-ES
                new Holiday(Year, 12, 06, false, EHolidayName.ConstitutionDay.GetDescription(Culture), ECulture.esES)

#endregion December
            };

        /// <summary>
        /// Determines whether [is pt es].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [is pt es]; otherwise, <c>false</c>.
        /// </returns>
        private bool IsPtEs() =>
            (Culture & CultureptPTES) == Culture;
    }
}