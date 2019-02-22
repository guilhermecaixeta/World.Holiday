# Verify World Holidays

## Lib to verify holidays around the world.

Supported Locale:
  - pt-Br:
    - Holidays:
      * Natal;
      * Ano Novo;
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
      * Christmas;
      * New Year's Day;
      * Birthday of Martin Luther King Jr.;
      * Valentine's Day;
      * Washington's Birthday;
      * Memorial Day;
      * Independence Day;
      * Columbus Day;
      * Veterans Day;
      * Thanksgiving Day.
        
        
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
