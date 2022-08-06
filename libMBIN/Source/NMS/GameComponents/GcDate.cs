using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x84C13BF671FD2DBE, NameHash = 0x806D452BB139AB67)]
    public class GcDate : NMSTemplate
    {
        public int Minute;
        public int Hour;
        public int Day;
        public GcMonth Month;
        public int Year;
    }
}