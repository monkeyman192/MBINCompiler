namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x5D44992908864ABF, NameHash = 0xC299E896)]
    public class TkEntitlementListData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 EntitlementId;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x40 ServiceID;
    }
}
