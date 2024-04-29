namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5AA132559917B614, NameHash = 0x63DAFA0869073279)]
    public class GcAtlasFeaturedBaseStateChange : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public NMSString0x40 BaseId;
        [NMS(Index = 3)]
        /* 0x40 */ public NMSString0x20 Platform;
        [NMS(Index = 0)]
        /* 0x60 */ public bool Dev;
        [NMS(Index = 2)]
        /* 0x61 */ public bool Prod;
        [NMS(Index = 1)]
        /* 0x62 */ public bool QA;
    }
}
