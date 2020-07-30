using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.Source.NMS.SketchNodes
{
    [NMS(Size = 0x18)]
    public class SnDamagePlayer : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Damage;
        /* 0x10 */ public float Range;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x14 */ public byte[] EndPadding;
        // OutNode: Unnamed
    }
}
