using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x18)]
    public class SnBroadcastValueDistance : NMSTemplate
    {
        /* 0x0 */ public float Range;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x4 */ public byte[] Padding4;
        [NMS(Size = 0x10)]
        /* 0x8 */ public string Value;
        // OutNode: Unnamed
    }
}
