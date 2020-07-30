using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.Source.NMS.SketchNodes
{
    [NMS(Size = 0x10)]
    public class SnBroadcastValueModel : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x0 */ public string Value;
        // OutNode: Unnamed
    }
}
