namespace libMBIN.Models.Structs
{
    public class GcMonth : NMSTemplate
    {
        public int Month;
        public string[] MonthValues()
        {
            return new[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
        }
    }
}
