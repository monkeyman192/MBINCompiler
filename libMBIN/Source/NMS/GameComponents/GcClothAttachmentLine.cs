using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4844D541F8886BBE, NameHash = 0x44CED54C76C8DDA0)]
    public class GcClothAttachmentLine : NMSTemplate
    {
        /* 0x00 */ public bool Enabled;
        /* 0x01 */ public NMSString0x40 DebugName;
        /* 0x41 */ public NMSString0x40 BoneName;
        /* 0x90 */ public Vector3f Start;
        /* 0xA0 */ public Vector3f End;
        /* 0xB0 */ public AxisSpecification ClothDirection;
        /* 0xD0 */ public int NumRowsOfSameJToFix;
        /* 0xD4 */ public int RowToFixJ;
        /* 0xD8 */ public float AttractionStrength;
        /* 0xDC */ public float AttractionStartDistance;
        /* 0xE0 */ public float StartIFraction;
        /* 0xE4 */ public float EndIFraction;
        /* 0xE8 */ public float JStepDistanceOverride;
    }
}
