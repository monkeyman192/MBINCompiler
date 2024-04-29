using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4FDEB7031FCEE86D, NameHash = 0x29C1A8399A70F9A7)]
    public class GcRewardTableEntry : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x000 */ public GcRewardTableCategory[] Rarities;
        [NMS(Index = 0)]
        /* 0x168 */ public NMSString0x10 Id;
    }
}
