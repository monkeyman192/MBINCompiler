using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.Source.NMS.SketchNodes
{
    [NMS(Size = 0x38)]
    public class SnFadeMaterials : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Node;
        /* 0x10 */ public float Duration;
        [NMS(Size = 0x24)]
        /* 0x14 */ public byte[] Curve;  // I think this is possibly given to the shaders `gAcesCurveParams`?
    }
}
