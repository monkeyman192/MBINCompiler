using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x1)]
    public class SnSetScannableComponentUsed : NMSTemplate
    {
        /* 0x0 */ public bool Used;
        // IONode: Out: 0: Src, 1: Used
    }
}
