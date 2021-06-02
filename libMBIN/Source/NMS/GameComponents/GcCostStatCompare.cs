using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x60, GUID = 0xE4F40DAA66FEC322, NameHash = 0xA889775D93694AA7)]
    public class GcCostStatCompare : NMSTemplate
    {
        public NMSString0x10 CoreStat;
        public NMSString0x10 CompareAndSetStat;
        public NMSString0x20A CostStringCanAfford;
        public NMSString0x20A CostStringCantAfford;
    }
}
