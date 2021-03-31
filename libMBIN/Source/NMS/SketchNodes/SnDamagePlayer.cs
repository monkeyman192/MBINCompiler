using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x18)]
    public class SnDamagePlayer : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Damage;
        /* 0x10 */ public float Range;
        [NMS(Size = 0x4, Ignore = true, Padding = 0x44)]
        /* 0x14 */ public byte[] EndPadding;
        // IONode: Out: 0: Src, 1: Damage, 2: Range
    }
}
