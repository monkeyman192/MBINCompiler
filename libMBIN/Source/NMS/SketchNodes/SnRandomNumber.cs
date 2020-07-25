using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.Source.NMS.SketchNodes
{
    [NMS(Size = 0x8)]
    class SnRandomNumber
    {
        /* 0x0 */ public float Min;
        /* 0x4 */ public float Max;
    }
}
