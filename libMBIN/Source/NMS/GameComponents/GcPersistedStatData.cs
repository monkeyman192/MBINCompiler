namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBEDC2ADA39713304, NameHash = 0x8A1BFCC09E50150B)]
    public class GcPersistedStatData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 GroupId;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 StatId;
    }
}
