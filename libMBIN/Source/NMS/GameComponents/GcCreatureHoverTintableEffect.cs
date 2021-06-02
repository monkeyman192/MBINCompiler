using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x120, Alignment = 0x10, GUID = 0xB54E432D41DB9B3B, NameHash = 0x0FE54641DFEAF51F)]
    public class GcCreatureHoverTintableEffect : NMSTemplate
    {
        /* 0x000 */ public NMSString0x100 EffectNode;
        /* 0x100 */ public float LightStrength;
        /* 0x104 */ public float TintStrength;
        /* 0x110 */ public Colour TintColour;
    }
}
