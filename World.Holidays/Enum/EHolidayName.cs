using World.Holidays.Attributes;
using static World.Holidays.Enum.Culture;

namespace World.Holidays.Enum
{
    /// <summary>
    /// Generic holiday
    /// </summary>
    internal enum EHolidayName
    {
        None,

        [DescriptionHoliday("New Year", ECulture.enCA)]
        [DescriptionHoliday("Ano Novo", ECulture.ptBR)]
        NewYear,

        [DescriptionHoliday("Valentine's Day", EnCulture)]
        [DescriptionHoliday("Dia dos Namorados", PtCulture)]
        ValentineDay,

        [DescriptionHoliday("Good Friday", ECulture.enCA)]
        [DescriptionHoliday("Sexta Feira Santa", ECulture.ptBR)]
        GoodFriday,

        [DescriptionHoliday("Quarta Feira de Cinzas", ECulture.ptBR)]
        AshWednesday,

        [DescriptionHoliday("Mardi Grass", ECulture.enUS)]
        [DescriptionHoliday("Carnaval", ECulture.ptBR)]
        MardiGrass,

        [DescriptionHoliday("Corpus Christi", PtCulture)]
        CorpusChristi,

        [DescriptionHoliday("Father's Day", ECulture.enCA)]
        [DescriptionHoliday("Dia dos pais", ECulture.ptBR)]
        FatherDay,

        [DescriptionHoliday("Mother's Day", ECulture.enCA)]
        [DescriptionHoliday("Dia das Mães", PtCulture)]
        MotherDay,

        [DescriptionHoliday("Labour Day", ECulture.enCA)]
        [DescriptionHoliday("Dia do Trabalho", ECulture.ptBR)]
        LabourDay,

        [DescriptionHoliday("Easter Day", ECulture.enUS)]
        [DescriptionHoliday("Páscoa", ECulture.ptBR)]
        EasterDay,

        [DescriptionHoliday("Easter Monday", ECulture.enCA)]
        [DescriptionHoliday("Segunda-feira de Páscoa", ECulture.ptPT)]
        EasterMonday,

        [DescriptionHoliday("Christma's Day", ECulture.enCA)]
        [DescriptionHoliday("Natal", ECulture.ptBR)]
        ChristmasDay,

        [DescriptionHoliday("Independência do Brasil", ECulture.ptBR)]
        [DescriptionHoliday("Independence Day", ECulture.enUS)]
        IndependencyDay,

        [DescriptionHoliday("Thanksgiving", EnCulture)]
        Thanksgiving,

        [DescriptionHoliday("Quinta-feira da Ascensão", ECulture.ptPT)]
        AscensionThursday,

        [DescriptionHoliday("Nossa Senhora da Assunção", ECulture.ptBR)]
        [DescriptionHoliday("Assunção de Maria", ECulture.ptPT)]
        AssumptionOfMaria,

        [DescriptionHoliday("Nossa Senhora da Conceição", ECulture.ptBR)]
        [DescriptionHoliday("Imaculada Conceição", ECulture.ptPT)]
        ImmaculateConception,
    }
}