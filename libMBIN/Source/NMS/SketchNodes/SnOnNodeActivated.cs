using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x10)]
    public class SnOnNodeActivated : NMSTemplate
    {
        /* 0x00 */ public SnNMSString0x10 Name;
        // OutNode: 0: Active, 1 "Sketch Node Active"
    }
}
