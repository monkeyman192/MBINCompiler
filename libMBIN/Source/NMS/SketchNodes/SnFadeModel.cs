using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x8)]
    public class SnFadeModel : NMSTemplate
    {
        /* 0x0 */ public bool FadeIn;
        [NMS(Size = 0x3)]
        /* 0x1 */ public byte[] Padding1;
        /* 0x4 */ public float Seconds;
        // IONode: Out: 0: Src, 1: Seconds, 2: FadeIn
    }
}
