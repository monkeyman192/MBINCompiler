using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x28)]
    public class SnSetVariableValue : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Variable;
        /* 0x10 */ public NMSString0x10 Value;
        /* 0x20 */ public bool NetSync;
        [NMS(Size = 0x7)]
        /* 0x21 */ public byte[] EndPadding;
        // IONode: Out: 0: Src, 1: Value, 2: Variable, 3: NetSync
    }
}
