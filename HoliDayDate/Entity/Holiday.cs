namespace HoliDayDate.Entity
{
    public class Holiday
    {
        public bool isHoliday { get; private set; }
        public string nameHoliday { get; private set; }

        public Holiday(string nameHoliday)
        {
            this.isHoliday = true;
            this.nameHoliday = nameHoliday;
        }
    }
}