using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x20)]
    public class SnSetLightColour : NMSTemplate
    {
        /* 0x00 */ public SnNMSString0x10 Light;
        /* 0x10 */ public Colour Colour;
        // IONode: Out: 0: Src, 1: Light, 2: Colour
    }
}
