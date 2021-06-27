using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x20)]
    public class SnOnAnimFrame : NMSTemplate
    {
        /* 0x00 */ public int Frame;
        /* 0x08 */ public NMSString0x10 Anim;
        [NMS(Size = 0x8)]
        /* 0x18 */ public byte[] Endpadding;
        // OutNode: 0: Src
    }
}
