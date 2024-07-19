namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4E4C2A182B66036A, NameHash = 0x87585BC)]
    public class GcSettlementStatStrengthRanges : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int AmountMax;
        [NMS(Index = 0)]
        /* 0x4 */ public int AmountMin;
    }
}
