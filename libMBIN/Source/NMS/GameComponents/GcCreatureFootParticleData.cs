using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC9F7EDE6001B69D4, NameHash = 0xEE0A249BBB7EC33)]
    public class GcCreatureFootParticleData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCreatureFootParticleSingleData> ParticleData;
    }
}
