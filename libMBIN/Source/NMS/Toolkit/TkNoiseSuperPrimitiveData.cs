namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x779B95C2C839C674, NameHash = 0x19AC3974)]
    public class TkNoiseSuperPrimitiveData : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public float BottomRadiusOffset;
        [NMS(Index = 4)]
        /* 0x04 */ public float CornerRadiusXY;
        [NMS(Index = 5)]
        /* 0x08 */ public float CornerRadiusZ;
        [NMS(Index = 2)]
        /* 0x0C */ public float Depth;
        [NMS(Index = 1)]
        /* 0x10 */ public float Height;
        [NMS(Index = 3)]
        /* 0x14 */ public float Thickness;
        [NMS(Index = 0)]
        /* 0x18 */ public float Width;
    }
}
