using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x20)]
    public class SnRaiseEvent : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Event;
        /* 0x00 */ public NMSString0x10 Value;
        // IONode: Out: 0: Src, 1: Value, 2: Event
    }
}
