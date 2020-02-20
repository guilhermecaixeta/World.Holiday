using World.Holidays.Attributes;
using static World.Holidays.Enum.Culture;

namespace World.Holidays.Enum
{
    /// <summary>
    /// Generic holiday
    /// </summary>
    public enum EHolidayName
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
        [DescriptionHoliday("Sexta Feira Santa", PtCulture)]
        [DescriptionHoliday("Viernes Santo", ECulture.esES)]
        GoodFriday,

        [DescriptionHoliday("Quarta Feira de Cinzas", ECulture.ptBR)]
        AshWednesday,

        [DescriptionHoliday("Mardi Grass", ECulture.enUS)]
        [DescriptionHoliday("Carnaval", PtCulture)]
        MardiGrass,

        [DescriptionHoliday("Corpus Christi", PtCulture)]
        [DescriptionHoliday("Fiesta del Corpus Christi", ECulture.esES)]
        CorpusChristi,

        [DescriptionHoliday("Father's Day", EnCulture)]
        [DescriptionHoliday("Dia dos pais", ECulture.ptBR)]
        FatherDay,

        [DescriptionHoliday("Mother's Day", EnCulture)]
        [DescriptionHoliday("Dia das Mães", PtCulture)]
        [DescriptionHoliday("Día de la Madre", ECulture.esES)]
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

        [DescriptionHoliday("Restauração da Independência", ECulture.ptPT)]
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

        [DescriptionHoliday("Epifanía / Reyes Magos", ECulture.esES)]
        Epiphany,

        [DescriptionHoliday("Family Day", ECulture.enCA)]
        FamilyDay,

        [DescriptionHoliday("Washington's Birthday", ECulture.enUS)]
        WashingtonsBirthday,

        [DescriptionHoliday("Día de Andalucía", ECulture.esES)]
        AndaluciaDay,

        [DescriptionHoliday("St. Patrick's Day", ECulture.enCA)]
        StPatrickDay,

        [DescriptionHoliday("Data magna do estado do Ceará", ECulture.ptBR)]
        MagnaLetterOfCeara,

        [DescriptionHoliday("Día de las Illes Balears", ECulture.esES)]
        DayOfIllesBalears,

        [DescriptionHoliday("Tiradentes", ECulture.ptBR)]
        Tiradentes,

        [DescriptionHoliday("Dia da Liberdade", ECulture.ptPT)]
        LibertyDay,

        [DescriptionHoliday("Victoria Day", ECulture.enCA)]
        VictoriaDay,

        [DescriptionHoliday("Memorial Day", ECulture.enUS)]
        MemorialDay,

        [DescriptionHoliday("San Isidro", ECulture.esES)]
        SanIsidro,

        [DescriptionHoliday("Día de Canarias", ECulture.esES)]
        CanariasDay,

        [DescriptionHoliday("Dia de Santo António", ECulture.esES)]
        StAnthonysDay,

        [DescriptionHoliday("Día de la Región de Murcia", ECulture.esES)]
        DayOfMurciaRegion,

        [DescriptionHoliday("Santiago Apóstol", ECulture.esES)]
        SantiagoApostle,

        [DescriptionHoliday("Día de Asturias", ECulture.esES)]
        DayOfAsturias,

        [DescriptionHoliday("Día de la Comunidad Valenciana", ECulture.esES)]
        DayOfValencianCommunity,

        [DescriptionHoliday("Virgen de la Almudena", ECulture.esES)]
        VirginOfAlmudena,

        [DescriptionHoliday("Día de la Constitución", ECulture.esES)]
        ConstitutionDay,

        [DescriptionHoliday("Fiesta Nacional de España", ECulture.esES)]
        NationalFiestaOfSpain,

        [DescriptionHoliday("Fiesta Nacional de Cataluña", ECulture.esES)]
        NationalFiestaOfCatalunia,

        [DescriptionHoliday("National Aboriginal Day", ECulture.enCA)]
        NationalAboriginalDay,

        [DescriptionHoliday("National Holiday of Quebec", ECulture.enCA)]
        NationalHolidayOfQuebec,

        [DescriptionHoliday("Canada Day", ECulture.enCA)]
        CanadaDay,

        [DescriptionHoliday("Nunavut Day", ECulture.enCA)]
        NunavutDay,

        [DescriptionHoliday("August Civic Holiday", ECulture.enCA)]
        AugustCivicHoliday,

        [DescriptionHoliday("Remembrance Day", ECulture.enCA)]
        RemembranceDay,

        [DescriptionHoliday("Boxing Day", ECulture.enCA)]
        BoxingDay,

        [DescriptionHoliday("Independência da Bahia (BA)", ECulture.ptBR)]
        IndependenceOfBahia,

        [DescriptionHoliday("Revolução Constitucionalista de 1932 (SP)", ECulture.ptBR)]
        ConstitutionalistRevolutionOf1932,

        [DescriptionHoliday("Nossa Senhora Aparecida", ECulture.ptBR)]
        DayOfAparecida,

        [DescriptionHoliday("Dia dos finados", ECulture.ptBR)]
        DayOfDeads,

        [DescriptionHoliday("Proclamação da República", ECulture.ptBR)]
        ProclamationOfRepublic,

        [DescriptionHoliday("Dia da Consciência Negra", ECulture.ptBR)]
        BlackConscienceDay,

        [DescriptionHoliday("Implantação da República", ECulture.ptPT)]
        ImplantationOfRepublic,

        [DescriptionHoliday("Columbus Day", ECulture.enUS)]
        ColumbusDay,

        [DescriptionHoliday("Veterans Day", ECulture.enUS)]
        VeteransDay,
    }
}