using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x4)]
    public class SnWaitFrames : NMSTemplate
    {
        /* 0x0 */ public int Frames;
        // OutNode: Unnamed
    }
}
