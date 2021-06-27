using System;
using System.Collections.Generic;
using System.Text;
using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x40)]
    public class SnMathsFunction : NMSTemplate
    {
        /* 0x0 */ public NMSString0x40 Expression;
        // IONode: In: 0: x; Out: 0: y
    }
}
