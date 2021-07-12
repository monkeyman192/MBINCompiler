using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x48)]
    public class SnScaleNode : NMSTemplate
    {
        /* 0x00 */ public SnNMSString0x10 Node;
        /* 0x10 */ public SnVector3f Scale;
        /* 0x1C */ public float Duration;
        /* 0x20 */ public SnCurve Curve;
        /* 0x44 */ public float Unknown;  // Probably part of the preceeding SnCurve data
        // IONode: Out: 0: Src, 1: Node, 2: Duration
    }
}
