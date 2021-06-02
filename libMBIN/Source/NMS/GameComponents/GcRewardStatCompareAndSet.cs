using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x8BC8F6B78C4BDE3B, NameHash = 0x63E76E3324C90001)]
    public class GcRewardStatCompareAndSet : NMSTemplate
    {
        public NMSString0x10 CoreStat;
        public NMSString0x10 CompareAndSetStat;
    }
}