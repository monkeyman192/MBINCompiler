using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x18)]
    public class SnPlayAnim : NMSTemplate
    {
        /* 0x00 */ public SnNMSString0x10 Anim;
        /* 0x10 */ public bool Synchronised;
        [NMS(Size = 0x7)]
        /* 0x11 */ public byte[] EndPadding;
        // IONode: Out: 0: Src, 1: Anim
    }
}
