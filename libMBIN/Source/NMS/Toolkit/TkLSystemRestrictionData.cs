using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x73A9CDAF4AF83232, NameHash = 0x2CE937F1C349DD12)]
    public class TkLSystemRestrictionData : NMSTemplate
    {
        public int Amount;
		public enum RestrictionEnum { NoMoreThan, AtLeast, AtLeastIfICan }
		public RestrictionEnum Restriction;
    }
}
