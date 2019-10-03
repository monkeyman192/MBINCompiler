using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x60, GUID = 0xE4F40DAA66FEC322, NameHash = 0xA889775D93694AA7)]
    public class GcCostStatCompare : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string CoreStat;
        [NMS(Size = 0x10)]
        public string CompareAndSetStat;
        [NMS(Size = 0x20)]
        public string CostStringCanAfford;
        [NMS(Size = 0x20)]
        public string CostStringCantAfford;
    }
}
