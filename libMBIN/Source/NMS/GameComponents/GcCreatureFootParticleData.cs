using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB404BD0AE7AD4A53, NameHash = 0xEE0A249BBB7EC33)]
    public class GcCreatureFootParticleData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCreatureFootParticleSingleData> ParticleData;
    }
}
