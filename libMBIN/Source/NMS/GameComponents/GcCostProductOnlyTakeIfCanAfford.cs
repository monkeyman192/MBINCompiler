using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6375DE27340DF292, NameHash = 0xDEF97AA1BA31BC2A)]
    public class GcCostProductOnlyTakeIfCanAfford : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A AltCostLocID;
        /* 0x20 */ public NMSString0x10 Id;
        /* 0x30 */ public int Amount;
        /* 0x34 */ public GcDefaultMissionProductEnum Default;
    }
}
