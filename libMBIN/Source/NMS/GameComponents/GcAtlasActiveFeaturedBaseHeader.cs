namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8DB16379E37A198F, NameHash = 0x5CA0B64244DF6963)]
    public class GcAtlasActiveFeaturedBaseHeader : NMSTemplate
    {
        /* 0x000 */ public NMSString0x40 BaseId;
        /* 0x040 */ public NMSString0x40 BaseName;
        /* 0x080 */ public NMSString0x40 UA;
        /* 0x0C0 */ public NMSString0x40 UserId;
        /* 0x100 */ public NMSString0x40 UserName;
        /* 0x140 */ public NMSString0x20 Platform;
        /* 0x160 */ public bool Dev;
        /* 0x161 */ public bool Prod;
        /* 0x162 */ public bool QA;
    }
}
