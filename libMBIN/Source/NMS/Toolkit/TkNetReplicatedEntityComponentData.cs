using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x4A0243DD40AA8081, NameHash = 0xDB0FD87A0597E5FD)]
    public class TkNetReplicatedEntityComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<NMSString0x80> ReplicaComponentMask;
        // size: 0x8
        public enum ReplicationRangeEnum : uint {
            NotSet,
            System,
            SystemLocal,
            Planet,
            PlanetLocal,
            Space,
            SpaceStation,
            Nexus,
        }
        [NMS(Index = 1)]
        /* 0x10 */ public ReplicationRangeEnum ReplicationRange;
        // size: 0x2
        public enum SpawnTypeEnum : uint {
            Basic,
            Creature,
        }
        [NMS(Index = 2)]
        /* 0x14 */ public SpawnTypeEnum SpawnType;
        [NMS(Index = 3)]
        /* 0x18 */ public bool IgnoreComponents;
    }
}
