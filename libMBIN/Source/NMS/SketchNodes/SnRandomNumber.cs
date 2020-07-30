using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x8)]
    public class SnRandomNumber : NMSTemplate
    {
        /* 0x0 */ public float Min;
        /* 0x4 */ public float Max;
        // OutNode: 'Number'
    }
}
