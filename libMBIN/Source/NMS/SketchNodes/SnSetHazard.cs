using System;
using System.Collections.Generic;
using System.Text;

using libMBIN.NMS.GameComponents;

namespace libMBIN.Source.NMS.SketchNodes
{
    [NMS(Size = 0x8)]
    public class SnSetHazard : NMSTemplate
    {
        /* 0x0 */ public GcPlayerHazardType Hazard;
        /* 0x4 */ public float Strength;
        // OutNode: Unnamed
    }
}
