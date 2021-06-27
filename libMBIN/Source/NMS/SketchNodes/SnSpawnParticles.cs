using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x20)]
    public class SnSpawnParticles : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Particles;
        /* 0x10 */ public NMSString0x10 AtNode;
        // IONode: Out: 0: Src, 1: Particle, 2: AtNode
    }
}
