using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB2F641936A06CD48, NameHash = 0xD0ED6D53DE05ABE7)]
    public class GcSettlementStatChange : NMSTemplate
    {
        /* 0x0 */ public GcSettlementStatType Stat;
        /* 0x4 */ public GcSettlementStatStrength Strength;
    }
}
