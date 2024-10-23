using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x35177F02DE3718B5, NameHash = 0x45284367)]
    public class GcCreatureParticleEffects : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCreatureParticleEffectData> ParticleEffects;
    }
}
