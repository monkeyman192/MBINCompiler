using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x9867783D0630B771, NameHash = 0xEE0A249BBB7EC33)]
    public class GcCreatureFootParticleData : NMSTemplate
    {
        public List<GcCreatureFootParticleSingleData> ParticleData;
    }
}