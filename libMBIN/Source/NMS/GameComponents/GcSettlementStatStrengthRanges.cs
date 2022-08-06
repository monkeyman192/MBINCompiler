using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC1EDC405BF068BE2, NameHash = 0xCE277CF591D7A4A9)]
    public class GcSettlementStatStrengthRanges : NMSTemplate
    {
        /* 0x0 */ public int AmountMin;
        /* 0x4 */ public int AmountMax;
    }
}
