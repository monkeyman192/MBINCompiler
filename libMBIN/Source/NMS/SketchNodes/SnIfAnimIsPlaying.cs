using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x18)]
    public class SnIfAnimIsPlaying : NMSTemplate
    {
        /* 0x00 */ public byte Not;     // This is a byte because the following 7 bytes plus this are something something other than a bool and 7 bytes of padding...
        // If Not is a 1, then it is the bool...
        [NMS(Size = 0x7)]    // sometimes has Padding = 0x44, sometimes doesn't...?
        /* 0x01 */ public byte[] Padding1;
        /* 0x08 */ public SnNMSString0x10 Anim;
        // IONode: Out: 0: Src, 1: Anim
    }
}
