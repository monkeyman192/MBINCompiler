using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.Source.NMS.SketchNodes
{
    [NMS(Size = 0x8)]
    class SnWaitSeconds
    {
        /* 0x0 */ public float Seconds;
        /* 0x4 */ public int Unknown4;
    }
}
