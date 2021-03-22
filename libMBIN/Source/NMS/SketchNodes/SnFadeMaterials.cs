using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x38)]
    public class SnFadeMaterials : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Node;
        /* 0x10 */ public float Duration;
        /* 0x14 */ public SnCurve Curve;
    }
}
