using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1E1B78C81F4F7EED, NameHash = 0xE5DC8328938D3562)]
    public class GcClothAttachmentCirlce : NMSTemplate
    {
        /* 0x000 */ public bool Enabled;
        /* 0x001 */ public NMSString0x40 DebugName;
        /* 0x041 */ public NMSString0x40 BoneName;
        /* 0x084 */ public float Radius;
        /* 0x090 */ public Vector3f Center;
        /* 0x0A0 */ public AxisSpecification RightAxis;
        /* 0x0C0 */ public AxisSpecification ForwardAxis;
        /* 0x0E0 */ public AxisSpecification ClothDirection;
        /* 0x100 */ public float StartAngle;
        /* 0x104 */ public float EndAngle;
        /* 0x108 */ public bool WrapIAround;
        /* 0x109 */ public bool WrapJAround;
        /* 0x10C */ public int NumRowsOfSameJToFix;
        /* 0x110 */ public int RowToFixJ;
        /* 0x114 */ public float AttractionStrength;
        /* 0x118 */ public float AttractionStartDistance;
        /* 0x11C */ public float StartIFraction;
        /* 0x120 */ public float EndIFraction;
        /* 0x124 */ public float JStepDistanceOverride;
    }
}
