using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x48)]
    public class SnTranslateNode : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Node;
        /* 0x10 */ public SnVector3f Translation;
        /* 0x1C */ public float Duration;
        /* 0x20 */ public SnCurve Curve;
        /* 0x44 */ public int Unknown;  // Most likely part of the preceeding curve data
        // IONode: 0: Src, 1: Node, 2: Duration
    }
}
