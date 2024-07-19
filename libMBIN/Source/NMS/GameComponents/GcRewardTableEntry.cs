using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9AD6A6055C7C5C1D, NameHash = 0xA7CE818B)]
    public class GcRewardTableEntry : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x000 */ public GcRewardTableCategory[] Rarities;
        [NMS(Index = 0)]
        /* 0x168 */ public NMSString0x10 Id;
    }
}
