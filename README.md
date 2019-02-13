# Verify World Holidays

## Lib to verify holidays around the world.

Supported Locale:
  - pt-Br;
  - en-Us.
  

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
