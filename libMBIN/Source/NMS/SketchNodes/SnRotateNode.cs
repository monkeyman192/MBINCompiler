using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.Source.NMS.SketchNodes
{
    [NMS(Size = 0x48)]
    public class SnRotateNode : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Node;
        /* 0x10 */ public float RotationX;
        /* 0x14 */ public float RotationY;
        /* 0x18 */ public float RotationZ;
        /* 0x1C */ public float Duration;
        [NMS(Size = 0x24)]
        /* 0x20 */ public byte[] Curve;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x44 */ public byte[] EndPadding;
    }
}
