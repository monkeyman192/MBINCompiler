using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x1CD6DCBB1281E502, NameHash = 0x29C1A8399A70F9A7)]
    public class GcRewardTableEntry : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        public GcRewardTableCategory[] Rarities;
    }
}
