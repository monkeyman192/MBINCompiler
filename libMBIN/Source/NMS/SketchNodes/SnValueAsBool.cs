using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x8)]
    public class SnValueAsBool : NMSTemplate
    {
        /* 0x0 */ public bool Invert;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x1 */ public byte[] EndPadding;
    }
}
