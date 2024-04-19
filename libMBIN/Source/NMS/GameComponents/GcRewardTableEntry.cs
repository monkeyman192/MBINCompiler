using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCA2EE9F8D6F60F67, NameHash = 0x29C1A8399A70F9A7)]
    public class GcRewardTableEntry : NMSTemplate
    {
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x000 */ public GcRewardTableCategory[] Rarities;
        /* 0x168 */ public NMSString0x10 Id;
    }
}
