using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcDate : NMSTemplate
    {
        public int Minute;
        public int Hour;
        public int Day;
        public GcMonth Month;
        public int Year;
    }
}
