namespace libMBIN.Models.Structs
{
    public class GcDay : NMSTemplate
    {
        public int Day;
        public string[] DayValues()
        {
            return new[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        }
    }
}
