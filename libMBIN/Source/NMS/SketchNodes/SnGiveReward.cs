using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.Source.NMS.SketchNodes
{
    [NMS(Size = 0x0)]
    public class SnGiveReward : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x0 */ public string Reward;
        // OutNode: Unnamed
    }
}
