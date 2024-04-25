using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7EDA19BF35FFE6D2, NameHash = 0xD0ED6D53DE05ABE7)]
    public class GcSettlementStatChange : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcSettlementStatType Stat;
        [NMS(Index = 1)]
        /* 0x4 */ public GcSettlementStatStrength Strength;
    }
}
