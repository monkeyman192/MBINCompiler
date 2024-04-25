namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8DB16379E37A198F, NameHash = 0x5CA0B64244DF6963)]
    public class GcAtlasActiveFeaturedBaseHeader : NMSTemplate
    {
        [NMS(Index = 8)]
        /* 0x000 */ public NMSString0x40 BaseId;
        [NMS(Index = 6)]
        /* 0x040 */ public NMSString0x40 BaseName;
        [NMS(Index = 7)]
        /* 0x080 */ public NMSString0x40 UA;
        [NMS(Index = 4)]
        /* 0x0C0 */ public NMSString0x40 UserId;
        [NMS(Index = 5)]
        /* 0x100 */ public NMSString0x40 UserName;
        [NMS(Index = 3)]
        /* 0x140 */ public NMSString0x20 Platform;
        [NMS(Index = 0)]
        /* 0x160 */ public bool Dev;
        [NMS(Index = 2)]
        /* 0x161 */ public bool Prod;
        [NMS(Index = 1)]
        /* 0x162 */ public bool QA;
    }
}
