namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7AFE826662D10562, NameHash = 0x63DAFA0869073279)]
    public class GcAtlasFeaturedBaseStateChange : NMSTemplate
    {
        /* 0x00 */ public NMSString0x40 BaseId;
        /* 0x40 */ public NMSString0x20 Platform;
        /* 0x60 */ public bool Dev;
        /* 0x61 */ public bool Prod;
        /* 0x62 */ public bool QA;
    }
}
