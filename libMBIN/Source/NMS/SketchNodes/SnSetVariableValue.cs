using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x28)]
    class SnSetVariableValue
    {
        /* 0x00 */ public NMSString0x10 Variable;
        /* 0x10 */ public NMSString0x10 Value;
        /* 0x20 */ public bool NetSync;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x21 */ public byte[] EndPadding;
    }
}
