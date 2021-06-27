using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x10)]
    public class SnStopAnim : NMSTemplate
    {
        /* 0x0 */ public NMSString0x10 Anim;
        // IONode: Out: 0: Src, 1: Anim
    }
}
