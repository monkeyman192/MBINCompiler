using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3A558FBCD553141, NameHash = 0x46853662)]
    public class GcFiendCrimeSpawnTable : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public List<GcFiendCrimeSpawnData> Spawns;
        [NMS(Index = 0)]
        /* 0x10 */ public GcFiendCrime Crime;
        [NMS(Index = 1)]
        /* 0x14 */ public float ResponseRate;
    }
}
