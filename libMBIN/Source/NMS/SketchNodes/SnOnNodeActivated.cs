using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x10)]
    public class SnOnNodeActivated : NMSTemplate
    {
        // Sketch Node Active
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Name;
        // OutNode: 0: Active, 1 "Sketch Node Active"
    }
}
