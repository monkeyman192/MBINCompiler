using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB0922669440C8C27, NameHash = 0xDB7A6AA2)]
    public class GcSettlementStatChange : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcSettlementStatType Stat;
        [NMS(Index = 1)]
        /* 0x4 */ public GcSettlementStatStrength Strength;
    }
}
