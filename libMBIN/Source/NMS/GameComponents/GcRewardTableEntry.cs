using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC2451A8F8C2F8AAA, NameHash = 0xA7CE818B)]
    public class GcRewardTableEntry : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x000 */ public GcRewardTableCategory[] Rarities;
        [NMS(Index = 0)]
        /* 0x168 */ public NMSString0x10 Id;
    }
}
