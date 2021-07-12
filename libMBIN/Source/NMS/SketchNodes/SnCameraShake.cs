﻿using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x18)]
    public class SnCameraShake : NMSTemplate
    {
        /* 0x00 */ public SnNMSString0x10 ShakeId;
        /* 0x10 */ public float Range;
        [NMS(Size = 0x4)]
        /* 0x14 */ public byte[] EndPadding;
        // IONode: Out: 0: Src, 1: ShakeId, 2: Range
    }
}
