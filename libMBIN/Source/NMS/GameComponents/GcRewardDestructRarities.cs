using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x13704FCAD33389EA, NameHash = 0x72703AC399E3162F)]
    public class GcRewardDestructRarities : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x0 */ public GcRewardDestructEntry[] Rarities;
    }
}
