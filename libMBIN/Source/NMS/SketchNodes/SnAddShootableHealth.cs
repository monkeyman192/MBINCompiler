using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.Source.NMS.SketchNodes
{
    [NMS(Size = 0x30)]
    public class SnAddShootableHealth : NMSTemplate
    {
        /* 0x00 */ public int Health;  // It's not actually health, I'd say an enum of some kind...
        /* 0x04 */ public float Duration;
        [NMS(Size = 0x24)]
        /* 0x08 */ public byte[] Curve;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x3C */ public byte[] EndPadding;
    }
}
