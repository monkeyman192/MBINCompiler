using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAB48D75ECDC867E9, NameHash = 0xDEF97AA1BA31BC2A)]
    public class GcCostProductOnlyTakeIfCanAfford : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x20A AltCostLocID;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x10 Id;
        [NMS(Index = 2)]
        /* 0x30 */ public int Amount;
        [NMS(Index = 0)]
        /* 0x34 */ public GcDefaultMissionProductEnum Default;
    }
}
