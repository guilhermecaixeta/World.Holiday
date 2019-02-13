using System;
using HoliDayDate.Entity;
using HoliDayDate.Locale.CommomMethod;

namespace HoliDayDate.Locale
{
    public static class HolidaysPtBr 
    {
        private static DateTimeHoliday dateReturn = new DateTimeHoliday(new DateTime(), false, "");
        private const int _numberOfSunday = 2;
        public static DateTimeHoliday VerifyHolidaysPtBr(this DateTime date)
        {
            date.CalculateMobileHolidays();
            switch (date.Month)
            {
                case 2:
                    if (date.IsCarnaval())
                    {
                        dateReturn = date.ReturnNewDateType(true, "Carnaval");
                    }
                    break;
                case 3:
                    if (date.IsCarnaval())
                        dateReturn = date.ReturnNewDateType(true, "Carnaval");
                    else if (date.IsSextaSanta())
                        dateReturn = date.ReturnNewDateType(true, "Sexta-Feira Santa");
                    else if (date.Day >= 22 && date.IsEasterDate())
                        dateReturn = date.ReturnNewDateType(true, "Páscoa");
                    break;
                case 4:
                    if (date.Day == 21)
                        dateReturn = date.ReturnNewDateType(true, "Tiradentes");
                    else if (date.IsSextaSanta())
                        dateReturn = date.ReturnNewDateType(true, "Sexta-Feira Santa");
                    else if (date.IsEasterDate())
                        dateReturn = date.ReturnNewDateType(true, "Páscoa");

                    break;
                case 5:
                    if (date.Day == 1)
                        dateReturn = date.ReturnNewDateType(true, "Dia do Trabalhador");
                    else if (date.IsAFatherOrMotherDay(_numberOfSunday, DayOfWeek.Sunday))
                        dateReturn = date.ReturnNewDateType(true, "Dia das Mães");
                    else if (date.IsCorpusCristi())
                        dateReturn = date.ReturnNewDateType(true, "Corpus Cristi");
                    break;
                case 6:
                    if (date.IsCorpusCristi())
                        dateReturn = date.ReturnNewDateType(true, "Corpus Cristi");
                    else if (date.Day.Equals(24))
                        dateReturn = date.ReturnNewDateType(true, "São João");
                    break;
                case 8:
                    if (date.IsAFatherOrMotherDay(_numberOfSunday, DayOfWeek.Sunday))
                        dateReturn = date.ReturnNewDateType(true, "Dia dos Pais");
                    break;
                case 9:
                    if (date.Day.Equals(7))
                        dateReturn = date.ReturnNewDateType(true, "Independência do Brasil");
                    break;
                case 10:
                    if (date.Day.Equals(12))
                        dateReturn = date.ReturnNewDateType(true, "Dia das Crianças");
                    break;
                case 11:
                    if (date.Day.Equals(2))
                        dateReturn = date.ReturnNewDateType(true, "Dia de Finados");
                    else if (date.Day.Equals(15))
                        dateReturn = date.ReturnNewDateType(true, "Proclamação da República");
                    else if (date.Day.Equals(20))
                        dateReturn = date.ReturnNewDateType(true, "Dia da Consciência Negra");
                    break;
            }
            return dateReturn;
        }

        private static bool IsCarnaval(this DateTime date) => CommomMethod.CommomMethod.EasterDate().AddDays(-47).Date.Equals(date.Date);
        private static bool IsQuartaCinza(this DateTime date) => CommomMethod.CommomMethod.EasterDate().AddDays(-46).Date.Equals(date.Date);
        private static bool IsSextaSanta(this DateTime date) => CommomMethod.CommomMethod.EasterDate().AddDays(-2).Date.Equals(date.Date);
        private static bool IsCorpusCristi(this DateTime date) => CommomMethod.CommomMethod.EasterDate().AddDays(60).Date.Equals(date.Date);
    }
}
