using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x925B3E4BFE31CAB9, NameHash = 0x498BE03D1C172203)]
    public class GcMonth : NMSTemplate
    {
		public enum MonthEnum { January, February, March, April, May, June, July, August, September, October, November, December }
		public MonthEnum Month;
    }
}
