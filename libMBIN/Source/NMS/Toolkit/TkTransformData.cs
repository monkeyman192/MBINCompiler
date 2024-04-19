namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x94371FCE320374EC, NameHash = 0x984D549B93F94207)]
    public class TkTransformData : NMSTemplate
    {
        /* 0x00 */ public float RotX;
        /* 0x04 */ public float RotY;
        /* 0x08 */ public float RotZ;
        /* 0x0C */ public float ScaleX;
        /* 0x10 */ public float ScaleY;
        /* 0x14 */ public float ScaleZ;
        /* 0x18 */ public float TransX;
        /* 0x1C */ public float TransY;
        /* 0x20 */ public float TransZ;
    }
}
