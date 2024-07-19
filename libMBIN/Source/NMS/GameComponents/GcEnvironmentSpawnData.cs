using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x31ACF2CCE6E9037, NameHash = 0x9776A7F7)]
    public class GcEnvironmentSpawnData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<GcCreatureSpawnData> Creatures;
        [NMS(Index = 4)]
        /* 0x10 */ public List<GcObjectSpawnData> DetailObjects;
        [NMS(Index = 1)]
        /* 0x20 */ public List<GcObjectSpawnData> DistantObjects;
        [NMS(Index = 2)]
        /* 0x30 */ public List<GcObjectSpawnData> Landmarks;
        [NMS(Index = 3)]
        /* 0x40 */ public List<GcObjectSpawnData> Objects;
        [NMS(Index = 5)]
        /* 0x50 */ public List<GcSelectableObjectSpawnList> SelectableObjects;
    }
}
