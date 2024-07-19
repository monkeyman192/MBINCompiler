using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5CEBF4D2B9D73F1A, NameHash = 0x4A0C79E6)]
    public class GcSettlementJobDetails : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A InTextTitle;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x20A PerkTitle;
        [NMS(Index = 2)]
        /* 0x40 */ public GcSettlementStatType Stat;
    }
}
