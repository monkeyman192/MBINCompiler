using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x5C2DDDAB461EB03C, NameHash = 0x29C1A8399A70F9A7)]
    public class GcRewardTableEntry : NMSTemplate
    {
        public NMSString0x10 Id;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        public GcRewardTableCategory[] Rarities;
    }
}