using System;
using System.Collections.Generic;
using System.Text;
using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x18)]
    public class SnIfValueIs : NMSTemplate
    {
        /* 0x0 */ public TkSketchConditions Condition;
        [NMS(Size = 0x4, Ignore = true, Padding = 0x44)]
        /* 0x4 */ public byte[] Padding4;
        [NMS(Size = 0x10)]
        /* 0x8 */ public string Is;
        // IONode: Out: 0: Value, 1 & 2: "Value as bool"; In: 0: Src, 1: Is True, 2: Is False
    }
}
