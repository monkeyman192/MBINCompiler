using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD66DBA48EEBA7D34, NameHash = 0xCC34EA26)]
    public class GcCreatureFootParticleData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCreatureFootParticleSingleData> ParticleData;
    }
}
