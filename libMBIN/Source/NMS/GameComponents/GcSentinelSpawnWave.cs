using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9877FBF5EEC01E22, NameHash = 0x5CF9A5D0C4877494)]
    public class GcSentinelSpawnWave : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 1)]
        /* 0x10 */ public List<GcSentinelSpawnData> Spawns;
        [NMS(Index = 2)]
        /* 0x20 */ public int ReinforceAt;
    }
}
