using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x8)]
    public class SnSetScannableComponentUsed : NMSTemplate
    {
        /* 0x0 */ public bool Used;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x1 */ public byte[] Endpadding;
        // OutNode: Unnamed
    }
}
