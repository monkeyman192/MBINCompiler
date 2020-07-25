using System;
using System.Collections.Generic;
using System.Text;
using libMBIN.NMS.Toolkit;

namespace libMBIN.Source.NMS.SketchNodes
{
    [NMS(Size = 0x18)]
    class SnIfValueIs
    {
        /* 0x00 */ public TkSketchConditions Condition;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x04 */ public byte[] Padding4;
        [NMS(Size = 0x10)]
        /* 0x08 */ public string Is;
        [NMS(Size = 0x10, Ignore = true)]
        /* 0x04 */ public byte[] EndPadding;    // not too sure about this....
    }
}
