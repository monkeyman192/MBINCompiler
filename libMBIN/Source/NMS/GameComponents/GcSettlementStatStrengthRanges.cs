namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAC70928D1A18CD, NameHash = 0xCE277CF591D7A4A9)]
    public class GcSettlementStatStrengthRanges : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int AmountMax;
        [NMS(Index = 0)]
        /* 0x4 */ public int AmountMin;
    }
}
