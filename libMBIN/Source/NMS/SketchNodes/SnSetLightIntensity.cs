using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x40)]
    class SnSetLightIntensity
    {
        /* 0x00 */ public NMSString0x10 Light;
        /* 0x10 */ public float Intensity;
        /* 0x14 */ public float Duration;
        /* 0x18 */ public byte Curve;  // dummy data type for now...
        // The next 0x28 bytes... not sure...
    }
}
