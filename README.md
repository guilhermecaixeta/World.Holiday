# Verify World Holidays

## Lib to verify holidays around the world.

Supported Locale:
  - pt-Br;
  - en-Us.

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
## Status Unit Test on Travis CI 

[![Build Status](https://travis-ci.org/guilhermecaixeta/VerifyWorldHolidays.svg?branch=master)](https://travis-ci.org/guilhermecaixeta/VerifyWorldHolidays)
