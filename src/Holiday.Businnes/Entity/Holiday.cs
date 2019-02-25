namespace HoliDayDate.Entity {
    public class HolidayDate {
        public bool isHoliday { get; private set; }
        public string nameHoliday { get; private set; }

        public HolidayDate (string nameHoliday, bool isHoliday) {
            this.isHoliday = isHoliday;
            this.nameHoliday = nameHoliday;
        }
    }
}