using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7CEC8C3BD7ACD602, NameHash = 0x9110C2E1)]
    public class GcPlayerExperienceSpawnTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Event;
        [NMS(Index = 6)]
        /* 0x10 */ public List<GcPlayerExperienceSpawnData> Spawns;
        // size: 0x2
        public enum ExperienceSpawnTypeEnum : uint {
            Freighter,
            Mission,
        }
        [NMS(Index = 1)]
        /* 0x20 */ public ExperienceSpawnTypeEnum ExperienceSpawnType;
        [NMS(Index = 3)]
        /* 0x24 */ public float InitialDelay;
        [NMS(Index = 4)]
        /* 0x28 */ public float PerSpawnDelay;
        [NMS(Index = 2)]
        /* 0x2C */ public float ResponseRate;
        [NMS(Index = 5)]
        /* 0x30 */ public bool Destroy;
    }
}
