using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x22A3925ECEBE9AB2, NameHash = 0xE5DC8328938D3562)]
    public class GcClothAttachmentCirlce : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x000 */ public AxisSpecification ClothDirection;
        [NMS(Index = 6)]
        /* 0x020 */ public AxisSpecification ForwardAxis;
        [NMS(Index = 5)]
        /* 0x040 */ public AxisSpecification RightAxis;
        [NMS(Index = 4)]
        /* 0x060 */ public Vector3f Center;
        [NMS(Index = 15)]
        /* 0x070 */ public float AttractionStartDistance;
        [NMS(Index = 14)]
        /* 0x074 */ public float AttractionStrength;
        [NMS(Index = 9)]
        /* 0x078 */ public float EndAngle;
        [NMS(Index = 17)]
        /* 0x07C */ public float EndIFraction;
        [NMS(Index = 18)]
        /* 0x080 */ public float JStepDistanceOverride;
        [NMS(Index = 12)]
        /* 0x084 */ public int NumRowsOfSameJToFix;
        [NMS(Index = 3)]
        /* 0x088 */ public float Radius;
        [NMS(Index = 13)]
        /* 0x08C */ public int RowToFixJ;
        [NMS(Index = 8)]
        /* 0x090 */ public float StartAngle;
        [NMS(Index = 16)]
        /* 0x094 */ public float StartIFraction;
        [NMS(Index = 2)]
        /* 0x098 */ public NMSString0x40 BoneName;
        [NMS(Index = 1)]
        /* 0x0D8 */ public NMSString0x40 DebugName;
        [NMS(Index = 0)]
        /* 0x118 */ public bool Enabled;
        [NMS(Index = 10)]
        /* 0x119 */ public bool WrapIAround;
        [NMS(Index = 11)]
        /* 0x11A */ public bool WrapJAround;
    }
}
