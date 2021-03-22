using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x18)]
    public class SnIfAnimIsPlaying : NMSTemplate
    {
        /* 0x00 */ public bool Not;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x01 */ public byte[] Padding1;
        [NMS(Size = 0x10)]
        /* 0x08 */ public string Anim;
        // OutNode: Unnamed
    }
}
