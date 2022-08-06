using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x242A3E10465691CB, NameHash = 0x28EDE156F726CF4C)]
    public class GcRewardProceduralProduct : NMSTemplate
    {
        /* 0x00 */ public GcProceduralProductCategory Type;
        /* 0x08 */ public NMSString0x20A OSDMessage;
        /* 0x28 */ public bool SubIfPlayerAlreadyHasOne;
        /* 0x29 */ public bool OverrideRarity;
        /* 0x2C */ public GcRarity Rarity;
    }
}
