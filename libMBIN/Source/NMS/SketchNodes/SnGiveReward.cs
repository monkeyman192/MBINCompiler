using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x10)]
    public class SnGiveReward : NMSTemplate
    {
        /* 0x0 */ public SnNMSString0x10 Reward;
        // IONode: Out: 0: Src, 1: Reward
    }
}
