using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x23173FB1859FA0EB, NameHash = 0xA77CF40D)]
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
