﻿using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x4)]
    public class SnWaitSeconds : NMSTemplate
    {
        /* 0x0 */ public float Seconds;
        // OutNode: Unnamed
    }
}
