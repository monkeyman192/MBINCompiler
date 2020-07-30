using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.Source.NMS.SketchNodes
{
    [NMS(Size = 0x8)]
    public class SnWaitFrames : NMSTemplate
    {
        /* 0x0 */ public int Frames;
        /* 0x4 */ public int Unknown4;  // Same deal as SnWaitSeconds... Possibly the return value?
        // OutNode: Unnamed
    }
}
