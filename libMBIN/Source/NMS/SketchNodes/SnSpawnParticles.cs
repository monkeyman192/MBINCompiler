using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x20)]
    public class SnSpawnParticles : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Particles;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string AtNode;
        // IONode: Out: 0: Src, 1: Particle, 2: AtNode
    }
}
