﻿using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.Source.NMS.SketchNodes
{
    [NMS(Size = 0x20)]
    public class SnSpawnParticles : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Particles;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string AtNode;
        // OutNode: Unnamed
    }
}
