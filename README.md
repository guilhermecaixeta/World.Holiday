# Verify World Holidays

## Lib to verify holidays around the world.

Supported Locale:
  - World Holidays (Always verfied)
    - Holidays:
      * Christmas;
      * New Year's Day;
      * Valentine's Day (Except when locale is pt-Br).
  - pt-Br:
    - Holidays:
      * Carnaval;
      * Sexta-Feira Santa;
      * Páscoa;
      * Tiradentes;
      * Dia do trabalhador;
      * Dia das mães;
      * Corpus Cristi;
      * São joão;
      * Dia dos pais;
      * Independência do Brasil;
      * Dia das Crianças;
      * Dia de Finados;
      * Proclamação da República;
      * Dia da Consciência Negra.      
  - en-Us:
    - Holidays:
      * Birthday of Martin Luther King Jr.;
      * Washington's Birthday;
      * Memorial Day;
      * Independence Day;
      * Columbus Day;
      * Veterans Day;
      * Thanksgiving Day.
  - pt-Pt:
    - Holidays:
      *	Carnaval
      *	Sexta-Feira Santa 
      *	Páscoa 
      *	Dia da Liberdade
      *	Dia do Trabalhador 
      *	Dia das Mães 
      *	Dia de Portugal
      *	Corpo de Deus 
      *	Assunção de Maria
      *	Implantação da República
      *	Todos os Santos
      *	Restauração da Independência
      *	Imaculada Conceição
        
        
Access to repository [here](https://github.com/guilhermecaixeta/VerifyWorldHolidays)

This project was initiated like a open-project to be improved by community.
How to use this project:

```
...some logic
var dataHoliday = new DateTime(2019, 12, 25).TodayIsAHoliday(LocaleHoliday.ptBr);

/*
Returning JSON like this
{
  "date": "2019-03-05T00:00:00",
  "isHoliday": true,
  "nameHoliday": "Carnaval"
}
*/
```


## Status unity test on Travis 

[![Build Status](https://travis-ci.org/guilhermecaixeta/World.Holiday.DotNetCore2.2.svg?branch=master)](https://travis-ci.org/guilhermecaixeta/World.Holiday.DotNetCore2.2)
