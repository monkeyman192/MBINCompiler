namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5A71E592A520DD3C, NameHash = 0xDA00E84E26C162C5)]
    public class GcMetaBallComponentData : NMSTemplate
    {
        /* 0x00 */ public Vector3f MaxSize;
        /* 0x10 */ public Vector3f MinSize;
        /* 0x20 */ public float Radius;
        /* 0x24 */ public NMSString0x80 File;
        /* 0xA4 */ public NMSString0x20 Root;
    }
}
