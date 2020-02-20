# Verify World Holidays

## Overview

This package check if the date informed is a holiday, and returning a DateTimeHoliday as response.
Currently this package support the cultures:

* pt-BR
* pt-PT
* en-US
* en-CA (All holidays are in English)
* es-ES

## Improvements for new version

### 1.0.1
  For this version some improvements was make. They are:
  * Upgrade to asp.net standard 2.1
  * Package was re-writed with the focus to improving performacing, currently this new version are almost 3x times than faster than backward.
  * Add support to new countries: Spain and Canada
  * Add code quality
  * Add cake support to automate the pipeline
  * Add new extension methods to get holidays, in intervel and from the currently date
  * Add new exceptions 
  * Add unity tests
  * The package it's did restructured to support more than one holiday per day
  * the Locale has been changed to ECulture
  * The name of holidays can e accessed in EHolidaysName
  * If one day has more than one holiday, the names of all holidays could be accessed in:
    ```
    "DateTimeHoliday":{
      "HolidayName":[
        values....
      ]
    }
    ```

## Holidays
Holidays in each culture:
  - World Holidays
      * Christmas;
      * New Year's Day;
      * Valentine's Day;
  - pt-Br:
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
      * Birthday of Martin Luther King Jr.;
      * Washington's Birthday;
      * Memorial Day;
      * Independence Day;
      * Columbus Day;
      * Veterans Day;
      * Thanksgiving Day.
  - pt-Pt:
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
  - en-CA and es-ES:
      * You will can find all the holidays that are in this package by the link: [Feriados do Mundo](https://feriados-do-mundo.com.br/)

```
...some logic
var dataHoliday = new DateTime().IsHoliday(ECulture.ptBR);

/*
Returning JSON like this
{
  "Date": "2019-03-05T00:00:00",
  "IsHoliday": true,
  "NameHoliday": 
  [
    "Some holiday..."
  ]
}
*/
```
### Last considerations

This package has been made with the purpose help in the development based in the .net framework/core environment
If you find an error in this package open an issue this help me to improve the package.
If you want add new Culture in this project fell free to join to me, open a PR and start to contribute.

## Status

### Git Actions
![ASP.NET Core CI](https://github.com/guilhermecaixeta/World.Holiday/workflows/ASP.NET%20Core%20CI/badge.svg?branch=master)

### Travis CI
[![Build Status](https://travis-ci.org/guilhermecaixeta/World.Holiday.svg?branch=master)](https://travis-ci.org/guilhermecaixeta/World.Holiday)

### AppVeyor
[![Build status](https://ci.appveyor.com/api/projects/status/rs5ranyllu0g9h08?svg=true)](https://ci.appveyor.com/project/guilhermecaixeta/world-holiday)

### Code Quality
[![Codacy Badge](https://api.codacy.com/project/badge/Grade/a07c597ca4864152ae6bbb88ecb15ada)](https://www.codacy.com/manual/guilhermecaixeta/World.Holiday?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=guilhermecaixeta/World.Holiday&amp;utm_campaign=Badge_Grade)
