namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB4C48BE64AF7293A, NameHash = 0x9FD0B195)]
    public class GcSpaceMapObjectData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public Colour Colour;
        [NMS(Index = 3)]
        /* 0x10 */ public float DistanceMin;
        [NMS(Index = 4)]
        /* 0x14 */ public float DistanceRange;
        [NMS(Index = 2)]
        /* 0x18 */ public float Radius;
        [NMS(Index = 6)]
        /* 0x1C */ public float ScaleMagnitude;
        [NMS(Index = 7)]
        /* 0x20 */ public float ScaleMin;
        [NMS(Index = 5)]
        /* 0x24 */ public float ScaleRange;
        [NMS(Index = 8)]
        /* 0x28 */ public bool Orient;
        [NMS(Index = 1)]
        /* 0x29 */ public bool TintModel;
    }
}
