using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x22A3925ECEBE9AB2, NameHash = 0xE5DC8328938D3562)]
    public class GcClothAttachmentCirlce : NMSTemplate
    {
        /* 0x000 */ public AxisSpecification ClothDirection;
        /* 0x020 */ public AxisSpecification ForwardAxis;
        /* 0x040 */ public AxisSpecification RightAxis;
        /* 0x060 */ public Vector3f Center;
        /* 0x070 */ public float AttractionStartDistance;
        /* 0x074 */ public float AttractionStrength;
        /* 0x078 */ public float EndAngle;
        /* 0x07C */ public float EndIFraction;
        /* 0x080 */ public float JStepDistanceOverride;
        /* 0x084 */ public int NumRowsOfSameJToFix;
        /* 0x088 */ public float Radius;
        /* 0x08C */ public int RowToFixJ;
        /* 0x090 */ public float StartAngle;
        /* 0x094 */ public float StartIFraction;
        /* 0x098 */ public NMSString0x40 BoneName;
        /* 0x0D8 */ public NMSString0x40 DebugName;
        /* 0x118 */ public bool Enabled;
        /* 0x119 */ public bool WrapIAround;
        /* 0x11A */ public bool WrapJAround;
    }
}
