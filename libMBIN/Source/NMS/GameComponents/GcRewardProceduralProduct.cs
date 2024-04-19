using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x27834B15BE89F698, NameHash = 0x28EDE156F726CF4C)]
    public class GcRewardProceduralProduct : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A OSDMessage;
        /* 0x20 */ public int FreighterTechQualityOverride;
        /* 0x24 */ public GcRarity Rarity;
        /* 0x28 */ public GcProceduralProductCategory Type;
        /* 0x2C */ public bool OverrideRarity;
        /* 0x2D */ public bool SubIfPlayerAlreadyHasOne;
    }
}
