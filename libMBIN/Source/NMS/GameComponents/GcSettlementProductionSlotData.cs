namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x355BA0DF50A5EAA2, NameHash = 0xB7360AAB256AE198)]
    public class GcSettlementProductionSlotData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ElementId;
        [NMS(Index = 1)]
        /* 0x10 */ public ulong LastChangeTimestamp;
        [NMS(Index = 2)]
        /* 0x18 */ public int Amount;
    }
}
