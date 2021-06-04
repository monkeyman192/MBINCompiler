using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xE8, GUID = 0x785DE0056C134F7, NameHash = 0x29C1A8399A70F9A7)]
    public class GcRewardTableEntry : NMSTemplate
    {
        public NMSString0x10 Id;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        public GcRewardTableCategory[] Rarities;
    }
}