using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.Source.NMS.SketchNodes
{
    [NMS(Size = 0x20)]
    public class SnOnAnimFrame : NMSTemplate
    {
        /* 0x00 */ public int Frame;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x04 */ public byte[] Padding4;
        [NMS(Size = 0x10)]
        /* 0x08 */ public string Anim;
        [NMS(Size = 0x8)]
        /* 0x18 */ public byte[] Endpadding;
        // IONode: Unnamed
    }
}
