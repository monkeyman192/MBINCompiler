namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7C56F69C9F135496, NameHash = 0xF6C14CA160DBA9E1)]
    public class GcRewardDummyLocID : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A LocID;
        [NMS(Index = 2)]
        /* 0x20 */ public int AmountMax;
        [NMS(Index = 1)]
        /* 0x24 */ public int AmountMin;
    }
}
