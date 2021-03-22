using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x40)]
    public class SnSetLightIntensity : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Light;
        /* 0x10 */ public float Intensity;
        /* 0x14 */ public float Duration;
        /* 0x18 */ public SnCurve Curve;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x3C */ public byte[] EndPadding;
    }
}
