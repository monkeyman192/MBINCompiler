using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x18)]
    public class SnBroadcastValueDistance : NMSTemplate
    {
        /* 0x0 */ public float Range;
        /* 0x8 */ public NMSString0x10 Value;
        // IONode: Out: 0: Src, 1: Range, 2: Value
    }
}
