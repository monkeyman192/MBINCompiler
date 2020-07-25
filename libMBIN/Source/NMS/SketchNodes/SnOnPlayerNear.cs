using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.Source.NMS.SketchNodes
{
    [NMS(Size = 0x8)]
    class SnOnPlayerNear
    {
        /* 0x0 */ public float Distance;
        /* 0x4 */ public bool IsNear;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x5 */ public byte[] EndPadding;
    }
}
