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

        [DescriptionHoliday("New Year", EnCulture)]
        [DescriptionHoliday("Ano Novo", ECulture.ptBR)]
        [DescriptionHoliday("Año Novo", ECulture.esES)]
        NewYear,

        [DescriptionHoliday("Valentine's Day", EnCulture)]
        [DescriptionHoliday("Dia dos Namorados", PtCulture)]
        ValentineDay,

        [DescriptionHoliday("Good Friday", ECulture.enCA)]
        [DescriptionHoliday("Sexta Feira Santa", ECulture.ptBR)]
        [DescriptionHoliday("Viernes Santo", ECulture.esES)]
        GoodFriday,

        [DescriptionHoliday("Quarta Feira de Cinzas", ECulture.ptBR)]
        AshWednesday,

        [DescriptionHoliday("Mardi Grass", ECulture.enUS)]
        [DescriptionHoliday("Carnaval", ECulture.ptBR)]
        MardiGrass,

        [DescriptionHoliday("Corpus Christi", PtCulture)]
        [DescriptionHoliday("Fiesta del Corpus Christi", ECulture.esES)]
        CorpusChristi,

        [DescriptionHoliday("Father's Day", ECulture.enCA)]
        [DescriptionHoliday("Dia dos pais", ECulture.ptBR)]
        FatherDay,

        [DescriptionHoliday("Mother's Day", ECulture.enCA)]
        [DescriptionHoliday("Dia das Mães", PtCulture)]
        MotherDay,

        [DescriptionHoliday("Labour Day", ECulture.enCA)]
        [DescriptionHoliday("Dia do Trabalho", ECulture.ptBR)]
        [DescriptionHoliday("Día del Trabajo", ECulture.esES)]
        LabourDay,

        [DescriptionHoliday("Easter Day", ECulture.enUS)]
        [DescriptionHoliday("Páscoa", ECulture.ptBR)]
        [DescriptionHoliday("Domingo de Resurrección", ECulture.esES)]
        EasterDay,

        [DescriptionHoliday("Easter Monday", ECulture.enCA)]
        [DescriptionHoliday("Segunda-feira de Páscoa", ECulture.ptPT)]
        [DescriptionHoliday("Lunes de Pascua", ECulture.esES)]
        EasterMonday,

        [DescriptionHoliday("Natal", ECulture.ptBR)]
        [DescriptionHoliday("Christma's Day", ECulture.enCA)]
        [DescriptionHoliday("Navidad", ECulture.esES)]
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
        [DescriptionHoliday("Asunción de la Virgen", ECulture.esES)]
        AssumptionOfMaria,

        [DescriptionHoliday("Nossa Senhora da Conceição", ECulture.ptBR)]
        [DescriptionHoliday("Imaculada Conceição", ECulture.ptPT)]
        [DescriptionHoliday("La Inmaculada Concepción", ECulture.esES)]
        ImmaculateConception,

        [DescriptionHoliday("São José", ECulture.ptBR)]
        [DescriptionHoliday("San José", ECulture.esES)]
        SaintJose,

        [DescriptionHoliday("Dia de São Jorge", ECulture.ptBR)]
        [DescriptionHoliday("San Jorge", ECulture.esES)]
        SaintGeorge,

        [DescriptionHoliday("Jueves Santo", ECulture.esES)]
        HolyThursday,

        [DescriptionHoliday("São João", ECulture.ptBR)]
        [DescriptionHoliday("San Juan", ECulture.esES)]
        SanJuan,

        [DescriptionHoliday("Todos os Santos", ECulture.ptPT)]
        [DescriptionHoliday("Fiesta de Todos los Santos", ECulture.esES)]
        AllSaintsDay,
    }
}