using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.Source.NMS.SketchNodes
{
    [NMS(Size = 0x28)]
    class SnSetVariableValue
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Variable;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string Value;
        /* 0x20 */ public bool NetSync;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x21 */ public byte[] EndPadding;
    }
}
