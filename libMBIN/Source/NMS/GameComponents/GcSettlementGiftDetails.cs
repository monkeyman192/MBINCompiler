namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB573DB7C869A704C, NameHash = 0x8D4F825AF192C1DF)]
    public class GcSettlementGiftDetails : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A LocID;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 Reward;
    }
}
