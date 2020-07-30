using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x8)]
    public class SnWaitSeconds : NMSTemplate
    {
        /* 0x0 */ public float Seconds;
        /* 0x4 */ public float Unknown4;  // This hasn't got a name, but there is an un-named return node... Maybe this is the return value??
        // OutNode: Unnamed
    }
}
