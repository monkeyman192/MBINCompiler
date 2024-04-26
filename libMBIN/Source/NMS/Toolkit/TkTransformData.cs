namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x94371FCE320374EC, NameHash = 0x984D549B93F94207)]
    public class TkTransformData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public float RotX;
        [NMS(Index = 4)]
        /* 0x04 */ public float RotY;
        [NMS(Index = 5)]
        /* 0x08 */ public float RotZ;
        [NMS(Index = 6)]
        /* 0x0C */ public float ScaleX;
        [NMS(Index = 7)]
        /* 0x10 */ public float ScaleY;
        [NMS(Index = 8)]
        /* 0x14 */ public float ScaleZ;
        [NMS(Index = 0)]
        /* 0x18 */ public float TransX;
        [NMS(Index = 1)]
        /* 0x1C */ public float TransY;
        [NMS(Index = 2)]
        /* 0x20 */ public float TransZ;
    }
}
