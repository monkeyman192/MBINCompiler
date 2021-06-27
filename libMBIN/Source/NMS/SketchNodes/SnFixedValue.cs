using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x10)]
    public class SnFixedValue : NMSTemplate
    {
        /* 0x0 */ public NMSString0x10 Value;
        // IONode: Out: 0: Src; In: 0: Value
    }
}
