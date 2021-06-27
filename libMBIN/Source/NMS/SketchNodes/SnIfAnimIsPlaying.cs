using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x18)]
    public class SnIfAnimIsPlaying : NMSTemplate
    {
        /* 0x00 */ public bool Not;
        [NMS(Size = 0x7, Ignore = true)]    // sometimes has Padding = 0x44, sometimes doesn't...?
        /* 0x01 */ public byte[] Padding1;
        /* 0x08 */ public NMSString0x10 Anim;
        // IONode: Out: 0: Src, 1: Anim
    }
}
