using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xE8, GUID = 0xD6D51C085D901623, NameHash = 0x29C1A8399A70F9A7)]
    public class GcRewardTableEntry : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        public GcRewardTableCategory[] Rarities;
    }
}