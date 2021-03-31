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
        /* 0x3C */ public int Unknown; // These last 4 bytes are either a float or an int... Probably part of the curve data
        // IONode: Out: 0: Src, 1: Light, 2: Intensity, 3: Duration
    }
}
