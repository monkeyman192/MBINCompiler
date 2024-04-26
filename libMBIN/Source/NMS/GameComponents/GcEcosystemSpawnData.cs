using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7B710B6ECC0C1CD5, NameHash = 0xB2F82AE85A5CD5EE)]
    public class GcEcosystemSpawnData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<GcEcosystemCreatureData> Creatures;
        [NMS(Index = 2)]
        /* 0x10 */ public float CreatureMaxNoise;
        [NMS(Index = 1)]
        /* 0x14 */ public float CreatureMinNoise;
    }
}
