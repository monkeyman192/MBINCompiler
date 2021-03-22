using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x48)]
    public class SnScaleNode : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Node;
        /* 0x10 */ public SnVector3f Scale;
        /* 0x1C */ public float Duration;
        /* 0x20 */ public SnCurve Curve;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x44 */ public byte[] EndPadding;
    }
}
