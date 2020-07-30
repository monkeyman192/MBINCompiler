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
        [NMS(Size = 0x24)]
        /* 0x18 */ public byte[] Curve;  // dummy data type for now... This actually looks like a list of ushorts
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x3C */ public byte[] EndPadding;
    }
}
