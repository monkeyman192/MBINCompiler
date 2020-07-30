using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.Source.NMS.SketchNodes
{
    [NMS(Size = 0x18)]
    public class SnOnNodeActivated : NMSTemplate
    {
        // Sketch Node Active
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Name;
        /* 0x10 */ public bool Active;  // A guess. The data type isn't there... Seems to match data in mbin
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x11 */ public byte[] EndPadding;
        // IONode: Unnamed
    }
}
