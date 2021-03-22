using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x20)]
    public class SnRaiseEvent : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Event;
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Value;
        // OutNode: Unnamed
    }
}
