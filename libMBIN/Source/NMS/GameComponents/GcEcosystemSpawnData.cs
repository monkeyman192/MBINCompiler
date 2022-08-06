using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x90ED3B618A3267E5, NameHash = 0xB2F82AE85A5CD5EE)]
    public class GcEcosystemSpawnData : NMSTemplate
    {
        /* 0x00 */ public List<GcEcosystemCreatureData> Creatures;
        /* 0x10 */ public float CreatureMinNoise;
        /* 0x14 */ public float CreatureMaxNoise;
    }
}
