using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFB153E53A3627FDA, NameHash = 0x948E6184)]
    public class GcRewardProceduralProduct : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A OSDMessage;
        [NMS(Index = 5)]
        /* 0x20 */ public int FreighterTechQualityOverride;
        [NMS(Index = 4)]
        /* 0x24 */ public GcRarity Rarity;
        [NMS(Index = 0)]
        /* 0x28 */ public GcProceduralProductCategory Type;
        [NMS(Index = 3)]
        /* 0x2C */ public bool OverrideRarity;
        [NMS(Index = 2)]
        /* 0x2D */ public bool SubIfPlayerAlreadyHasOne;
    }
}
