namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x465E44C5E61B503, NameHash = 0x47334DD09E6C3FE9)]
    public class GcSpaceMapObjectData : NMSTemplate
    {
        /* 0x00 */ public Colour Colour;
        /* 0x10 */ public float DistanceMin;
        /* 0x14 */ public float DistanceRange;
        /* 0x18 */ public float Radius;
        /* 0x1C */ public float ScaleMagnitude;
        /* 0x20 */ public float ScaleMin;
        /* 0x24 */ public float ScaleRange;
        /* 0x28 */ public bool Orient;
        /* 0x29 */ public bool TintModel;
    }
}
