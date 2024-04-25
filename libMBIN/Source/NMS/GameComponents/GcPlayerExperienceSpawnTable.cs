using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD9E830C7BE45A916, NameHash = 0xA1B202DE9A10A705)]
    public class GcPlayerExperienceSpawnTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Event;
        [NMS(Index = 5)]
        /* 0x10 */ public List<GcPlayerExperienceSpawnData> Spawns;
        // size: 0x2
        public enum ExperienceSpawnTypeEnum : uint {
            Freighter,
            Mission,
        }
        [NMS(Index = 1)]
        /* 0x20 */ public ExperienceSpawnTypeEnum ExperienceSpawnType;
        [NMS(Index = 3)]
        /* 0x24 */ public float PerSpawnDelay;
        [NMS(Index = 2)]
        /* 0x28 */ public float ResponseRate;
        [NMS(Index = 4)]
        /* 0x2C */ public bool Destroy;
    }
}
