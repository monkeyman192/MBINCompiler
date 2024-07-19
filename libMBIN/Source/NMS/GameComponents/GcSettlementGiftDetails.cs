namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE6CFC09E0E552FDA, NameHash = 0x67E77B0A)]
    public class GcSettlementGiftDetails : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A LocID;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 Reward;
    }
}
