using System;
using System.Collections.Generic;
using System.Text;

using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0xC)]
    public class SnSetHazard : NMSTemplate
    {
        /* 0x0 */ public GcPlayerHazardType Hazard;
        /* 0x4 */ public float Duration;
        /* 0x8 */ public float Strength;
        // IONode: Out: 0: Src, 1: Duration, 2: Strength
    }
}
