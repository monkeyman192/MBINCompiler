using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5A6C4893F16F15B9, NameHash = 0xC3662A7D)]
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
